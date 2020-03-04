using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;

namespace Contract
{
    public interface IValueRepository
    {
        Task<ICollection<Value>> GetAll(bool trackChanges = false);
        Task<Value> GetOneById(int valueId, bool trackChanges = false);
    }
}