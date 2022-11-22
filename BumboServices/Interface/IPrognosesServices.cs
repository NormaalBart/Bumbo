namespace BumboServices.Interface
{
    public interface IPrognosesService
    {
        double GetCassierePrognose(DateTime date);
        double GetFreshPrognose(DateTime date);
        double GetStockersPrognose(DateTime date);
    }
}