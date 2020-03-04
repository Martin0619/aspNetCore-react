using System.Collections.Generic;
using System.Threading.Tasks;
using Contract;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class ValueRepository : RepositoryBase<Value>, IValueRepository
    {
        public ValueRepository(DataContext context) : base(context)
        {
        }

        public async Task<ICollection<Value>> GetAll(bool trackChanges = false) =>
            await base.FindAll(trackChanges)
                      .ToArrayAsync();

        public Task<Value> GetOneById(int valueId, bool trackChanges = false) =>
        base.FindByCondition(value => value.Id == valueId, trackChanges)
            .SingleOrDefaultAsync();
    }
}