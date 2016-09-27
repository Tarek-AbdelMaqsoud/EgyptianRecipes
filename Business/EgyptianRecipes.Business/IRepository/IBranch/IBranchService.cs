using EgyptianRecipes.Business.IRepository.IGenericRepository;
using EgyptianRecipes.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptianRecipes.Business.IRepository.IBranch
{
    public interface IBranchService : IGenericRepository<Branch>
    {
        ICollection<string> Validate(Branch branch);
    }
}
