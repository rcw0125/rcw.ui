namespace RV.UI
{
    partial class FrmUserAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_LoginName = new DevExpress.XtraEditors.TextEdit();
            this.txt_UserName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_Tel = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Cancle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_LoginName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tel.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(33, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(24, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "账号";
            // 
            // txt_LoginName
            // 
            this.txt_LoginName.Location = new System.Drawing.Point(60, 17);
            this.txt_LoginName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_LoginName.Name = "txt_LoginName";
            this.txt_LoginName.Properties.MaxLength = 50;
            this.txt_LoginName.Size = new System.Drawing.Size(134, 20);
            this.txt_LoginName.TabIndex = 1;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(60, 62);
            this.txt_UserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Properties.MaxLength = 20;
            this.txt_UserName.Size = new System.Drawing.Size(134, 20);
            this.txt_UserName.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(33, 65);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(24, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "姓名";
            // 
            // txt_Tel
            // 
            this.txt_Tel.Location = new System.Drawing.Point(60, 108);
            this.txt_Tel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Properties.MaxLength = 20;
            this.txt_Tel.Size = new System.Drawing.Size(134, 20);
            this.txt_Tel.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(33, 110);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(24, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "电话";
            // 
            // btn_Save
            // 
            this.btn_Save.ImageOptions.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(33, 198);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(56, 22);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "确定";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.ImageOptions.ImageUri.Uri = "Cancel;Size16x16";
            this.btn_Cancle.Location = new System.Drawing.Point(134, 198);
            this.btn_Cancle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(56, 22);
            this.btn_Cancle.TabIndex = 21;
            this.btn_Cancle.Text = "取消";
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // FrmUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 282);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txt_LoginName);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加用户";
            this.Load += new System.EventHandler(this.FrmUserAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_LoginName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_UserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Tel.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_LoginName;
        private DevExpress.XtraEditors.TextEdit txt_UserName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txt_Tel;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
        private DevExpress.XtraEditors.SimpleButton btn_Cancle;
    }
}