using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLAyer
{
    public class Connection
    {
        public static SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-PJIG1NN;
                                                            Initial Catalog=DbEmployee;Integrated Security=True");
    }
}
