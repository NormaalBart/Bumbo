using BumboData.Models;

namespace BumboServices.Interface
{
    public interface IPrognosesService
    {
        (int Workers, Double Hours) GetCassierePrognose(DateTime date, int branchId);
        (int Workers, Double Hours) GetFreshPrognose(DateTime date, int branchId);
        double GetStockersPrognoseHours(DateTime date, int branchId);
    }
}