using Core.Interfaces;
using Core.Interfaces.Commands;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLL.Commnds.Project
{
    public class GetProjectCommand : IGetProjectCommand
    {
        private readonly IProjectRepository projectRepository;

        public GetProjectCommand(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }
        public IActionResult Execute(int projectId)
        {
            var project = this.projectRepository.Get(projectId);
            if (project is null)
                return new NotFoundResult();
            return new OkObjectResult(project);
        }
    }
}
