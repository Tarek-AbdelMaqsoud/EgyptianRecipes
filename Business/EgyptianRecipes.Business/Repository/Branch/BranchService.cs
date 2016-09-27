using EgyptianRecipes.Business.IRepository.IBranch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptianRecipes.Business.Repository.Branch
{
    public class BranchService : IBranchService
    {
        private IBranchRepository _rep { get; set; }
        public BranchService(IBranchRepository rep)
        {
            _rep = rep;
        }
        public IEnumerable<Entities.Branch> GetAll()
        {
            return _rep.GetAll();
        }
        public Entities.Branch GetByID(long ID)
        {
            return _rep.GetByID(ID);
        }
        public bool Insert(Entities.Branch branch)
        {
            return _rep.Insert(branch);
        }
        public bool Update(Entities.Branch branch)
        {
            return _rep.Update(branch);
        }
        public bool Delete(long ID)
        {
            return _rep.Delete(ID);
        }
        public ICollection<string> Validate(Entities.Branch branch)
        {
            List<string> result = new List<string>();
            string validBranch = string.Empty;
            if(!ValidateBranch(branch, out validBranch))
            {
                result.Add(validBranch);
                return result;
            }

            result.Add(ValidateTitle(branch.Title));
            result.Add(ValidateTime(branch.OpeningHourValue));
            result.Add(ValidateTime(branch.ClosingHourValue));
            result.Add(ValidateTime(branch.OpeningHourValue, branch.ClosingHourValue));
            result.Add(ValidateManagerName(branch.ManagerName));

            result = result.Where(s => !string.IsNullOrWhiteSpace(s)).ToList();

            return result;
        }
        private bool ValidateBranch(Entities.Branch branch, out string result)
        {
            result = string.Empty;
            if (branch == null)
            {
                result = "branch cannot be null.";
            }
            return (result == string.Empty);
        }
        private string ValidateTitle(string title)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(title))
            {
                result = "Title is Required.";
            }
            else if (title.Length > 200)
            {
                result = "Title shall not exceed 200 character";
            }
            return result;
        }
        private string ValidateManagerName(string managerName)
        {
            string result = string.Empty;
            if (string.IsNullOrEmpty(managerName))
            {
                result = "Manager Name is Required.";
            }
            else if (managerName.Length > 250)
            {
                result = "Manager Name shall not exceed 250 character";
            }
            return result;
        }
        private string ValidateTime(TimeSpan time)
        {
            string result = string.Empty;
            if (time == null)
            {
                result = "Opening/Closing Hour is Required.";
            }
            else if (time.TotalHours <= 0 && time.Minutes <= 0)
            {
                result = "Opening/Closing Hour shall be greater than or equal 00:00";
            }
            else if (time.TotalHours >= 24)
            {
                result = "Opening/Closing Hour shall be less than or equal 23:30";
            }
            else if(time.Minutes > 0 && time.Minutes != 30)
            {
                result = "Opening/Closing Hour have only 00:30 minutes interval";
            }
            return result;
        }
        private string ValidateTime(TimeSpan openingHour, TimeSpan closingHour)
        {
            string result = string.Empty;
            if (TimeSpan.Compare(closingHour, openingHour) <=0)
            {
                result = "Opening Hour must be greater than the Closing Hour";
            }
            return result;
        }
    }
}
