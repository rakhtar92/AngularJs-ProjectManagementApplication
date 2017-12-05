using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectTrackingAPI.Models
{
    public class EmployeeRepository
    {
        private static ProjectTrackingDBEntities dataContext = new ProjectTrackingDBEntities ( );

        public static List<Employee> GetAllEmployee( )
        {
            var query = from employee in dataContext.Employees select employee;
            return query.ToList ( );
        }

        public static List<Employee> SearchEmployeesByName(string employeeName)
        {
            var query = from employee in dataContext.Employees where employee.EmployeeName.Contains ( employeeName ) select employee;
            return query.ToList ( );
        }

        public static Employee GetEmployee(int EmployeeID)
        {
            var query = from employee in dataContext.Employees where employee.EmployeeID == EmployeeID select employee;
            return query.SingleOrDefault ( );
        }

        public static List<Employee> InsertEmployee(Employee e)
        {
            dataContext.Employees.Add ( e );
            dataContext.SaveChanges ( );
            return GetAllEmployee ( );
        }

        public static List<Employee> UpdateEmployees(Employee e)
        {
            var emp = (from employee in dataContext.Employees where employee.EmployeeID == e.EmployeeID select employee).SingleOrDefault ( );
            emp.EmployeeName = e.EmployeeName;
            emp.Designation = e.Designation;
            emp.ContactNO = e.ContactNO;
            emp.EmailID = e.EmailID;
            emp.SkillSets = e.SkillSets;
            dataContext.SaveChanges ( );
            return GetAllEmployee ( );
        }

        public static List<Employee> DeleteEmployee(Employee e)
        {
            var emp = (from employee in dataContext.Employees where employee.EmployeeID == e.EmployeeID select employee).SingleOrDefault ( );
            dataContext.Employees.Remove ( emp );
            dataContext.SaveChanges ( );
            return GetAllEmployee ( );
        }

    }
}