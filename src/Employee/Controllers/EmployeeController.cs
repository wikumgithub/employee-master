using Employee.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.Controllers
{
    public class EmployeeController:Controller
    {
        private EmployeeRepository _empRepository = null;

        public EmployeeController()
        {
            _empRepository = new EmployeeRepository();
        }

        public ActionResult Index()
        {
            var _emplist = _empRepository.GetEmployeeList();

            if (_emplist != null)
            {
                return View(_emplist);               
            }
            else
            {
                return HttpNotFound();
            }
        }

       
        public ActionResult EmployeeDetails(int? id)
        {

            var EmpRepository = _empRepository.GetEmployee(id.Value);

            if (EmpRepository != null)
            {
                return View(EmpRepository);
            }
            else
            {
                return HttpNotFound();
            }
        }
    }
}