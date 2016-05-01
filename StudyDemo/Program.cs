using System;
using System.Net;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Configuration;
using System.Data;
using Dapper;
using System.Data.SqlClient;
using System.Xml;


namespace StudyDemo
{
    using Entity;
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //string sql = @"select * from (select *,ROW_NUMBER() over (order by ORANGIZECODE) as rn from Autofac.Orangize) t where rn between 10 and 18";
        //    //List<Orangize> list = new List<Orangize>();
        //    //using(IDbConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString()))
        //    //{
        //    //    list=con.Query<Orangize>(sql).ToList();
        //    //}
        //    //list.ForEach(item=> {
        //    //    Console.WriteLine(item.OrangizeCode);
        //    //});

        //    //string sql = "insert into Autofac.Orangize(ORANGIZECODE,ORANGIZENAME) values(@ORANGIZECODE,@ORANGIZENAME)";
        //    //Orangize o = new Orangize()
        //    //{
        //    //    OrangizeCode = Guid.NewGuid().ToString(),
        //    //    OrangizeName = "sd"
        //    //};
        //    //dapperUtil.AddOrUpdate<Orangize>(sql, o);
        //    //var list=dapperUtil.Query<Orangize>("select * from Autofac.Orangize").ToList();
        //    //Console.WriteLine(JsonConvert.SerializeObject(list));
        //    //Console.Write(dapperUtil.ConnectionString);
        //    //List<Users> userList = new List<Users>();
        //    //using (IDbConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ToString()))
        //    //{
        //    //    string sql = @"select * from Users u inner join user_role ur
        //    //                  on u.userid=ur.user_id
        //    //                  inner join Role r
        //    //                  on r.roleid=ur.role_id";
        //    //    var loopUp = new Dictionary<int, Users>();
        //    //    con.Query<Users, Role, Users>(sql, (user, role) =>
        //    //    {
        //    //        Users u;
        //    //        if (!loopUp.TryGetValue(user.UserID, out u))
        //    //        {
        //    //            loopUp.Add(user.UserID, u = user);
        //    //        }
        //    //        u.Roles.Add(role);
        //    //        return user;

        //    //    }, null, null, true, "roleid", null, null);
        //    //}
        //    //List<Users> list = new List<Users>();
        //    //using (IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
        //    //{
        //    //    DynamicParameters parameters = new DynamicParameters();
        //    //    parameters.Add("@page",1,DbType.Int32,ParameterDirection.Input);
        //    //    parameters.Add("@rows", 10, DbType.Int32, ParameterDirection.Input);
        //    //    parameters.Add("@count", null, DbType.Int32, ParameterDirection.Output);

        //    //    list =conn.Query<Users>("GetUsers",parameters,null,true,null,CommandType.StoredProcedure).ToList();

        //    //    int count=parameters.Get<int>("@count");
        //    //    Console.WriteLine(count);

        //    //}

        //    //if (list.Count > 0)
        //    //{
        //    //    list.ForEach(u =>
        //    //    {
        //    //        Console.WriteLine(u.UserName);
        //    //    });
        //    //}

//        using (IDbConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conString"].ConnectionString))
//        {
//            DynamicParameters parameters = new DynamicParameters();
//    parameters.Add("@userName","小红",DbType.String,ParameterDirection.Input);
//            parameters.Add("@userPassword", "123456", DbType.String, ParameterDirection.Input);
//            parameters.Add("@userNickName", "xiaohong", DbType.String, ParameterDirection.Input);
//            parameters.Add("@id",null,DbType.Int32,ParameterDirection.Output);
//            int result = conn.Execute("InsertUser", parameters, null, null, CommandType.StoredProcedure);

//    int id = parameters.Get<int>("@id");
//    Console.WriteLine(id);
//            Users user = conn.Query<Users>("select * from Autofac.users where userid=@userid",
//                new { @userid = id }, null, true, null, CommandType.Text).FirstOrDefault();
//    Console.WriteLine("用户id:"+user.UserID+"--用户名称:"+user.UserName+"--用户密码:"+user.UserPassword);
//        }
//Console.ReadKey();

        //}
    }
}
