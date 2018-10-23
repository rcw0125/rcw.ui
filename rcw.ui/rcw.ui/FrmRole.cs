using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Rcw.Model;
using Rcw.Data;
using Rcw.Method;

namespace RV.UI
{
    public partial class FrmRole : Form
    {
        private List<TS_ROLE_PCI> roleList = null;
        public FrmRole()
        {
            InitializeComponent();
        }

        private void FrmRole_Load(object sender, EventArgs e)
        {
            tSUSERBindingSource.DataSource = TS_USER.GetList();
          
            //menuMag.SetGvUnEditable(gv_Role);
            RefreshData();
        }

        private void RefreshData()
        {
            try
            {
                string strSql = "1=1";
                if (txt_RoleName.Text.Trim() != "")
                {
                    strSql = "C_ROLE_NAME='"+txt_RoleName.Text.Trim()+"'";
                }
                roleList = TS_ROLE_PCI.GetList(strSql);
                gc_Role.DataSource = roleList;
                gv_Role.RefreshData();
                gv_Role.SetMultiSelect();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                TS_ROLE_PCI newRole = new TS_ROLE_PCI();
                newRole.C_EMP_ID = UserInfo.UserID;
                newRole.D_MOD_DT = DateTime.Now;
                newRole.N_STATUS = TS_ROLE_PCI.N_Status.正常;
                roleList.Add(newRole);
                gv_Role.RefreshData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Query_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        /// <summary>
        /// 权限设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Right_Click(object sender, EventArgs e)
        {
            try
            {
               
                TS_ROLE_PCI curRole = gv_Role.GetFocusedRow() as TS_ROLE_PCI;

                if (curRole != null)
                {
                    FrmRight frm = new FrmRight(curRole.C_ID, "2");
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var data = TS_ROLE_PCI.GetSelectedRow(gv_Role);
            data.Update();
            MessageBox.Show("操作成功！");
            RefreshData();
        }
    }
}
