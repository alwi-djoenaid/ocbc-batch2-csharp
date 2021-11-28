using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace webApiTest.Models
{
    public class EmployeeContext
    {
        public string ConnectionString { get; set; }

        public EmployeeContext(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }

        public List<EmployeeItem> GetAllEmployee()
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using(MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee", conn);

                using(MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            gender = reader.GetString("gender"),
                            address = reader.GetString("address"),
                        });
                    }
                }
            }
            return list;
        }

        public List<EmployeeItem> GetEmployee(string id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM employee WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            gender = reader.GetString("gender"),
                            address = reader.GetString("address"),
                        });
                    }
                }
            }
            return list;
        }

        public List<EmployeeItem> InsertEmployee(EmployeeItem employee)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(
                    "INSERT INTO employee (name, gender, address) VALUES " +
                    "(@name, @gender, @address)"
                    , conn);
                cmd.Parameters.AddWithValue("@name", employee.name);
                cmd.Parameters.AddWithValue("@gender", employee.gender);
                cmd.Parameters.AddWithValue("@address", employee.address);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem(){
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            gender = reader.GetString("gender"),
                            address = reader.GetString("address")
                        });
                    }
                }
                conn.Close();
            }

            return list;
        }

        public List<EmployeeItem> UpdateEmployee(int id, EmployeeItem employee)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE employee " +
                    "SET name=@name, " +
                    "gender=@gender, " +
                    "address=@address " +
                    "WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", employee.id);
                cmd.Parameters.AddWithValue("@name", employee.name);
                cmd.Parameters.AddWithValue("@gender", employee.gender);
                cmd.Parameters.AddWithValue("@address", employee.address);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new EmployeeItem()
                        {
                            id = reader.GetInt32("id"),
                            name = reader.GetString("name"),
                            gender = reader.GetString("gender"),
                            address = reader.GetString("address")
                        });
                    }
                }
                conn.Close();
            }

            return list;
        }

        public bool DeleteEmployee(int id)
        {
            List<EmployeeItem> list = new List<EmployeeItem>();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("DELETE FROM employee WHERE id=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    return true;

                } catch(Exception e)
                {
                    // Belom tau error handle nya mau gimana
                    return false;
                }
                
            }

            return false;
        }
    }
}
