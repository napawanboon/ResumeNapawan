using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume_Napawan.Models
{
    public class ProjectNapawanContext
    {

        public class Resume_NapawanContext
        {
            public string ConnectionString { get; set; }

            public Resume_NapawanContext(string connectionString)
            {
                this.ConnectionString = connectionString;
            }

            private MySqlConnection GetConnection()
            {
                return new MySqlConnection(ConnectionString);
            }
        }

        public List<Project> GetAllAlbums()
        {
            List<Project> list = new List<Project>();

            //using (MySqlConnection conn = GetConnection())
            //{
            //    conn.Open();
            //    MySqlCommand cmd = new MySqlCommand("select * from Project where ID < 10", conn);

            //    using (var reader = cmd.ExecuteReader())
            //    {
            //        while (reader.Read())
            //        {
            //            list.Add(new Project()
            //            {
            //                ID = Convert.ToInt32(reader["Id"]),
            //                NameProject = reader["Name"].ToString(),
            //                Details = reader["ArtistName"].ToString(),
            //                DateCreated = Convert.ToDateTime(reader["DateCreated"]),
            //                DateUpdate = Convert.ToDateTime(reader["DateUpdate"])
            //            });
            //        }
            //    }
            //}
            return list;
        }
    }
}
