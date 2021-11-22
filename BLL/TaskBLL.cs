using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DAO;
using DAL.DTO;

namespace BLL
{
    public class TaskBLL
    {
        public static TaskDTO GetAll()
        {
            TaskDTO taskdto = new TaskDTO();
            taskdto.Employee = EmployeeDAO.GetEmployees();
            taskdto.Deparments = DepartmentDAO.GetDepartments();
            taskdto.Position = PositionDAO.GetPosition();
            taskdto.TaskStates = TaskDAO.GettaskStates();

            return taskdto;
        }
    }
}
