using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    class EmployeeDetailDTO
    {
        public int EmployeeID { get; set; }
        public int UserNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string DeparmentName { get; set; }
        public string PositionName { get; set; }
        public int DeparmentID { get; set; }
        public int PositionID { get; set; }
        public int Salary { get; set; }
        public bool isAdmin { get; set; }
        public string ImagePath { get; set; }
        public string Address { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
