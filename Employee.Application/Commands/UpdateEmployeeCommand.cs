using Employee.Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employee.Application.Commands
{
    public class UpdateEmployeeCommand : IRequest<EmployeeResponse>
    {
        public int EmployeeId
        {
            get; set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public DateTime DateOfBirth
        {
            get;
            set;
        }
        public string PhoneNumber
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
    }
}
