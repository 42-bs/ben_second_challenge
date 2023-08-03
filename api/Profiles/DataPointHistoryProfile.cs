namespace Api.Profiles
{
    using Api.Data.DTOs;
    using Api.Models;
    using AutoMapper;

    /// <summary>
    /// Does the mapping rules from Model to DTO.
    /// </summary>
    public class DataPointHistoryProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataPointHistoryProfile"/> class.
        /// </summary>
        public DataPointHistoryProfile()
        {
            // CreateMap<ReadDataPointHistoryDto, DataPointHistory>();
            CreateMap<DataPointHistory, ReadDataPointHistoryDto>()
            .ForMember(dto => dto.DataPoint, opt =>
                opt.MapFrom(datapointhistory => datapointhistory.DataPoint));
        }
    }
}