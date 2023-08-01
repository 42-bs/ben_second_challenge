namespace Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Api.Data.DTOs;
    using AutoMapper;
    using Microsoft.AspNetCore.Authorization;
    using api.Repositories;

    [ApiController]
    [Route("[controller]")]
    [Authorize(Policy = "Bearer")]
    public class DataPointHistoryController: ControllerBase
    {
        private readonly IDataPointHistoryRepository _repo;
        private readonly IMapper _mapper;
        public DataPointHistoryController(IDataPointHistoryRepository repo, IMapper mapper)
        {
            this._repo = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ReadDataPointHistoryDto>> GetDataPointHistory()
        {
            var dataPointHistoryModel = await _repo.GetAllAsync();
            return _mapper.Map<List<ReadDataPointHistoryDto>>(dataPointHistoryModel);
        }
    }
}