using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public class EmployeeMaster
    {   
        public long Id { get; set; }
        public string EmployeeNumber { get; set; }
        public string EmployeeFullName { get; set; }   
        public string EmployeeNameWithInitial { get; set; }
        public DateTime EmployeeDOB { get; set; }
        public EmpContact EmployeeContact { get; set; }
        public string EmployeeImage
        {

            get
            {
                return EmployeeFullName.Replace(" ", "").ToLower()+ EmployeeNumber+".jpg";
            }
                
        }

    }
}