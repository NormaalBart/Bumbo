﻿using BumboData.Models;

namespace BumboData.Interfaces.Repositories
{
    public interface IBranchRepository: IRepository<Branch>
    {
        IEnumerable<Branch> GetAllActiveBranches();
        List<Branch> GetUnmanagedBranches();
        void SetInactive(int id);
        void SetActive(int id);
    }
}
