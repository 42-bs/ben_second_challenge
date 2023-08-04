namespace Api.Profiles
{
    using Api.Data.DTOs;
    using Api.Models;
    using AutoMapper;

    /// <summary>
    /// Does the mapping rules from Model to DTO and from DTO to Model.
    /// </summary>
    public class DataPointProfile : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataPointProfile"/> class.
        /// </summary>
        public DataPointProfile()
        {
            CreateMap<DataPoint, ReadDataPointDto>();
            CreateMap<ReadDataPointDto, DataPoint>();
        }
    }
}