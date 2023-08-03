namespace Api.Repositories
{
    using Api.Data;
    using Api.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// Creates commands to manipulate de database.
    /// </summary>
    public class DataPointHistoryRepository : IDataPointHistoryRepository
    {
        private readonly DataPointDbContext dataPointDbContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPointHistoryRepository"/> class.
        /// </summary>
        /// <param name="dataPointDbContext">Represents the database.</param>
        public DataPointHistoryRepository(DataPointDbContext dataPointDbContext)
        {
            this.dataPointDbContext = dataPointDbContext;
        }

        /// <summary>
        /// Returns a list with all the DataPointHistories from database.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public async Task<IEnumerable<DataPointHistory>> GetAllAsync()
        {
            return await dataPointDbContext.DataPointHistoryTable.ToListAsync();
        }
    }
}
