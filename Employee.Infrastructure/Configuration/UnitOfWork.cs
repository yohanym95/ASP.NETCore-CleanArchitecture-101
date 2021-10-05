using Employee.Core.Configuration;
using Employee.Core.Repositories;
using Employee.Infrastructure.Data;
using Employee.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Infrastructure.Configuration
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmployeeContext _employeeContext;
        public IEmployeeRepository Employees { get; private set; }


        public UnitOfWork(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;

            Employees = new EmployeeRepository(_employeeContext);

        }
    }
}
