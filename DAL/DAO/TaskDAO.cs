using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class TaskDAO : EmployeeContext
    {
        public static List<TaskState> GettaskStates()
        {
            return db.TaskStates.ToList();
        }
    }
}
