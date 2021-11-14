using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.DAO;
namespace BLL
{
    public class DepartmentBLL
    {
        public static void AddDepartment(DEPARMENT department)
        {
           DepartmentDAO.AddDepartment(department);
        }

        public static List<DEPARMENT> GetDepartment()
        {
            return DepartmentDAO.GetDepartments();
        }
    }
}
