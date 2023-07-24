namespace Api.Profiles
{
    using AutoMapper;
    using Api.Data.DTOs;
    using Api.Models;

    public class DataPointHistoryProfile: Profile {
        public DataPointHistoryProfile() {
            // CreateMap<ReadDataPointHistoryDto, DataPointHistory>();
            CreateMap<DataPointHistory, ReadDataPointHistoryDto>()
            .ForMember(dto => dto.DataPoint, opt => opt.MapFrom(datapointhistory => datapointhistory.DataPoint));
        }
    }
}