using Common_Layer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Layer.Interfaces
{
    public interface IEmpRL
    {
      int AddEmployee(EmployeeContract employeeContract);
      int UpdateEmployee(EmployeeContract employeeContract, int empid);
      EmployeeContract GetByID(int empid);
      IList<EmployeeContract> GetAllEmployees();
      int DeleteEmployee(int empid);
    }
}
