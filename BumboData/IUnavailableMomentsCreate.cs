using BumboData.Models;

namespace BumboData
{
    public interface IUnavailableMomentsCreate
    {
        IEnumerable<UnavailableMoment> GetAll();
        void Add(UnavailableMoment unavailableMoment);
        void AddEmployeeToUnavailableMoment(UnavailableMoment unavailableMoment);
    }
}
