using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;

namespace DAL.DAO
{
    public class EmployeeDAO : EmployeeContext
    {
        public static void AddEmployee(Employee employee)
        {
            try
            {
                db.Employees.InsertOnSubmit(employee);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public static List<Employee> GetUsers(int v)
        {
            return db.Employees.Where(x => x.UserNo == v).ToList();
        }

        public static List<EmployeeDetailDTO> GetEmployees()
        {
            List<EmployeeDetailDTO> employeeList = new List<EmployeeDetailDTO>();
            var list = (from e in db.Employees
                join d in db.DEPARMENTs on e.DepartmentID equals d.ID
                join p in db.Positions on e.PositionID equals
                    p.ID
                select new
                {
                    UserNo = e.UserNo,
                    Name = e.Name,
                    Surname = e.Surname,
                    EmployeeID = e.ID,
                    Password = e.Password,
                    DeparmentName = d.DepartmentName,
                    PositionName = p.PositionName,
                    DepartmentID = e.DepartmentID,
                    PositionID = e.PositionID,
                    isAdmin = e.isAdmin,
                    Salary = e.Salary,
                    ImagePath = e.ImagePath,
                    BirthDay = e.BirthDay,
                    Address = e.Adress

                }).OrderBy(x => x.UserNo).ToList();

            foreach (var item in list)
            {
                var dto = new EmployeeDetailDTO
                {
                    Name = item.Name,
                    UserNo = item.UserNo,
                    Surname = item.Surname,
                    EmployeeID = item.EmployeeID,
                    Password = item.Password,
                    DeparmentID = item.DepartmentID,
                    DeparmentName = item.DeparmentName,
                    PositionID = item.PositionID,
                    PositionName = item.PositionName,
                    isAdmin = item.isAdmin,
                    Salary = item.Salary,
                    Birthdate = item.BirthDay,
                    Address = item.Address,
                };
                employeeList.Add(dto);
            }
            return employeeList;

        }
    }
}
