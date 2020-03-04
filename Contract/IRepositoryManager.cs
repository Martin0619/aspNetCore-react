using System.Threading.Tasks;

namespace Contract
{
    public interface IRepositoryManager
    {
        IValueRepository Value { get; }
        Task SaveChangesAsync();
    }
}