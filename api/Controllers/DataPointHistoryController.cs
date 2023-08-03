namespace Api.Controllers
{
    using Api.Data.DTOs;
    using Api.Repositories;
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Controller for DataPointHistory.
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    [Authorize(Policy = "Bearer")]
    public class DataPointHistoryController : ControllerBase
    {
        private readonly IDataPointHistoryRepository repo;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPointHistoryController"/> class.
        /// Constructor of controller.
        /// </summary>
        /// <param name="repo">Repository to access database.</param>
        /// <param name="mapper">Transforms the DTO into a model.</param>
        public DataPointHistoryController(IDataPointHistoryRepository repo, IMapper mapper)
        {
            this.repo = repo;
            this.mapper = mapper;
        }

        /// <summary>
        /// Gets all the DataPointHistories from database and returns them mapped to the DTO.
        /// </summary>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        [HttpGet]
        public async Task<IEnumerable<ReadDataPointHistoryDto>> GetDataPointHistory()
        {
            var dataPointHistoryModel = await repo.GetAllAsync();
            return mapper.Map<List<ReadDataPointHistoryDto>>(dataPointHistoryModel);
        }
    }
}