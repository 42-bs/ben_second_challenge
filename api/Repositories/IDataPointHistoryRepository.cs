using Api.Models;

namespace api.Repositories
{
    public interface IDataPointHistoryRepository
    {
        Task<IEnumerable<DataPointHistory>> GetAllAsync();
    }
}
