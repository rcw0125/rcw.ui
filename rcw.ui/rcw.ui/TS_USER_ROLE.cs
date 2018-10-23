using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Rcw.Data;
using System.ComponentModel;
namespace Rcw.Model
{
	 	//TS_USER_ROLE
		
	public class TS_USER_ROLE : DbEntity
	{
   		#region  属性    
      			
		private string _c_id;	
		/// <summary>
		/// 主键
        /// </summary>		
		[DbTableColumn(IsPrimaryKey = true,IsGuid =true)]		
		[DisplayName("主键")]
        public string C_ID
        {
            get
            {
            	return _c_id; 
            }
            set
            {
                if (_c_id != value)
                {
                   _c_id = value;
                   RaisePropertyChanged("C_ID", true);	                   
                }
            }
        }        
				
		private string _c_role_id;	
		/// <summary>
		/// 角色ID
        /// </summary>		
				
		[DisplayName("角色ID")]
        public string C_ROLE_ID
        {
            get
            {
            	return _c_role_id; 
            }
            set
            {
                if (_c_role_id != value)
                {
                   _c_role_id = value;
                   RaisePropertyChanged("C_ROLE_ID", true);	                   
                }
            }
        }        
				
		private string _c_user_id;	
		/// <summary>
		/// 用户ID
        /// </summary>		
				
		[DisplayName("用户ID")]
        public string C_USER_ID
        {
            get
            {
            	return _c_user_id; 
            }
            set
            {
                if (_c_user_id != value)
                {
                   _c_user_id = value;
                   RaisePropertyChanged("C_USER_ID", true);	                   
                }
            }
        }        
				
		private decimal _n_status;	
		/// <summary>
		/// 使用状态   1-可用；0-停用
        /// </summary>		
				
		[DisplayName("使用状态   1-可用；0-停用")]
        public decimal N_STATUS
        {
            get
            {
            	return _n_status; 
            }
            set
            {
                if (_n_status != value)
                {
                   _n_status = value;
                   RaisePropertyChanged("N_STATUS", true);	                   
                }
            }
        }        
				
		private string _c_remark;	
		/// <summary>
		/// 备注
        /// </summary>		
				
		[DisplayName("备注")]
        public string C_REMARK
        {
            get
            {
            	return _c_remark; 
            }
            set
            {
                if (_c_remark != value)
                {
                   _c_remark = value;
                   RaisePropertyChanged("C_REMARK", true);	                   
                }
            }
        }        
				
		private string _c_emp_id;	
		/// <summary>
		/// 维护人
        /// </summary>		
				
		[DisplayName("维护人")]
        public string C_EMP_ID
        {
            get
            {
            	return _c_emp_id; 
            }
            set
            {
                if (_c_emp_id != value)
                {
                   _c_emp_id = value;
                   RaisePropertyChanged("C_EMP_ID", true);	                   
                }
            }
        }

        private string _c_ts;
        /// <summary>
        /// 维护时间
        /// </summary>		
        [DbTableColumn(IsSysDateString = true)]
        [DisplayName("录入时间")]
        public string C_TS
        {
            get
            {
                return _c_ts;
            }
            set
            {
                if (_c_ts != value)
                {
                    _c_ts = value;
                    RaisePropertyChanged("C_TS", true);
                }
            }
        }

        #endregion 属性

        #region  扩展方法

        /// <summary>
        /// 设置用户角色  1.删除已有的用户角色关系
        ///2.添加现有的用户角色关系
        /// 3.删除当前用户的用户分配权限中（在新的角色中存在的）
        /// </summary>
        public static void SetUserRole(string strUserID, List<TS_USER_ROLE> userRoleList)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from TS_USER_ROLE ");
            strSql.Append(" where C_USER_ID=@C_USER_ID ");
            var conn = DbContext.GetDefaultConnection();
            conn.Open();
            IDbTransaction trans = conn.BeginTransaction();
            try
            {


                DbContext.ExeSql(trans, strSql.ToString(), strUserID);
                if (userRoleList != null && userRoleList.Count > 0)
                {                   
                    userRoleList.Update(trans);
                }
                
                // string deleteSql = "delete from TS_USER_FUN_PCI where C_USER_ID='" + strUserID + "' and C_MODULE_ID in ( select distinct ta.c_module_id from TS_ROLE_FUN ta where ta.c_role_id in (" + strRoleID + "))";
                //DbContext.ExeSql(trans,deleteSql);
                trans.Commit();
                conn.Close();
            }
            catch (Exception ex)
            {
                trans.Rollback();
                conn.Close();
                throw new Exception(ex.ToString());
            }
          
        }
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public static bool Exists(string C_ID)
		{
		    #region  方法
			var List=DbContext.LoadDataByWhere<TS_USER_ROLE>("C_ID=@C_ID", C_ID);
		    if(List.Count>0)
		    {
		         return true;
		    }
		    else
		    {
		         return false;
		    }
			#endregion 方法
		}
		
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public static bool Delete(string C_ID)
		{
		    
		    #region  方法
			try
		    {
		        DbContext.ExeSql("delete from TS_USER_ROLE where  C_ID=@C_ID", C_ID);			
		    }
		    catch
		    {
		        return false;
		    }
		    return true;
			#endregion 方法
		    
		}
		/// <summary>
		/// 获取数据列表
		/// </summary>
		public static List<TS_USER_ROLE> GetList(string whereSql="1=1", params object[] args)
		{
		    return DbContext.LoadDataByWhere<TS_USER_ROLE>(whereSql, args);
		}
		/// <summary>
		/// 使用LoadDataByWhere（）获取单表DbEntityTable
		/// </summary>
		public static DbEntityTable<TS_USER_ROLE> DbEntityTable(string whereSql="1=1", params object[] args)
		{			
		    #region  方法
			DbEntityTable<TS_USER_ROLE>  dbEntityTable=new DbEntityTable<TS_USER_ROLE>();
			try
			{
			    dbEntityTable.LoadDataByWhere(whereSql,args);				
			}
			catch
			{
				return null;
			}				
		    return dbEntityTable;
			#endregion 方法
		}
		/// <summary>
		/// 根据主键ID获取实体模型
		/// </summary>
		public static TS_USER_ROLE GetModel(string C_ID)
		{
		    #region  方法
			var list =DbContext.LoadDataByWhere<TS_USER_ROLE>("C_ID=@C_ID", C_ID);
		    if(list.Count>0)
		    {
		        return list[0];
		    }
		    else
		    {
		        return null;
		    }
			#endregion 方法
		    
		}
		/// <summary>
		/// 根据条件获取实体模型
		/// </summary>
		public static TS_USER_ROLE GetModel(string whereSql="1=1", params object[] args)
		{
		    #region  方法
			var list =DbContext.LoadDataByWhere<TS_USER_ROLE>(whereSql,args);
		    if(list.Count>0)
		    {
		        return list[0];
		    }
		    else
		    {
		        return null;
		    }
			#endregion 方法
		    
		}
		
     
		
		#endregion 扩展方法   
	}
}