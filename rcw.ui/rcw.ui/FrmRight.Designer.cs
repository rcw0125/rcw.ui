namespace RV.UI
{
    partial class FrmRight
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
            this.bscTSMODULE = new System.Windows.Forms.BindingSource(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_Save = new DevExpress.XtraEditors.SimpleButton();
            this.tl_Module = new DevExpress.XtraTreeList.TreeList();
            this.colC_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_PARENT_ID = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.colC_NAME = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bscTSMODULE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tl_Module)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.ImageUri.Uri = "Zoom;Size16x16";
            this.simpleButton1.Location = new System.Drawing.Point(9, 7);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(56, 22);
            this.simpleButton1.TabIndex = 18;
            this.simpleButton1.Text = "查询";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btn_Save);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(827, 36);
            this.panelControl1.TabIndex = 0;
            // 
            // btn_Save
            // 
            this.btn_Save.ImageOptions.ImageUri.Uri = "Save;Size16x16";
            this.btn_Save.Location = new System.Drawing.Point(88, 7);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(56, 22);
            this.btn_Save.TabIndex = 19;
            this.btn_Save.Text = "确定";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tl_Module
            // 
            this.tl_Module.AllowDrop = true;
            this.tl_Module.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.colC_ID,
            this.colC_PARENT_ID,
            this.colC_NAME});
            this.tl_Module.Cursor = System.Windows.Forms.Cursors.Default;
            this.tl_Module.DataSource = this.bscTSMODULE;
            this.tl_Module.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_Module.ImageIndexFieldName = "N_IMAGEINDEX";
            this.tl_Module.Location = new System.Drawing.Point(0, 36);
            this.tl_Module.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tl_Module.Name = "tl_Module";
            this.tl_Module.OptionsBehavior.PopulateServiceColumns = true;
            this.tl_Module.OptionsView.ShowCheckBoxes = true;
            this.tl_Module.Size = new System.Drawing.Size(827, 474);
            this.tl_Module.TabIndex = 1;
            this.tl_Module.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.tl_Module_BeforeCheckNode);
            this.tl_Module.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tl_Module_AfterCheckNode);
            // 
            // colC_ID
            // 
            this.colC_ID.FieldName = "C_ID";
            this.colC_ID.Name = "colC_ID";
            this.colC_ID.Width = 100;
            // 
            // colC_PARENT_ID
            // 
            this.colC_PARENT_ID.FieldName = "C_PARENT_ID";
            this.colC_PARENT_ID.Name = "colC_PARENT_ID";
            this.colC_PARENT_ID.Width = 82;
            // 
            // colC_NAME
            // 
            this.colC_NAME.Caption = "功能列表";
            this.colC_NAME.FieldName = "C_NAME";
            this.colC_NAME.MinWidth = 34;
            this.colC_NAME.Name = "colC_NAME";
            this.colC_NAME.OptionsColumn.AllowEdit = false;
            this.colC_NAME.Visible = true;
            this.colC_NAME.VisibleIndex = 0;
            this.colC_NAME.Width = 82;
            // 
            // FrmRight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 510);
            this.Controls.Add(this.tl_Module);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmRight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "权限分配";
            this.Load += new System.EventHandler(this.FrmRight_Load);
            this.Shown += new System.EventHandler(this.FrmRight_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bscTSMODULE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tl_Module)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bscTSMODULE;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraTreeList.TreeList tl_Module;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_PARENT_ID;
        private DevExpress.XtraTreeList.Columns.TreeListColumn colC_NAME;
        private DevExpress.XtraEditors.SimpleButton btn_Save;
    }
}