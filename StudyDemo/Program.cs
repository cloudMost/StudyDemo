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
            string sql = "insert into Autofac.Orangize(ORANGIZECODE) values(@ORANGIZECODE)";
            Orangize o = new Orangize()
            {
                OrangizeCode = Guid.NewGuid().ToString()
            };
            dapperUtil.AddOrUpdate<Orangize>(sql, o);

            var list=dapperUtil.Query<Orangize>("select * from Autofac.Orangize").ToList();
            Console.WriteLine(JsonConvert.SerializeObject(list));
            Console.Write(dapperUtil.ConnectionString);
            Console.ReadKey();

        }
    }
}
