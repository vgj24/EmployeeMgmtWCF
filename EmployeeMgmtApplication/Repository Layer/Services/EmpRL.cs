using Common_Layer.Contracts;
using Repository_Layer.Interfaces;
using Repository_Layer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository_Layer.Services
{
    public class EmpRL :IEmpRL
    {
        EmployeePayrollWCFEntities employeePayrollWCFEntitiesObj;
        public EmpRL()
        {
            employeePayrollWCFEntitiesObj = new EmployeePayrollWCFEntities();
        }
        public int AddEmployee(EmployeeContract employeeContract)
        {
            EmployeeData employeeData = new EmployeeData()  //EmployeeData.cs class object 
            {
                Name = employeeContract.Name,
                Salary = employeeContract.Salary,
                Email = employeeContract.Email
            };
            employeePayrollWCFEntitiesObj.EmployeeDatas.Add(employeeData);
            return employeePayrollWCFEntitiesObj.SaveChanges();
        }

        public int UpdateEmployee(EmployeeContract employeeContract, int empid)
        {
            EmployeeData employeeData = employeePayrollWCFEntitiesObj.EmployeeDatas.Find(empid);
            if(employeeData != null)
            {
                employeeData.Name = employeeContract.Name;
                 employeeData.Salary = employeeContract.Salary;
                 employeeData.Email = employeeContract.Email;
                return employeePayrollWCFEntitiesObj.SaveChanges();
            }
            else
            {
                throw new Exception("Employee do not exists!!");
            }
        }

        public EmployeeContract GetByID(int empid)
        {
            var emp = employeePayrollWCFEntitiesObj.EmployeeDatas.Find(empid);
            EmployeeContract employeeContract = new EmployeeContract()
            {
                Name = emp.Name,
                Salary = emp.Salary,
                Email = emp.Email,
                Id = emp.Id
            };
            return employeeContract;
        }

        public IList<EmployeeContract> GetAllEmployees()
        {
            var query = (from a in employeePayrollWCFEntitiesObj.EmployeeDatas select a).Distinct();
            List<EmployeeContract> employeeList = new List<EmployeeContract>();

            query.ToList().ForEach(x =>
            {
                employeeList.Add(new EmployeeContract
                {
                    Id = x.Id,
                    Name = x.Name,
                    Salary = x.Salary,
                    Email = x.Email
                }); 
            });
            return employeeList;
        }
        public int DeleteEmployee(int empid)
        {
            var emp = (from a in employeePayrollWCFEntitiesObj.EmployeeDatas where a.Id == empid select a).FirstOrDefault();
            if(emp != null)
            {
                employeePayrollWCFEntitiesObj.EmployeeDatas.Remove(emp);
                return employeePayrollWCFEntitiesObj.SaveChanges();
            }
            else
            {
                return 0;
            }
        }
    }

}

