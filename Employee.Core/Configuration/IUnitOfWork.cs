using Employee.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Core.Configuration
{
    public interface IUnitOfWork
    {
        IEmployeeRepository Employees { get; }
    }
}
