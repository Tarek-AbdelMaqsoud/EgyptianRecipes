using EgyptianRecipes.Business.IRepository.IBranch;
using EgyptianRecipes.Entities;
using EgyptianRecipes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptianRecipes.Business.Repository.Branch
{
    public class BranchRepository : IBranchRepository
    {
        private EgyptianRecipesContext _db { get; set; }
        public BranchRepository()
        {
            _db = new EgyptianRecipesContext();
        }
        public IEnumerable<Entities.Branch> GetAll()
        {
            return _db.Branches.Where(b => !b.IsRemoved).ToList();
        }
        public Entities.Branch GetByID(long ID)
        {
            return _db.Branches.Where(b => b.BranchID == ID && !b.IsRemoved).FirstOrDefault();
        }
        public bool Insert(Entities.Branch branch)
        {
            _db.Branches.Add(branch);
            return (_db.SaveChanges() > 0);
        }
        public bool Update(Entities.Branch branch)
        {
            _db.Entry(branch).State = System.Data.Entity.EntityState.Modified;
            return (_db.SaveChanges() > 0);
        }
        public bool Delete(long ID)
        {
            Entities.Branch branch = this.GetByID(ID);
            if (branch != null)
            {
                branch.IsRemoved = true;
                return this.Update(branch);
            }
            return false;
        }
    }

}
