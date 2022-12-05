using BumboData.Models;

namespace BumboServices.Interface
{
    public interface IPrognosesService
    {
        double GetCassierePrognose(DateTime date, int branchId);
        double GetFreshPrognose(DateTime date, int branchId);
        double GetStockersPrognose(DateTime date, int branchId);
    }
}