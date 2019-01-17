using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestApi.Models;

namespace TestApi.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        public List<Employee> GetAllEmployee()
        {
            return EmployeeRegistration.getInstance().getAllEmployee();
        }

        [HttpPost]
        public EmployeeRegistrationReply registerEmployee(Employee empregd)
        {
            Console.WriteLine("In registerEmployee");
            EmployeeRegistrationReply empregreply = new EmployeeRegistrationReply();
            EmployeeRegistration.getInstance().Add(empregd);
            empregreply.Name = empregd.Name;
            empregreply.Age = empregd.Age;
            empregreply.ID = empregd.ID;
            empregreply.registrationStatus = "Successful";
            return empregreply;
        }

        [HttpPut]
        public String PutEmployeeRecord(Employee emp)
        {
            Console.WriteLine("In updateEmployeeRecord");
            return EmployeeRegistration.getInstance().UpdateEmployee(emp);
        }

        [HttpDelete]
        public String DeleteEmployeeRecord(String empID)
        {
            Console.WriteLine("In deleteEmployeeRecord");
            return EmployeeRegistration.getInstance().Remove(empID);
        }
    }
}