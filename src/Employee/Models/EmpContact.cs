using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public class EmpContact
    {
        public EmpAddress EmployeeAddress { get; set; }
        public Int32 EmployeeMobileNo { get; set; }
        public Int32 EmployeeHomeNo { get; set; }
        public string EmployeeEmail { get; set; }

    }
}