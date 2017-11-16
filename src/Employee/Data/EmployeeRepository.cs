using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employee.Models;


namespace Employee.Data
{
    public class EmployeeRepository
    {

        private static EmployeeMaster[] _employee = new EmployeeMaster[]
        {
            new EmployeeMaster()
            {   
                Id = 1,
                EmployeeNumber = "1",
                EmployeeFullName = "Saman Jayalath",
                EmployeeNameWithInitial="S.Jayalath",
                EmployeeDOB = new DateTime(2017,01,01),      
                              
                EmployeeContact = new EmpContact
                {
                    EmployeeAddress = new EmpAddress
                    {
                        Addressline1 = "emp1line1",
                        Addressline2 = "emp1line1",
                        Addressline3 = "emp1line2",
                        Country = "Sri lanka",
                        PostalCode = "2165"
                    },
                    EmployeeMobileNo = 044562555,
                    EmployeeHomeNo = 46532555,
                    EmployeeEmail = "saja@yahoo.com" 
                }
            },

             new EmployeeMaster()
            {
                Id = 2,
                EmployeeNumber = "2",
                EmployeeFullName = "Jehan mubarak",
                EmployeeNameWithInitial="J.mubarak",
                EmployeeDOB = new DateTime(2008,05,21),

                EmployeeContact = new EmpContact
                {
                    EmployeeAddress = new EmpAddress
                    {
                        Addressline1 = "emp2line1",
                        Addressline2 = "emp1line1",
                        Addressline3 = null,
                        Country = "Sri lanka",
                        PostalCode = null
                    },
                    EmployeeMobileNo = 0714567896,
                    EmployeeHomeNo = 01128975656,
                    EmployeeEmail = "jehan@gmail.com"
                }
            },
        };



        public EmployeeMaster GetEmployee(int Id)
        {
            EmployeeMaster employee = null;
            foreach (var emp in _employee)
            {
                if (emp.Id == Id)
                {
                    employee = emp;
                    break;
                }
            }
            return employee;
        }

        public EmployeeMaster[] GetEmployeeList()
        {
            return _employee;
        }
    }
}