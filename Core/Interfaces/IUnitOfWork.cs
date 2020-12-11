using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IProjectRepository Projects { get; }
        IWorkTaskRepository WorkTasks { get; }
        ICustomerRepository Customers { get; }
        IAppRepository Apps { get; }
        IUserRepository Users { get; }
        ITimeLogRepository TimeLogs { get; }
        int Update();


    }
}
