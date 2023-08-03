namespace Api.Repositories
{
    using Api.Models;

    /// <summary>
    /// Interface to Repository from DataPointHistory.
    /// </summary>
    public interface IDataPointHistoryRepository
    {
        /// <summary>
        /// Prototype from the wanted concrete class method.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task<IEnumerable<DataPointHistory>> GetAllAsync();
    }
}
