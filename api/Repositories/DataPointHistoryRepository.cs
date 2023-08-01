using Api.Data;
using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories
{
    public class DataPointHistoryRepository : IDataPointHistoryRepository
    {
        private readonly DataPointDbContext _dataPointDbContext;

        public DataPointHistoryRepository(DataPointDbContext dataPointDbContext)
        {
            this._dataPointDbContext = dataPointDbContext;
        }

        public async Task<IEnumerable<DataPointHistory>> GetAllAsync()
        {
            return await _dataPointDbContext.DataPointHistoryTable.ToListAsync();
        }
    }
}
