using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    class TaskDetailDTO
    {
        public int EmployeeID { get; set; }
        public int UserNo { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DeparmentName { get; set; }
        public string PositionName { get; set; }
        public int DeparmentID { get; set; }
        public int PositionID { get; set; }
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string TaskStatement { get; set; }
        public DateTime TaskStartDate { get; set; }
        public DateTime TaskDeliveryDate { get; set; }
        
    }
}
