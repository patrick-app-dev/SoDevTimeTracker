using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Constants;
using Infrastructure.DTO.Request;
using AutoMapper;
using Infrastructure.Mappers;
using Infrastructure.DTO.Response;

namespace Infrastructure.Commands.Project
{
    public class PostProjectCommand : IPostProjectCommand
    {
        private readonly IProjectRepository projectRepo;
        private readonly IMapper mapper;

        public PostProjectCommand(IProjectRepository projectRepository, IMapper mapper)
        {
            this.projectRepo = projectRepository;
            this.mapper = mapper;
        }
        public IActionResult Execute(CreateProjectRequest project)
        {
            if (project is null)
                return new NoContentResult();


            var entity = Mapping.Mapper.Map<Core.Entities.Project>(project);
            entity.CreatedAt = DateTime.Now;
            entity.CreatedBy = 1;
            entity.ModifiedAt = DateTime.Now;
            entity.ModifiedBy = 1;
            var postProject = this.projectRepo.Add(entity);
            var responseProject = Mapping.Mapper.Map<ProjectQueryResponse>(postProject);
            return new CreatedAtRouteResult(
                ProjectsControllerRoute.GetProject,
                new { id = postProject.Id },
                responseProject);
        }
    }
}
