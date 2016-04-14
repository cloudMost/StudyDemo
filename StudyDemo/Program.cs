using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;
using System.Data;
using Dapper;
using System.Data.SqlClient;

namespace StudyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id=1,Name="xxx"},
                new Student() { Id=2,Name="zzz" },
                new Student() { Id=3,Name="ccc" },
                new Student() { Id=4,Name="vvv" },
                new Student() { Id=5,Name="bbb" },
                new Student() { Id=6,Name="nnn" }
            };
            using (IDbConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString()))
            {
                Orangize o = new Orangize();
                o.OrangizeCode = "sdfadssssssf";
                string query = "insert into Autofac.Orangize(ORANGIZECODE) values(@OrangizeCode)";
                con.Execute(query,o);
            }

            using (IDbConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString()))
            {
                string query = "select * from Autofac.Orangize";
                var list=con.Query<Orangize>(query).ToList();
                Console.WriteLine(JsonConvert.SerializeObject(list));
            }
            Console.ReadKey();

        }
    }
}
