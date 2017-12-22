using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace CARDAL
{
  public  class CarListServer
    {

      public static DataTable GetListInfo(int Top )
      {
          #region 显示热门车型
          string sql = "SELECT TOP " + Top + "* FROM [CarBase].[dbo].[CAR_INFO] ORDER BY CREATE_TIME DESC";
          return DbHelp.GetDataTable(sql);
          #endregion
      }

      public static SqlDataReader CheckLogin(string ID, string PSW)
      {
         #region  后台管理Check 用户登录密码，用户名
          string sql = "SELECT * FROM [CarBase].[dbo].[USER_INFO]  WHERE USER_ID='" + ID + "'AND USER_PSW='" + PSW + "'";

          return DbHelp.GetReader(sql);
        #endregion
      }

    }
}
