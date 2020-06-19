using SqlSugar;
using System.Diagnostics;

namespace EMRS.Repositories
{
    /// <summary>
    /// 数据库工厂
    /// </summary>
    public class DbFactory
    {
        /// <summary>
        /// SqlSugarClient属性
        /// </summary>
        /// <returns></returns>
        public static SqlSugarClient GetSqlSugarClient()
        {
            var db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = Config.ConnectionString, //必填
                DbType = DbType.Oracle, //必填
                IsAutoCloseConnection = true, //默认false
                InitKeyType = InitKeyType.Attribute
            }); //默认SystemTable

            db.Aop.OnLogExecuted = (sql, pars) => //SQL执行完事件
            {
                Debug.WriteLine(sql);
            };
            db.Aop.OnError = (exp) =>//执行SQL 错误事件
            {
                //exp.sql exp.parameters 可以拿到参数和错误Sql
                string sql = exp.Sql;
                Debug.WriteLine(sql);
            };
            return db;
        }
    }
}
