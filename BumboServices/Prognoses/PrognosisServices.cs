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

namespace BumboServices.Prognoses
{
    public class PrognosisService : IPrognosesService
    {
        private readonly int secondsInMin = 60;
        private readonly int MinutesInHour = 60;
        private readonly IPrognosisRepository _prognosisRepository;
        private readonly IStandardRepository _standardRepository;
        public PrognosisService(IPrognosisRepository prognosisRepository, IStandardRepository standardRepository)
        {
            _prognosisRepository = prognosisRepository;
            _standardRepository = standardRepository;
        }

        public double GetCassierePrognose(DateTime date, int branchId)
        {
            var prognosis = _prognosisRepository.GetByDate(date.ToDateOnly(), branchId);
            if (prognosis != null)
            {
                var standard = _standardRepository.Get(StandardType.CHECKOUT_EMPLOYEES, prognosis.Branch);
                if (standard != null)
                {
                    Double customerCount = prognosis.CustomerCount;
                    Double cassierePerCustomersPerHour = standard.Value;
                    return customerCount / cassierePerCustomersPerHour;
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
        public double GetFreshPrognose(DateTime date, int branchId)
        {
            var prognosis = _prognosisRepository.GetByDate(date.ToDateOnly(),branchId);
            if (prognosis != null)
            {
                var standard = _standardRepository.Get(StandardType.FRESH_EMPLOYEES, prognosis.Branch);
                if (standard != null)
                {
                    Double customerCount = prognosis.CustomerCount;
                    Double freshEmployeePerCustomersPerHour = standard.Value;
                    return customerCount / freshEmployeePerCustomersPerHour;
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
        public double GetStockersPrognose(DateTime date, int branchId)
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
