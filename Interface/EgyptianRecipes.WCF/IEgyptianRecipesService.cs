using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace EgyptianRecipes.WCF
{
    [ServiceContract]
    public interface IEgyptianRecipesService
    {
        [OperationContract]
        bool ValidateBranch(Entities.Branch branch, out List<string> errorMessages);

        [OperationContract]
        List<Entities.Branch> GetAllBranches();

        [OperationContract]
        Entities.Branch GetBranchesByID(long ID);

        [OperationContract]
        bool InsertNewBranch(Entities.Branch branch, out List<string> errorMessages);

        [OperationContract]
        bool UpdateBranch(Entities.Branch branch, out List<string> errorMessages);

        [OperationContract]
        bool DeleteBranch(long ID);
    }
}

