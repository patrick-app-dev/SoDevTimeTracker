using Core.Entities;
using Infrastructure.Commands;
using Infrastructure.DTO.Request;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Commands.Project
{
    public interface IPostProjectCommand : ICommand<CreateProjectRequest>
    {
    }
}
