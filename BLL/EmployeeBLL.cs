using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;
using DAL.DTO;

namespace BLL
{
    public class EmployeeBLL
    {
        public static EmployeeDTO GetAll()
        {
            EmployeeDTO dto = new EmployeeDTO();
            dto.Deparments = DepartmentDAO.GetDepartments();
            dto.Positions = PositionDAO.GetPosition();

            return dto;
        }

        public static void AddEmployee(Employee employee)
        {
            EmployeeDAO.AddEmployee(employee);
        }

        public static bool isUnique(int v)
        {
            List<Employee> list = EmployeeDAO.GetUsers(v);
            if (list.Count > 0) return false;
            return true;
        }
    }
}
