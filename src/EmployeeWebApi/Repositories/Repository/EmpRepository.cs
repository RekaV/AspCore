using EmployeeWebApi.Models;
using EmployeeWebApi.Repositories.Interface;
using System;
using System.Linq;

namespace EmployeeWebApi.Repositories.Repository
{
    public class EmpRepository : GenericRepository<EmployeeMasters>, IEmpRepository
    {
        public EmpRepository(EmployeeDbContext context)
           : base(context)
       {

       }

        public Boolean Delete(int id)
        {

            EmployeeMasters existing = _dbset.Where(x => x.EmpID == id).FirstOrDefault();
            _dbset.Remove(existing);
            Save();
            return true;

        }

        public EmployeeMasters GetById(int id)
        {
            return _dbset.Where(x => x.EmpID == id).FirstOrDefault();
        }
        


    }
}
