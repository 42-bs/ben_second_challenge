namespace Api.Profiles
{
    using AutoMapper;
    using Api.Data.DTOs;
    using Api.Models;

    public class DataPointProfile: Profile {
        public DataPointProfile() {
            CreateMap<DataPoint, ReadDataPointDto>();
            CreateMap<ReadDataPointDto, DataPoint>();
        }
    }
}