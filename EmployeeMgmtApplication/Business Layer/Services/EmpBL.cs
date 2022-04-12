using Business_Layer.Interfaces;
using Common_Layer.Contracts;
using Repository_Layer.Interfaces;
using Repository_Layer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer.Services
{
    public class EmpBL :IEmpBL
    {
       private readonly IEmpRL empRL;
        public EmpBL()
        {
            empRL = new EmpRL();
        }
        public string AddEmployee(EmployeeContract employeeContract)
        {
            if (empRL.AddEmployee(employeeContract) == 1)
            {
                return "Employee Added Successfully";
            }
            else
            {
                return "Employee not added";
            }
        }
        public string UpdateEmployee(EmployeeContract employeeContract, int empid)
        {
            if (empRL.UpdateEmployee(employeeContract,empid) == 1)
            {
                return "employee details updated succesfully";
            }
            else
            {
                return "Employee details not  updated";
            }
        }
        public EmployeeContract GetByID(int empid)
        {
            EmployeeContract employeeContract = empRL.GetByID(empid);
            if(employeeContract != null)
            {
                return employeeContract;
            }
            else
            {
                return new EmployeeContract();
            }
        }
        public IList<EmployeeContract> GetAllEmployees()
        {
           IList<EmployeeContract> employeeContractList = empRL.GetAllEmployees();
            if (employeeContractList != null)
            {
                return employeeContractList;
            }
            else
            {
                return new List<EmployeeContract>();
            }
        }
        public string DeleteEmployee(int empid)
        {
           
            if (empRL.DeleteEmployee(empid) == 1)
            {
                return "Employee Deleted Sucessfully";
            }
            else
            {
                return "Employee Does Not Exists";
            }

        }

    }
}
