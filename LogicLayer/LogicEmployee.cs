using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLAyer;
using EntityLayer;

namespace LogicLayer
{
    class LogicEmployee
    {
        public List<EntityEmployee> LLEmployeeList()
        {
            return DALEmployee.EmployeeList();
        }

    }
}
