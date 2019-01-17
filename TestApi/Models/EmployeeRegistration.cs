using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApi.Models
{
    public class EmployeeRegistration
    {
        List<Employee> employeeList;
        static EmployeeRegistration employeeRegd = null;
        private EmployeeRegistration()
        {
            employeeList = new List<Employee>();
        }
        public static EmployeeRegistration getInstance()
        {
            if (employeeRegd == null)
            {
                employeeRegd = new EmployeeRegistration();
                return employeeRegd;
            }
            else
            {
                return employeeRegd;
            }
        }
        public void Add(Employee employee)
        {
            employeeList.Add(employee);
        }
        public String Remove(String EmployeeID)
        {
            for (int i = 0; i < employeeList.Count; i++)
            {
                Employee emp = employeeList.ElementAt(i);
                if (emp.ID.Equals(emp.ID))
                {
                    employeeList.RemoveAt(i);//update the new record
                    return "Delete successful";
                }
            }
            return "Delete un-successful";
        }
        public List<Employee> getAllEmployee()
        {
            return employeeList;
        }
        public String UpdateEmployee(Employee emp)
        {
            for (int i = 0; i < employeeList.Count; i++)
            {
                Employee empl = employeeList.ElementAt(i);
                if (empl.ID.Equals(emp.ID))
                {
                    employeeList[i] = emp;//update the new record
                    return "Update successful";
                }
            }
            return "Update un-successful";
        }
    }
}