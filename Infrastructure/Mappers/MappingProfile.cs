
using AutoMapper;
using Core.Entities;
using Infrastructure.DTO.Request;
using Infrastructure.DTO.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Project, CreateProjectRequest>().ReverseMap();
            CreateMap<Project, ProjectQueryResponse>().ReverseMap();
        }
    }
}
