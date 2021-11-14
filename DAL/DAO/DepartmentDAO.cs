using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DAO
{
    public class DepartmentDAO : EmployeeContext
    {
        public static void AddDepartment(DEPARMENT department)
        {
            try
            {
                db.DEPARMENTs.InsertOnSubmit(department);
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
            
        }

        public static List<DEPARMENT> GetDepartments()
        {
            return db.DEPARMENTs.ToList();
        }
    }
}
