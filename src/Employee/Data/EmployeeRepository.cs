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
                EmployeeNumber = "1",
                EmployeeName = "Saman Jayalath",
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
                EmployeeNumber = "2",
                EmployeeName = "Jehan mubarak",
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
    }
}