using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyptianRecipes.Business.IRepository.IGenericRepository
{
    public interface IGenericRepository<T> where T : class
    {
        bool Insert(T entity);
        IEnumerable<T> GetAll();
        T GetByID(long ID);
        bool Update(T entity);
        bool Delete(long ID);
    }
}
