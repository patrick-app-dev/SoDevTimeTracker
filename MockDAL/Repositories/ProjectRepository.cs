using Core.Entities;
using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MockDAL.Repositories
{
    public class ProjectRepository : IRepository<Project>
    {
        List<Project> projects = new List<Project>
        {
            new Project()
            {
                AppId = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                Description = "Add Comments to Employer",
                Id = 1,
                Lead = new Guid(),
                ModifiedAt = DateTime.Now,
                ModifiedBy = 1,
                Name = "Employer Comments"
            },
            new Project()
            {
                AppId = 1,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                Description = "Add Non-construction overpayment report",
                Id = 2,
                Lead = new Guid(),
                ModifiedAt = DateTime.Now,
                ModifiedBy = 1,
                Name = "Overpayment Report"
            },
            new Project()
            {
                AppId = 2,
                CreatedAt = DateTime.Now,
                CreatedBy = 1,
                Description = "Add WCF service for importing Global Benefits data",
                Id = 3,
                Lead = new Guid(),
                ModifiedAt = DateTime.Now,
                ModifiedBy = 1,
                Name = "Global Benefits Data Feed"
            }

        };

        public Project Add(Project entity)
        {
            entity.Id = projects.Count + 1;
            projects.Add(entity);
            return entity;
        }

        public void AddRange(IEnumerable<Project> entities)
        {
            foreach(var p in entities)
            {
                p.Id = projects.Count + 1;
                projects.Add(p);
            }
        }

        public IEnumerable<Project> Find(System.Linq.Expressions.Expression<Func<Project, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Project Get(int id)
        {
            return projects.Where(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<Project> GetAll()
        {
            return projects;
        }

        public void Remove(Project entity)
        {
            projects.Remove(entity);
        }

        public void RemoveRange(IEnumerable<Project> entities)
        {
            foreach(var p in entities)
            {
                projects.Remove(p);
            }
        }
    }
}
