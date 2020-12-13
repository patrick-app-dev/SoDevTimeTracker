using Core.Interfaces;
using Core.Entities;
using DapperDAL;
using DapperDAL.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Infrastructure.Commnds.Project;
using FluentValidation;
using Infrastructure.DTO.Request;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Commands.Project;

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
                .AddSingleton<IGetProjectCommand, GetProjectCommand>()
                .AddSingleton<IPostProjectCommand, PostProjectCommand>();
        public static IServiceCollection AddProjectValidators(this IServiceCollection services) =>
            //Register DTO Validators
            services
                .AddTransient<IValidator<CreateProjectRequest>, CreateProjectRequestValidator>();

            //Disable Automatic Model State Validation built-in to ASP.NET Core
            //services.Configure<ApiBehaviorOptions>(opt => { opt.SuppressModelStateInvalidFilter = true; });
    }
}
