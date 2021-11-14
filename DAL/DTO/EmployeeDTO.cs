using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace DAL.DTO
{
    public class EmployeeDTO
    {
        public List<DEPARMENT> Deparments { get; set; }

        public List<PositionDTO> Positions { get; set; }
    }
}
