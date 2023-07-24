namespace Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Api.Data;
    using Api.Data.DTOs;
    using Api.Models;
    using AutoMapper;

    [ApiController]
    [Route("[controller]")]
    public class DataPointHistoryController: ControllerBase
    {
        private readonly DataPointDbContext _context;
        private readonly IMapper _mapper;
        public DataPointHistoryController(DataPointDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        [HttpGet]
        public IEnumerable<ReadDataPointHistoryDto> Cavalinho()
        {
            return _mapper.Map<List<ReadDataPointHistoryDto>>(_context.DataPointHistoryTable.ToList());
        }
    }
}