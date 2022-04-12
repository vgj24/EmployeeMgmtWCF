using Business_Layer.Interfaces;
using Business_Layer.Services;
using Common_Layer.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeMgmtApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmployeeService.svc or EmployeeService.svc.cs at the Solution Explorer and start debugging.
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmpBL empBL;

        public EmployeeService()
        {
            empBL = new EmpBL();
        }
        public string AddEmployee(EmployeeContract employeeContract)
        {
            try
            { 
                return empBL.AddEmployee(employeeContract);
            }
            catch(Exception e)
            {
                return e.Message;
            }
        }
        public string UpdateEmployee(EmployeeContract employeeContract, string id)
        {
            int empid = Convert.ToInt32(id);
            return empBL.UpdateEmployee(employeeContract, empid);
        }
        public EmployeeContract GetByID(string id)
        {
            int empid = Convert.ToInt32(id);
            return empBL.GetByID(empid);
        }
        public IList<EmployeeContract> GetAllEmployees()
        {
            return empBL.GetAllEmployees();
        }
        public string DeleteEmployee(string id)
        {
            int empid = Convert.ToInt32(id);
            return empBL.DeleteEmployee(empid);
        }

      
    }
}
