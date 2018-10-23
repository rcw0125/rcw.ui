using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Collections;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.Controls;
using Rcw.Model;
using Rcw.Data;


namespace RV.UI
{
    public partial class Login : Form
    {
      

        public Login()
        {
            //Rcw.Data.DbContext.AddDataSource("CAP", DbContext.DbType.Oracle, "192.168.2.204", "orcl", "XGCAPTEST", "XGCAPTEST");
            //DbContext.DefaultDataSourceName = "CAP";
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txt_Name.Text = "system";
            txt_Pwd.Text = "123456";
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                //ModTS_USER modUser = bllUser.GetModel(txt_Name.Text.Trim(), Common.MD5(txt_Pwd.Text.Trim()));

                TS_USER User = TS_USER.GetModel("  C_ACCOUNT=@C_ACCOUNT and C_PASSWORD=@C_PASSWORD", txt_Name.Text.Trim(), Common.MD5(txt_Pwd.Text.Trim()));
               

                if (User != null)
                {
                    if (User.N_STATUS != TS_USER.userStatus.正常)
                    {
                        MessageBox.Show("该账号已经冻结，请联系管理员！");
                        return;
                    }

                    UserInfo.UserID = User.C_ID;
                    UserInfo.UserAccount = User.C_ACCOUNT;
                    UserInfo.UserName = User.C_NAME;
                    topMenu frm = new topMenu();
                    frm.Show();
                    this.Hide();
                    
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！");
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 工位id翻译成描述
        /// </summary>
        /// <returns></returns>
        //public RepositoryItemImageComboBox GetUserName()
        //{
        //    //var dt = bllUser.GetList().Tables[0];
        //    //var repo = new RepositoryItemImageComboBox();
        //    //foreach (DataRow item in dt.Rows)
        //    //{
        //    //    var list = new ImageComboBoxItem(item["C_NAME"].ToString(), item["C_ACCOUNT"]);
        //    //    repo.Items.Add(list);
        //    //}
        //    //return repo;
        //}
    }
}
