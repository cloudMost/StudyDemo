using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StudyDemo
{
    public class dapperUtil
    {
        //字段
        private static string connectionString;

        //属性
        public static string ConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["conString"].ToString();
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
            using (IDbConnection con =new SqlConnection(ConnectionString))
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
            using (IDbConnection con = new SqlConnection(ConnectionString))
            {
                return con.Execute(commandModel.sql, commandModel.model, null, null, CommandType.Text);
            }
        }

        /// <summary>
        /// 批量删除
        /// </summary>
        public static void Delete<TEntity>(List<Command<TEntity>> commandList)  where TEntity:class
        {
            using (IDbConnection con = new SqlConnection(ConnectionString))
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
        /// <summary>
        /// 查询数据列表
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="sql"></param>
        /// <param name="model"></param>
        /// <returns></returns>
        public static IEnumerable<TEntity> Query<TEntity>(string sql,object model=null) where TEntity:class
        {
            using (IDbConnection con=new SqlConnection(ConnectionString))
            {

                return con.Query<TEntity>(sql,model);
            }
        }
        /// <summary>
        /// Count函数
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static int Count(string sql)
        {
            using (IDbConnection con=new SqlConnection(ConnectionString))
            {
                return Common.HConvert.ToInt(con.ExecuteScalar(sql).ToString());
            }
        }

        //public static IEnumerable<Tentity> Query<Tentity>(Command<Tentity> commandList) where Tentity:class
        //{
        //    using (IDbConnection con = GetConnection(ConnectionString))
        //    {

        //    }
        //}

    }
}
