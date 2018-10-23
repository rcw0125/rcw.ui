using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Rcw.Data;
using System.ComponentModel;
using System.Collections;

namespace Rcw.Model
{
	 	//TS_USER_FUN_PCI
		
	public class TS_USER_FUN_PCI : DbEntity
	{
   		#region  属性    
      			
		private string _c_id;	
		/// <summary>
		/// 主键
        /// </summary>		
		[DbTableColumn(IsPrimaryKey = true)]		
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
				
		private string _c_module_id;	
		/// <summary>
		/// 菜单表主键
        /// </summary>		
				
		[DisplayName("菜单表主键")]
        public string C_MODULE_ID
        {
            get
            {
            	return _c_module_id; 
            }
            set
            {
                if (_c_module_id != value)
                {
                   _c_module_id = value;
                   RaisePropertyChanged("C_MODULE_ID", true);	                   
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
				
		private string _c_function_type;	
		/// <summary>
		/// 权限类型；1-菜单权限；2-按钮权限
        /// </summary>		
				
		[DisplayName("权限类型；1-菜单权限；2-按钮权限")]
        public string C_FUNCTION_TYPE
        {
            get
            {
            	return _c_function_type; 
            }
            set
            {
                if (_c_function_type != value)
                {
                   _c_function_type = value;
                   RaisePropertyChanged("C_FUNCTION_TYPE", true);	                   
                }
            }
        }        
				
		private DateTime _d_mod_dt;	
		/// <summary>
		/// 添加时间
        /// </summary>		
				
		[DisplayName("添加时间")]
        public DateTime D_MOD_DT
        {
            get
            {
            	return _d_mod_dt; 
            }
            set
            {
                if (_d_mod_dt != value)
                {
                   _d_mod_dt = value;
                   RaisePropertyChanged("D_MOD_DT", true);	                   
                }
            }
        }

        #endregion 属性

        #region  扩展方法

       
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public static bool Exists(string C_ID)
		{
		    #region  方法
			var List=DbContext.LoadDataByWhere<TS_USER_FUN_PCI>("C_ID=@C_ID", C_ID);
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
		        DbContext.ExeSql("delete from TS_USER_FUN_PCI where  C_ID=@C_ID", C_ID);			
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
		public static List<TS_USER_FUN_PCI> GetList(string whereSql="1=1", params object[] args)
		{
		    return DbContext.LoadDataByWhere<TS_USER_FUN_PCI>(whereSql, args);
		}
		/// <summary>
		/// 使用LoadDataByWhere（）获取单表DbEntityTable
		/// </summary>
		public static DbEntityTable<TS_USER_FUN_PCI> DbEntityTable(string whereSql="1=1", params object[] args)
		{			
		    #region  方法
			DbEntityTable<TS_USER_FUN_PCI>  dbEntityTable=new DbEntityTable<TS_USER_FUN_PCI>();
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
		public static TS_USER_FUN_PCI GetModel(string C_ID)
		{
		    #region  方法
			var list =DbContext.LoadDataByWhere<TS_USER_FUN_PCI>("C_ID=@C_ID", C_ID);
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
		public static TS_USER_FUN_PCI GetModel(string whereSql="1=1", params object[] args)
		{
		    #region  方法
			var list =DbContext.LoadDataByWhere<TS_USER_FUN_PCI>(whereSql,args);
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