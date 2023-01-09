using BumboData.Models;

namespace BumboServices.Interface;

public interface IPrognosesService
{
    (int Workers, double Hours) GetCashierPrognose(DateTime date, int branchId);
    (int Workers, double Hours) GetFreshPrognose(DateTime date, int branchId);
    double GetStockersPrognoseHours(DateTime date, int branchId);

    public (int Workers, double Hours) GetByDepartment(Department dep, DateTime date, int branchId);
}