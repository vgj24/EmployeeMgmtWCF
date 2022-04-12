using Common_Layer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Interfaces
{
   public  interface IEmpBL 
    {
        string AddEmployee(EmployeeContract employeeContract);
        string UpdateEmployee(EmployeeContract employeeContract, int empid);
        EmployeeContract GetByID(int empid);
        IList<EmployeeContract> GetAllEmployees();
        string DeleteEmployee(int empid);
    }
}
