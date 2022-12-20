using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BumboData.Enums;

namespace BumboServices.Prognoses
{
    public class PrognosisService : IPrognosesService
    {
        private readonly int secondsInMin = 60;
        private readonly int MinutesInHour = 60;
        private readonly IPrognosisRepository _prognosisRepository;
        private readonly IStandardRepository _standardRepository;
        private readonly IBranchRepository _branchRepository;
        public PrognosisService(IPrognosisRepository prognosisRepository, IStandardRepository standardRepository , IBranchRepository branchRepository)
        {
            _prognosisRepository = prognosisRepository;
            _standardRepository = standardRepository;
            _branchRepository = branchRepository;
        }

        public (int Workers, double Hours) GetByDepartment(Department dep, DateTime date, int branchId)
        {
            // Can't be a switch because the department id's 'aren't know at compile time'
            if (dep.Id == DepartmentType.Cassiers.DepartmentId)
            {
                return GetCashierPrognose(date, branchId);
            }

            if (dep.Id == DepartmentType.Fillers.DepartmentId)
            {
                return (-1, GetStockersPrognoseHours(date, branchId));
            }

            if (dep.Id == DepartmentType.Fresh.DepartmentId)
            { 
                return GetFreshPrognose(date, branchId);
            }

            return (-1, -1);
        }
        
        public (int Workers, Double Hours) GetCashierPrognose(DateTime date, int branchId)
        {
            var prognosis = _prognosisRepository.GetByDate(date.ToDateOnly(), branchId);
            if (prognosis != null)
            {
                var openingsHours = _branchRepository.GetOpenAndCloseTimes(branchId, date.ToDateOnly());
                var standard = _standardRepository.Get(StandardType.CHECKOUT_EMPLOYEES, prognosis.Branch);
                if (standard != null)
                {
                    Double customerCount = prognosis.CustomerCount;
                    Double cassierePerCustomersPerHour = standard.Value;

                    var timeOpen = openingsHours.Item2 - openingsHours.Item1;
                    var customersPerHours =  customerCount / timeOpen.TotalHours;

                    return ((int)Math.Ceiling(customersPerHours / standard.Value), customerCount / cassierePerCustomersPerHour);
                }
                else
                {
                    return (-1,-1);
                }
            }
            else
            {
                return (-1, -1);
            }
        }
        public (int Workers, Double Hours) GetFreshPrognose(DateTime date, int branchId)
        {
            var prognosis = _prognosisRepository.GetByDate(date.ToDateOnly(),branchId);
            if (prognosis != null)
            {
                var openingsHours = _branchRepository.GetOpenAndCloseTimes(branchId, date.ToDateOnly());
                var standard = _standardRepository.Get(StandardType.FRESH_EMPLOYEES, prognosis.Branch);
                if (standard != null)
                {
                    Double customerCount = prognosis.CustomerCount;
                    Double freshEmployeePerCustomersPerHour = standard.Value;

                    var timeOpen = openingsHours.Item2 - openingsHours.Item1;
                    var customersPerHours = customerCount / timeOpen.TotalHours;

                    return ((int)Math.Ceiling(customersPerHours / standard.Value), customerCount / freshEmployeePerCustomersPerHour);
                }
                else
                {
                    return (-1, -1);
                }
            }
            else
            {
                return (-1, -1);
            }
        }
        public double GetStockersPrognoseHours(DateTime date, int branchId)
        {
            var prognosis = _prognosisRepository.GetByDate(date.ToDateOnly(),branchId);
            if (prognosis != null)
            {
                var coliUnloadTimeInMin = _standardRepository.Get(StandardType.COLI_TIME, prognosis.Branch);
                var coliStockTimeInMin = _standardRepository.Get(StandardType.SHELF_STOCKING_TIME, prognosis.Branch);
                var shelfArragementTimeInSec = _standardRepository.Get(StandardType.SHELF_ARRANGEMENT, prognosis.Branch);
                if (coliUnloadTimeInMin != null || coliStockTimeInMin != null || shelfArragementTimeInSec != null)
                {
                    Double timeSpentOnColiInMin = (coliUnloadTimeInMin.Value + coliStockTimeInMin.Value) * prognosis.ColiCount;
                    Double timeSpentOnShelfsInMin = (shelfArragementTimeInSec.Value * prognosis.Branch.ShelvingDistance) / secondsInMin;

                    return (timeSpentOnColiInMin + timeSpentOnShelfsInMin) / MinutesInHour;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}
