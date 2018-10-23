using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rcw.Model;
using Rcw.Data;
using System.Windows.Forms;

namespace RV.UI
{
    public class menuMag
    {

        public static void initSystem()
        {
            //Rcw.Data.DbContext.AddDataSource("CAP", DbContext.DbType.Oracle, "192.168.2.204", "orcl", "XGCAPTEST", "XGCAPTEST");
            //DbContext.DefaultDataSourceName = "CAP";

            DbContext.Create<TS_USER>();
            DbContext.Create<TS_ROLE>();
            DbContext.Create<TS_USER_ROLE>();
            DbContext.Create<TS_ROLE_FUN>();
            DbContext.Create<TS_Dept>();
            DbContext.Create<TS_MODULE>();
            TS_USER user = new TS_USER();
            user.C_NAME = "管理员";
            user.C_ACCOUNT = "system";
            user.C_PASSWORD = Common.MD5("123456");//密码
            user.N_TYPE = 3;//用户类型（1内部，2新用户,3PCI用户）
            user.N_STATUS = TS_USER.userStatus.正常;//状态(1正常，2，3，4冻结)
            user.C_EMP_ID = "";//系统操作人编号        
            user.C_DEPT = "1";
            user.C_LASTLOGINTIME = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            user.Save();

            var sysUser = TS_USER.GetModel("C_ACCOUNT=@C_ACCOUNT", "system");
            sysUser.C_EMP_ID = sysUser.C_ID;
            sysUser.Save();

            TS_MODULE modNew = new TS_MODULE();
            modNew.C_NAME = "系统管理";
            modNew.C_PARENT_ID = "0";
            modNew.C_ASSEMBLYNAME = "";
            modNew.C_MODULECLASS = "";
            modNew.C_DISABLE ="1" ;
            modNew.N_IMAGEINDEX = 1;
            //modNew.N_ORDER = menuMag.GetModuleMaxOrder(modNew.C_PARENT_ID) + 1;
            modNew.N_ORDER = 1;
            modNew.C_EMP_ID = sysUser.C_ID;          
            modNew.C_MODULE_TYPE = "2";
            modNew.C_QUERY_STR = "";
            modNew.Save();

            var sysModule = TS_MODULE.GetModel("main.C_NAME=@C_NAME", "系统管理");

            TS_MODULE modNew1 = new TS_MODULE();
            modNew1.C_NAME = "用户管理";
            modNew1.C_PARENT_ID = sysModule.C_ID;
            modNew1.C_ASSEMBLYNAME = "RV.UI.dll";
            modNew1.C_MODULECLASS = "RV.UI.FrmDeptUser";
            modNew1.C_DISABLE = "1";
            modNew1.N_IMAGEINDEX =2;
            modNew1.N_ORDER = menuMag.GetModuleMaxOrder(modNew1.C_PARENT_ID) + 1;          
            modNew1.C_EMP_ID = sysUser.C_ID;
            modNew1.C_MODULE_TYPE = "2";
            modNew1.C_QUERY_STR = "";
            modNew1.Save();

            TS_MODULE modNew2 = new TS_MODULE();
            modNew2.C_NAME = "角色管理";
            modNew2.C_PARENT_ID = sysModule.C_ID;
            modNew2.C_ASSEMBLYNAME = "RV.UI.dll";
            modNew2.C_MODULECLASS = "RV.UI.FrmRole";
            modNew2.C_DISABLE = "1";
            modNew2.N_IMAGEINDEX = 2;
            modNew2.N_ORDER = menuMag.GetModuleMaxOrder(modNew2.C_PARENT_ID) + 1;
            modNew2.C_EMP_ID = sysUser.C_ID;
            modNew2.C_MODULE_TYPE = "2";
            modNew2.C_QUERY_STR = "";
            modNew2.Save();

            TS_MODULE modNew3 = new TS_MODULE();
            modNew3.C_NAME = "模块管理";
            modNew3.C_PARENT_ID = sysModule.C_ID;
            modNew3.C_ASSEMBLYNAME = "RV.UI.dll";
            modNew3.C_MODULECLASS = "RV.UI.FrmMenuMag";
            modNew3.C_DISABLE = "1";
            modNew3.N_IMAGEINDEX = 2;
            modNew3.N_ORDER = menuMag.GetModuleMaxOrder(modNew3.C_PARENT_ID) + 1;
            modNew3.C_EMP_ID = sysUser.C_ID;
            modNew3.C_MODULE_TYPE = "2";
            modNew3.C_QUERY_STR = "";
            modNew3.Save();

            TS_MODULE modNew4 = new TS_MODULE();
            modNew4.C_NAME = "按钮权限";
            modNew4.C_PARENT_ID = sysModule.C_ID;
            modNew4.C_ASSEMBLYNAME = "RV.UI.dll";
            modNew4.C_MODULECLASS = "RV.UI.FrmBtnMag";
            modNew4.C_DISABLE = "1";
            modNew4.N_IMAGEINDEX = 2;
            modNew4.N_ORDER = menuMag.GetModuleMaxOrder(modNew4.C_PARENT_ID) + 1;
            modNew4.C_EMP_ID = sysUser.C_ID;
            modNew4.C_MODULE_TYPE = "2";
            modNew4.C_QUERY_STR = "";
            modNew4.Save();

            TS_MODULE modNew5 = new TS_MODULE();
            modNew5.C_NAME = "部门档案";
            modNew5.C_PARENT_ID = sysModule.C_ID;
            modNew5.C_ASSEMBLYNAME = "RV.UI.dll";
            modNew5.C_MODULECLASS = "RV.UI.FrmDEPT";
            modNew5.C_DISABLE = "1";
            modNew5.N_IMAGEINDEX = 2;
            modNew5.N_ORDER = menuMag.GetModuleMaxOrder(modNew5.C_PARENT_ID) + 1;
            modNew5.C_EMP_ID = sysUser.C_ID;
            modNew5.C_MODULE_TYPE = "2";
            modNew5.C_QUERY_STR = "";
            modNew5.Save();


            TS_Dept tsDept = new TS_Dept();
            tsDept.C_ID = "1";
            tsDept.C_PARENT_ID = "-1";
            tsDept.C_NAME = "集团";
            tsDept.C_EMP_ID = sysUser.C_ID;
            tsDept.N_STATUS = 1;
            tsDept.Save();
        }

