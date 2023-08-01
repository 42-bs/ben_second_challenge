namespace Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Api.Data;
    using Api.Data.DTOs;
    using Api.Models;
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
        public IEnumerable<ReadDataPointHistoryDto> GetDataPointHistory()
        {
            return _mapper.Map<List<ReadDataPointHistoryDto>>(_repo.GetAllAsync());
        }
    }
}