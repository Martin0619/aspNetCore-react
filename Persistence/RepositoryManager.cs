using System.Threading.Tasks;
using Contract;

namespace Persistence
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly DataContext _context;
        public RepositoryManager(
            DataContext context,
            IValueRepository value)
        {
            this._context = context;
            Value = value;
        }

        public IValueRepository Value { get; }

        public Task SaveChangesAsync() =>
            _context.SaveChangesAsync();
    }
}