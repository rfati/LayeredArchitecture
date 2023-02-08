using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLAyer
{
    public class DALEmployee
    {
        public static List<EntityEmployee> EmployeeList()
        {
            List<EntityEmployee> values = new List<EntityEmployee>();
            SqlCommand command1 = new SqlCommand("select * from TblEmployee", Connection.c);
            if (command1.Connection.State != ConnectionState.Open)
            {
                Connection.c.Open();
            }

            SqlDataReader dr = command1.ExecuteReader();

            while (dr.Read())
            {
                EntityEmployee ent = new EntityEmployee();

                ent.Id = Convert.ToInt32(dr["ID"].ToString());
                ent.Name = dr["NAME"].ToString();
                ent.Surname = dr["SURNAME"].ToString();
                ent.City = dr["CITY"].ToString();
                ent.Duty = dr["DUTY"].ToString();
                ent.Salary = (short)Convert.ToInt32(dr["SALARY"].ToString());
                values.Add(ent);
            }
            dr.Close();
            return values;
        }

        public static int AddEmployee(EntityEmployee emp)
        {
            SqlCommand command2 = new SqlCommand("insert into TblEmployee (NAME, SURNAME, CITY, DUTY, SALARY) values (@p1, @p2, @p3, @p4, @p5)", Connection.c);
            if (command2.Connection.State != ConnectionState.Open)
            {
                command2.Connection.Open();
            }

            command2.Parameters.AddWithValue("p1", emp.Name);
            command2.Parameters.AddWithValue("p2", emp.Surname);
            command2.Parameters.AddWithValue("p3", emp.City);
            command2.Parameters.AddWithValue("p4", emp.Duty);
            command2.Parameters.AddWithValue("p5", emp.Salary);

            return command2.ExecuteNonQuery();
        }

        public static bool DeleteEmployee(int id)
        {
            SqlCommand command3 = new SqlCommand("delete from TblEmployee where ID = @P1", Connection.c);
            if (command3.Connection.State != ConnectionState.Open)
            {
                command3.Connection.Open();
            }
            command3.Parameters.AddWithValue("@P1", id);
            return command3.ExecuteNonQuery() > 0;
        }

        public static bool UpdateEmployee(EntityEmployee emp)
        {
            SqlCommand command4 = new SqlCommand("UPDATE TblEmployee SET NAME = @p1, SURNAME = @p2, CITY = @p3, DUTY = @p4, SALARY = @p5 where ID = @p6", Connection.c);
            if (command4.Connection.State != ConnectionState.Open)
            {
                command4.Connection.Open();
            }
            command4.Parameters.AddWithValue("p1", emp.Name);
            command4.Parameters.AddWithValue("p2", emp.Surname);
            command4.Parameters.AddWithValue("p3", emp.City);
            command4.Parameters.AddWithValue("p4", emp.Duty);
            command4.Parameters.AddWithValue("p5", emp.Salary);
            command4.Parameters.AddWithValue("p6", emp.Id);
            
            return command4.ExecuteNonQuery() > 0;
        }

    }
}
