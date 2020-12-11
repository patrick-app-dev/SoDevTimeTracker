using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DapperDAL
{
    public interface IDbConnectionFactory
    {
        IDbConnection GetConnection();
    }
}
