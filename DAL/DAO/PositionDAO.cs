using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DTO;

namespace DAL.DAO
{
    public class PositionDAO: EmployeeContext
    {
        public static void AddPosition(Position position)
        {
            try
            {
                db.Positions.InsertOnSubmit(position);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            
            
        }

        public static List<PositionDTO> GetPosition()
        {
            try
            {
                var list = (from p in db.Positions
                    join d in db.DEPARMENTs on p.DepartmentID equals d.ID
                    select new
                    {
                        positionID = p.ID,
                        positionName = p.PositionName,
                        departmentName = d.DepartmentName,
                        departmentID = d.ID

                    }).OrderBy(x => x.positionID).ToList();

                var positionList = new List<PositionDTO>();
                foreach (var item in list)
                {
                    PositionDTO dto = new PositionDTO();
                    dto.ID = item.positionID;
                    dto.PositionName = item.positionName;
                    dto.DepartmentName = item.departmentName;
                    dto.DepartmentID = item.departmentID;
                    positionList.Add(dto);
                }

                return positionList;
            }
            catch (Exception e)
            {
                
                throw e;
            }
        }
    }
}
