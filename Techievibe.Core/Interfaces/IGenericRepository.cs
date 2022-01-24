using System.Collections.Generic;
using System.Threading.Tasks;

namespace Techievibe.Core.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task<int> Add(T entity);
        Task<int> Update(int id);
        Task<int> Delete(int id);
    }
}
