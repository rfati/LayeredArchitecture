using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDepartment
    {
        private int id;
        private string name;
        private string comment;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Comment { get => comment; set => comment = value; }
    }
}
