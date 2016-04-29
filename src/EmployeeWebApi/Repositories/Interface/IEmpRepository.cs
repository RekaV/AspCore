using EmployeeWebApi.Models;
using System;

namespace EmployeeWebApi.Repositories.Interface
{
    public interface IEmpRepository : IGenericRepository<EmployeeMasters>
    {
        EmployeeMasters GetById(int id);
        Boolean Delete(int id);
    }
}
