using BumboData.Models;

namespace BumboServices.Interface
{
    public interface IPrognosesService
    {
        double GetCassierePrognoseAsync(DateTime date, int branchId);
        double GetFreshPrognose(DateTime date, int branchId);
        double GetStockersPrognose(DateTime date, int branchId);
    }
}