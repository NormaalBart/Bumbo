using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Utils;
using BumboServices.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BumboServices.Prognoses
{
    public class PrognosesService : IPrognosesService
    {
        readonly IPrognosisRepository _prognosisRepository;
        readonly IStandardRepository _standardRepository;
        public PrognosesService(IPrognosisRepository prognosisRepository, IStandardRepository standardRepository)
        {
            _prognosisRepository = prognosisRepository;
            _standardRepository = standardRepository;
        }

        public double GetCassierePrognose(DateTime date)
        {
            Prognosis prognosis = _prognosisRepository.GetByDate(date.ToDateOnly());
            if (prognosis != null)
            {
                Standard standard = _standardRepository.Get(StandardType.CHECKOUT_EMPLOYEES, prognosis.Branch);
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
        public double GetFreshPrognose(DateTime date)
        {
            Prognosis prognosis = _prognosisRepository.GetByDate(date.ToDateOnly());
            if (prognosis != null)
            {
                Standard standard = _standardRepository.Get(StandardType.FRESH_EMPLOYEES, prognosis.Branch);
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
        public double GetStockersPrognose(DateTime date)
        {
            Prognosis prognosis = _prognosisRepository.GetByDate(date.ToDateOnly());
            if (prognosis != null)
            {
                Standard coliUnloadTimeInMin = _standardRepository.Get(StandardType.COLI_TIME, prognosis.Branch);
                Standard coliStockTimeInMin = _standardRepository.Get(StandardType.SHELF_STOCKING_TIME, prognosis.Branch);
                Standard shelfArragementTimeInSec = _standardRepository.Get(StandardType.SHELF_ARRANGEMENT, prognosis.Branch);
                if (coliUnloadTimeInMin != null || coliStockTimeInMin != null || shelfArragementTimeInSec != null)
                {
                    Double timeSpentOnColiInMin = (coliUnloadTimeInMin.Value + coliStockTimeInMin.Value) * prognosis.ColiCount;
                    Double timeSpentOnShelfsInMin = (shelfArragementTimeInSec.Value * prognosis.Branch.ShelvingDistance) / 60;

                    return (timeSpentOnColiInMin + timeSpentOnShelfsInMin) / 60;
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
