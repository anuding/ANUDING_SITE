using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ANUDING_SITE.Models
{
    public class BlogContext
    {
        public string ConnectionString { get; set; }
        public BlogContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }


        public List<Blog> GetAllBlog()
        {
            List<Blog> list = new List<Blog>();
            //连接数据库
            using (MySqlConnection msconnection = GetConnection())
            {
                msconnection.Open();
                //查找数据库里面的表
                MySqlCommand mscommand = new MySqlCommand("select * from tab_articles", msconnection);
                using (MySqlDataReader reader = mscommand.ExecuteReader())
                {
                    //读取数据
                    while (reader.Read())
                    {
                        list.Add(new Blog()
                        {
                            idtab_articles = reader.GetString("idtab_articles"),
                            title = reader.GetString("title"),
                            navimg = "dkwidj",
                            content = reader.GetString("content"),
                            tags = reader.GetString("tags"),
                            dateCreated = reader.GetString("dateCreated")
                        });
                    }
                }
            }
            return list;
        }


        public List<Blog> GetThatBlog(string id)
        {
            List<Blog> list = new List<Blog>();
            //连接数据库
            using (MySqlConnection msconnection = GetConnection())
            {
                msconnection.Open();
                //查找数据库里面的表
                MySqlCommand mscommand = new MySqlCommand("select * from tab_articles", msconnection);
                using (MySqlDataReader reader = mscommand.ExecuteReader())
                {
                    //读取数据
                    while (reader.Read())
                    {
                        if (reader.GetString("idtab_articles") == id)
                        {
                            list.Add(new Blog()
                            {
                                idtab_articles = reader.GetString("idtab_articles"),
                                title = reader.GetString("title"),
                                navimg = "dkwidj",
                                content = reader.GetString("content"),
                                tags = reader.GetString("tags"),
                                dateCreated = reader.GetString("dateCreated")
                            });
                            break;
                        }
                       
                    }
                }
            }
            return list;
        }
    }
}
