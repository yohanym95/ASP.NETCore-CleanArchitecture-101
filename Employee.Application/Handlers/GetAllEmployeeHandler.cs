using Employee.Application.Queries;
using Employee.Application.Responses;
using Employee.Core.Configuration;
using Employee.Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Employee.Application.Handlers
{
    public class GetAllEmployeeHandler : IRequestHandler<GetAllEmployeeQuery, IEnumerable<Employee.Core.Entities.Employee>>
    {
        private readonly IUnitOfWork _unitOfWork;
        public GetAllEmployeeHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public  async Task<IEnumerable<Employee.Core.Entities.Employee>> Handle(GetAllEmployeeQuery request, CancellationToken cancellationToken)
        {
            var employess = await _unitOfWork.Employees.GetAllAsync();

            return employess;
        }
    }
}
