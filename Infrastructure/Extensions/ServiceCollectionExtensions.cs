using Core.Interfaces;
using Core.Entities;
using DapperDAL;
using DapperDAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Core.Interfaces.Commands;
using BLL.Commnds.Project;

namespace Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddProjectRepositories(this IServiceCollection services) =>
           services
            .AddSingleton<IProjectRepository, MockDAL.Repositories.ProjectRepository>();
        //.AddSingleton<IProjectRepository, ProjectRepository>();

        public static IServiceCollection AddProjectCommands(this IServiceCollection services) =>
            services
                .AddSingleton<IGetProjectCommand, GetProjectCommand>();

    }
}
