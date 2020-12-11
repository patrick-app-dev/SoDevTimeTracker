using Core.Interfaces;
using Core.Entities;
using DapperDAL;
using DapperDAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddProjectRepositories(this IServiceCollection services) =>
           services
            .AddSingleton<IDbConnectionFactory, DbConnectionFactory>()
            .AddSingleton<IRepository<Project>, MockDAL.Repositories.ProjectRepository>();
            //.AddSingleton<IProjectRepository, ProjectRepository>();


    }
}
