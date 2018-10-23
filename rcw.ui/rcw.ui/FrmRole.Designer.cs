namespace RV.UI
{
    partial class FrmRole
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_RoleName = new DevExpress.XtraEditors.TextEdit();
            this.btn_Query = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Add = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Right = new DevExpress.XtraEditors.SimpleButton();
            this.gc_Role = new DevExpress.XtraGrid.GridControl();
            this.gv_Role = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.tSUSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RoleName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Role)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Role)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSUSERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelControl1);
            this.flowLayoutPanel1.Controls.Add(this.txt_RoleName);
            this.flowLayoutPanel1.Controls.Add(this.btn_Query);
            this.flowLayoutPanel1.Controls.Add(this.btn_Add);
            this.flowLayoutPanel1.Controls.Add(this.btnSave);
            this.flowLayoutPanel1.Controls.Add(this.btn_Right);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(564, 34);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(8, 8);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(8, 8, 2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "角色名称";
            // 
            // txt_RoleName
            // 
            this.txt_RoleName.Location = new System.Drawing.Point(62, 6);
            this.txt_RoleName.Margin = new System.Windows.Forms.Padding(4, 6, 2, 2);
            this.txt_RoleName.Name = "txt_RoleName";
            this.txt_RoleName.Size = new System.Drawing.Size(130, 20);
            this.txt_RoleName.TabIndex = 3;
            // 
            // btn_Query
            // 
            this.btn_Query.ImageOptions.ImageUri.Uri = "Zoom;Size16x16";
            this.btn_Query.Location = new System.Drawing.Point(202, 5);
            this.btn_Query.Margin = new System.Windows.Forms.Padding(8, 5, 2, 2);
            this.btn_Query.Name = "btn_Query";
            this.btn_Query.Size = new System.Drawing.Size(56, 22);
            this.btn_Query.TabIndex = 4;
            this.btn_Query.Text = "查询";
            this.btn_Query.Click += new System.EventHandler(this.btn_Query_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.ImageOptions.ImageUri.Uri = "Add;Size16x16";
            this.btn_Add.Location = new System.Drawing.Point(268, 5);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(8, 5, 2, 2);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(56, 22);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "增加";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.ImageUri.Uri = "Save;Size16x16";
            this.btnSave.Location = new System.Drawing.Point(334, 5);
            this.btnSave.Margin = new System.Windows.Forms.Padding(8, 5, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 22);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保存";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.ImageOptions.ImageUri.Uri = "Apply;Size16x16";
            this.btn_Right.Location = new System.Drawing.Point(400, 5);
            this.btn_Right.Margin = new System.Windows.Forms.Padding(8, 5, 2, 2);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(82, 22);
            this.btn_Right.TabIndex = 5;
            this.btn_Right.Text = "权限设置";
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // gc_Role
            // 
            this.gc_Role.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Role.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Role.Location = new System.Drawing.Point(0, 34);
            this.gc_Role.MainView = this.gv_Role;
            this.gc_Role.Margin = new System.Windows.Forms.Padding(2);
            this.gc_Role.Name = "gc_Role";
            this.gc_Role.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
            this.gc_Role.Size = new System.Drawing.Size(564, 366);
            this.gc_Role.TabIndex = 2;
            this.gc_Role.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Role});
            // 
            // gv_Role
            // 
            this.gv_Role.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gv_Role.GridControl = this.gc_Role;
            this.gv_Role.Name = "gv_Role";
            this.gv_Role.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "主键";
            this.gridColumn1.FieldName = "C_ID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "角色名称";
            this.gridColumn2.FieldName = "C_ROLE_NAME";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "维护人";
            this.gridColumn3.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.gridColumn3.FieldName = "C_EMP_ID";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.DataSource = this.tSUSERBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "C_NAME";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.ValueMember = "C_ID";
            // 
            // tSUSERBindingSource
            // 
            this.tSUSERBindingSource.DataSource = typeof(Rcw.Model.TS_USER);
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "维护时间";
            this.gridColumn4.DisplayFormat.FormatString = "G";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn4.FieldName = "D_MOD_DT";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "状态";
            this.gridColumn5.FieldName = "N_STATUS";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            // 
            // FrmRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 400);
            this.Controls.Add(this.gc_Role);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmRole";
            this.Text = "角色管理";
            this.Load += new System.EventHandler(this.FrmRole_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_RoleName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Role)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Role)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tSUSERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txt_RoleName;
        private DevExpress.XtraEditors.SimpleButton btn_Add;
        private DevExpress.XtraGrid.GridControl gc_Role;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Role;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btn_Query;
        private DevExpress.XtraEditors.SimpleButton btn_Right;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource tSUSERBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btnSave;
    }
}