using PYG.Common;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace PYG.DAO.Service.Base
{
    public class SqlHelper
    {
        public static SqlSugarClient Instance
        {
            get => new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = ConfigurationUtil.GetSection("ConnectionStrings:conn"), //Data Source=BAIJINSUODC51\\BAIJINSUO;Initial Catalog=test;Integrated Security=True
                DbType = DbType.SqlServer,         //必填, 数据库类型
                IsAutoCloseConnection = true       //默认false, 时候知道关闭数据库连接, 设置为true无需使用using或者Close操作
                                                   // InitKeyType = InitKeyType.SystemTable    //默认SystemTable, 字段信息读取, 如：该属性是不是主键，是不是标识列等等信息
            });
        }
    }
}
