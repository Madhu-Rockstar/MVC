using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace MadhuMVC.Models
{
    public class Database
    {
        static string sqlcon = @"Data Source=RILPT189;Initial Catalog=mvc;User ID=sa;Password=sa123";
        public List<custumer> getallcust()
        {
            var list = new List<custumer>();
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                try
                {
                    con.Open();
                    SqlCommand select = con.CreateCommand();
                    select.CommandText = "select * from custumer";
                    var reader = select.ExecuteReader();
                    while (reader.Read())
                    {
                        var cust = new custumer();
                        cust.id = Convert.ToInt32(reader[0]);
                        cust.cname = reader[1].ToString();
                        cust.pname = reader[2].ToString();
                        cust.caddress = reader[3].ToString();
                        list.Add(cust);
                        
                    }
                }
                catch(SqlException ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
            }
            return list;
        }
    }
}