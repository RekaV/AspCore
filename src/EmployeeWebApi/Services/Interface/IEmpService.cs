using EmployeeWebApi.Models;
using System;

namespace EmployeeWebApi.Services.Interface
{
    public interface IEmpService : IEntityService<EmployeeMasters>
    {
        EmployeeMasters GetById(int Id);
        Boolean DeleteEmployee(int Id);
    }
}
