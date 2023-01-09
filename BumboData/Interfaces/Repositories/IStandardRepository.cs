using BumboData.Models;

namespace BumboData.Interfaces.Repositories;

public interface IStandardRepository
{
    Standard Get(StandardType standardType, Branch branch);

    ICollection<Standard> Get(int branch);
    
    void Update(Standard standard);
}