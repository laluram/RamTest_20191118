using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {      
        public List<Employee> GetEmployeeData()
        {
            List<Employee> lstEmployees = new List<Employee>() { 
            
                            new Employee {EmployeeID=1,FirstName="John",LastName="Cary",Age=23},
                            new Employee {EmployeeID=2,FirstName="Black",LastName="Smith",Age=25},
                            new Employee {EmployeeID=3,FirstName="Mike",LastName="Charles",Age=33}
            };

            return lstEmployees;
        }
    }
}
