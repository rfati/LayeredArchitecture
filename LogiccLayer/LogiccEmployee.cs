using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLAyer;
using EntityLayer;


namespace LogiccLayer
{
    public class LogiccEmployee
    {
        public static List<EntityEmployee> LLEmployeeList()
        {
            return DALEmployee.EmployeeList();
        }

        public static int LLAddEmployee(EntityEmployee emp)
        {
            if (emp.Name != "" && emp.Surname != "" && emp.City != "" && emp.Salary > 0)
            {
                return DataAccessLAyer.DALEmployee.AddEmployee(emp);
            }
            else
            {
                return -1;
            }
        }

        public static bool LLDeleteEmployee(int id)
        {
            if (id > 0)
            {
                return DataAccessLAyer.DALEmployee.DeleteEmployee(id);
            }
            else
            {
                return false;
            }
        }

        public static bool LLUpdateEmployee(EntityEmployee emp)
        {
            if (emp.Name != "" && emp.Surname != "" && emp.City != "" && emp.Salary > 0)
            {
                return DataAccessLAyer.DALEmployee.UpdateEmployee(emp);
            }
            else
            {
                return false;
            }
        }

    }
}


