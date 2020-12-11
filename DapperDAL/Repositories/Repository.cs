using Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Dapper;
using Dapper.Contrib;
using System.Data;
using MySql.Data;
using System.Configuration;
using Dapper.Contrib.Extensions;

namespace DapperDAL.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private IDbConnection db; // = new MySql.Data.MySqlClient.MySqlConnection(ConfigurationManager.ConnectionStrings["Default"].ConnectionString);

        public Repository(IDbConnection connection)
        {
            db = connection;
        }
        public TEntity Add(TEntity entity)
        {
            var id = db.Insert(entity);
            return db.Get<TEntity>(id);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            db.Insert(entities);
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(int id)
        {
            return db.Get<TEntity>(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return db.GetAll<TEntity>();
        }

        public void Remove(TEntity entity)
        {
            db.Delete(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            db.Delete(entities);
        }
    }
}