        /// <summary>
        /// 根据用户ID查询所有权限
        /// </summary>
        /// <param name="userAccount"></param>
        /// <returns></returns>
        public static List<TS_MODULE> GetPriviledgeByUserAccount(string userAccount)
        {
            if (userAccount == "system")
            {
                return DbContext.LoadDataByWhere<TS_MODULE>();
            }
            return DbContext.LoadDataByWhere<TS_MODULE>("tsuser.C_ID=@C_ID",userAccount);
        }

        /// <summary>
        /// 获得部门根节点数据列表
        /// </summary>
        public static List<TS_Dept> GetDeptRootList()
        {          
            return TS_Dept.GetList("N_STATUS=1 and C_PARENT_ID='-1' order by c_code");
        }

        /// <summary>
		/// 获得部门子节点数据列表
		/// </summary>
		public static List<TS_Dept> GetDeptList()
        {          
            return TS_Dept.GetList("N_STATUS=1  order by c_code");
        }

        /// <summary>
        /// 获取最大部门代码
        /// </summary>
        public static string GetMaxCode(string c_parent_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.c_code) from ts_dept t where t.c_parent_id='" + c_parent_id + "' ");

            object obj = DbContext.ExecuteScalar(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
        /// 获取最大部门id
        /// </summary>
        public static string GetMaxId(string c_parent_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.c_id) from ts_dept t where t.c_parent_id='" + c_parent_id + "' ");
            object obj = DbContext.ExecuteScalar(strSql.ToString());

            if (obj == null || Convert.IsDBNull(obj))
            {
                return c_parent_id+"01";
            }
            else
            {
                return (Convert.ToInt64(obj.ToString())+1).ToString();
            }
        }

        /// <summary>
        /// 获取部门代码
        /// </summary>
        public static string GetCode(string C_ID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select t.c_code from ts_dept t where t.C_ID='" + C_ID + "' ");

            object obj = DbContext.ExecuteScalar(strSql.ToString());
            if (obj == null)
            {
                return "0";
            }
            else
            {
                return obj.ToString();
            }
        }

        /// <summary>
        /// 获取子模块的最大顺序号
        /// </summary>
        public static int GetModuleMaxOrder(string c_parent_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.n_order) from TS_MODULE t where t.c_parent_id='" + c_parent_id + "' ");
            object obj = DbContext.ExecuteScalar(strSql.ToString());
            if (obj == null||Convert.IsDBNull(obj))
            {
                return 0;
            }
            return Convert.ToInt16(obj);
        }

        /// <summary>
        /// 获取子部门的最大顺序号
        /// </summary>
        public static int GetDeptMaxOrder(string c_parent_id)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select max(t.n_order) from ts_dept t where t.c_parent_id='" + c_parent_id + "' ");

            object obj = DbContext.ExecuteScalar(strSql.ToString());
            if (obj == null || Convert.IsDBNull(obj))
            {
                return 0;
            }
            return Convert.ToInt16(obj);
        }




    }
}
