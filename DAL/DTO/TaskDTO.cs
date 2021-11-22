using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class TaskDTO
    {
        public List<EmployeeDetailDTO> Employee { get; set; }
        public List<DEPARMENT> Deparments { get; set; }
        public List<PositionDTO> Position { get; set; }
        public List<TaskState> TaskStates { get; set; }
    }
}
