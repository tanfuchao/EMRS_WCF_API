using System.Configuration;

namespace EMRS.Repositories
{
    /// <summary>
    /// 静态配置类
    /// </summary>
    public static class Config
    {
        /// <summary>
        /// 数据库连接字符串(公有属性)
        /// </summary>
        public static string ConnectionString { get; } = ConfigurationManager.ConnectionStrings["EMRSDB"].ConnectionString;
    }
}
