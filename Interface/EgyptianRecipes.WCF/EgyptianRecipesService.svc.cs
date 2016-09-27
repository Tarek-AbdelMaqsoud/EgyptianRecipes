using EgyptianRecipes.Business.IRepository.IBranch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EgyptianRecipes.WCF
{
    public class EgyptianRecipesService : IEgyptianRecipesService
    {
        private IBranchService _rep { get; set; }
        public EgyptianRecipesService(IBranchService rep)
        {
            _rep = rep;
        }
        public bool ValidateBranch(Entities.Branch branch, out List<string> errorMessages)
        {
            errorMessages = _rep.Validate(branch).ToList();
            return (errorMessages.Count == 0);
        }
        public List<Entities.Branch> GetAllBranches()
        {
            return _rep.GetAll().ToList();
        }
        public Entities.Branch GetBranchesByID(long ID)
        {
            return _rep.GetByID(ID);
        }
        public bool InsertNewBranch(Entities.Branch branch, out List<string> errorMessages)
        {
            if (ValidateBranch(branch, out errorMessages))
            {
                return _rep.Insert(branch);
            }
            else
            {
                return false;
            }
        }
        public bool UpdateBranch(Entities.Branch branch, out List<string> errorMessages)
        {
            if (ValidateBranch(branch, out errorMessages))
            {
                return _rep.Update(branch);
            }
            else
            {
                return false;
            }
        }
        public bool DeleteBranch(long ID)
        {
            return _rep.Delete(ID);
        }
    }
}
