using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public class EmployeeMaster
    {
        public string EmployeeNumber { get; set; }
        public string EmployeeName { get; set; }       
        public DateTime EmployeeDOB { get; set; }
        public EmpContact EmployeeContact { get; set; }
        public string EmployeeImage
        {

            get
            {
                return EmployeeName.Replace(" ", "").ToLower()+ EmployeeNumber+".jpg";
            }
                
        }

    }
}