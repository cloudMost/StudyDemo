using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataProvider
{
    public class dapperUtil
    {
        //字段
        private static string connectionString;

        //属性
        private static SqlConnection Con { get; set; }
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["conString"].ToString(); ;
            }
           private set
            {
                 connectionString = value;
            }
        }
        /// <summary>
        /// 新增或更新
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="sql"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static int AddOrUpdate<TEntity>(string sql,TEntity model) where TEntity:class
        {
            using (IDbConnection con = GetConnection(ConnectionString))
            {
                 return con.Execute(sql,model,null,null,CommandType.Text);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="commandModel"></param>
        /// <returns></returns>
        public static int AddOrUpdate<TEntity>(Command<TEntity> commandModel) where TEntity:class
        {
            using (IDbConnection con = GetConnection(ConnectionString))
            {
                return con.Execute(commandModel.sql, commandModel.model, null, null, CommandType.Text);
            }
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        public static void Delete<TEntity>(List<Command<TEntity>> commandList)  where TEntity:class
        {
            using (IDbConnection con = GetConnection(ConnectionString))
            {
                IDbTransaction tans = con.BeginTransaction();
                try
                {
                    foreach (var item in commandList)
                    {
                        con.Execute(item.sql, item.model,tans);
                    }
                }
                catch (Exception ex)
                {
                    tans.Rollback();
                    throw new Exception(ex.Message);
                }
            }
        }


        public static IEnumerable<TEntity> Query<TEntity>(string sql,TEntity model=null) where TEntity:class
        {
            using (IDbConnection con=GetConnection(ConnectionString))
            {
                return con.Query<TEntity>(sql,model);
            }
        }

        //public static IEnumerable<Tentity> Query<Tentity>(Command<Tentity> commandList) where Tentity:class
        //{
        //    using (IDbConnection con = GetConnection(ConnectionString))
        //    {

        //    }
        //}
        public static SqlConnection GetConnection(string connectionString)
        {
            return new SqlConnection(connectionString);
        }
    }
}
