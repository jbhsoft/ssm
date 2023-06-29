namespace SimpleStockManager.Staff
{
    partial class frmStaffList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStaffList));
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.rgStatus = new DevExpress.XtraEditors.RadioGroup();
            this.txtUpdated_at = new DevExpress.XtraEditors.TextEdit();
            this.txtUpdated_by = new DevExpress.XtraEditors.TextEdit();
            this.txtPw = new DevExpress.XtraEditors.TextEdit();
            this.txtCreated_at = new DevExpress.XtraEditors.TextEdit();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.txtCreated_by = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtNo = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            this.dataLayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdated_at.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdated_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPw.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreated_at.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreated_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.ImageOptions.Image")));
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.dataLayoutControl2);
            this.dataLayoutControl1.Controls.SetChildIndex(this.btnExcel, 0);
            this.dataLayoutControl1.Controls.SetChildIndex(this.btnAdd, 0);
            this.dataLayoutControl1.Controls.SetChildIndex(this.btnSave, 0);
            this.dataLayoutControl1.Controls.SetChildIndex(this.btnDelete, 0);
            this.dataLayoutControl1.Controls.SetChildIndex(this.panelControl2, 0);
            this.dataLayoutControl1.Controls.SetChildIndex(this.lbDataInfo, 0);
            // 
            // btnExcel
            // 
            this.btnExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.ImageOptions.Image")));
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dataLayoutControl2
            // 
            this.dataLayoutControl2.Controls.Add(this.rgStatus);
            this.dataLayoutControl2.Controls.Add(this.txtUpdated_at);
            this.dataLayoutControl2.Controls.Add(this.txtUpdated_by);
            this.dataLayoutControl2.Controls.Add(this.txtPw);
            this.dataLayoutControl2.Controls.Add(this.txtCreated_at);
            this.dataLayoutControl2.Controls.Add(this.txtId);
            this.dataLayoutControl2.Controls.Add(this.txtCreated_by);
            this.dataLayoutControl2.Controls.Add(this.txtName);
            this.dataLayoutControl2.Controls.Add(this.txtNo);
            this.dataLayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl2.Location = new System.Drawing.Point(0, 0);
            this.dataLayoutControl2.Name = "dataLayoutControl2";
            this.dataLayoutControl2.Root = this.Root;
            this.dataLayoutControl2.Size = new System.Drawing.Size(370, 400);
            this.dataLayoutControl2.TabIndex = 1;
            this.dataLayoutControl2.Text = "dataLayoutControl2";
            // 
            // rgStatus
            // 
            this.rgStatus.Location = new System.Drawing.Point(64, 60);
            this.rgStatus.Name = "rgStatus";
            this.rgStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "재직"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "퇴직")});
            this.rgStatus.Size = new System.Drawing.Size(294, 34);
            this.rgStatus.StyleController = this.dataLayoutControl2;
            this.rgStatus.TabIndex = 12;
            // 
            // txtUpdated_at
            // 
            this.txtUpdated_at.Location = new System.Drawing.Point(64, 218);
            this.txtUpdated_at.Name = "txtUpdated_at";
            this.txtUpdated_at.Properties.ReadOnly = true;
            this.txtUpdated_at.Size = new System.Drawing.Size(294, 20);
            this.txtUpdated_at.StyleController = this.dataLayoutControl2;
            this.txtUpdated_at.TabIndex = 11;
            // 
            // txtUpdated_by
            // 
            this.txtUpdated_by.Location = new System.Drawing.Point(64, 194);
            this.txtUpdated_by.Name = "txtUpdated_by";
            this.txtUpdated_by.Properties.ReadOnly = true;
            this.txtUpdated_by.Size = new System.Drawing.Size(294, 20);
            this.txtUpdated_by.StyleController = this.dataLayoutControl2;
            this.txtUpdated_by.TabIndex = 10;
            // 
            // txtPw
            // 
            this.txtPw.Location = new System.Drawing.Point(64, 122);
            this.txtPw.Name = "txtPw";
            this.txtPw.Properties.PasswordChar = '*';
            this.txtPw.Size = new System.Drawing.Size(294, 20);
            this.txtPw.StyleController = this.dataLayoutControl2;
            this.txtPw.TabIndex = 9;
            // 
            // txtCreated_at
            // 
            this.txtCreated_at.Location = new System.Drawing.Point(64, 170);
            this.txtCreated_at.Name = "txtCreated_at";
            this.txtCreated_at.Properties.ReadOnly = true;
            this.txtCreated_at.Size = new System.Drawing.Size(294, 20);
            this.txtCreated_at.StyleController = this.dataLayoutControl2;
            this.txtCreated_at.TabIndex = 8;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(64, 98);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(294, 20);
            this.txtId.StyleController = this.dataLayoutControl2;
            this.txtId.TabIndex = 7;
            // 
            // txtCreated_by
            // 
            this.txtCreated_by.Location = new System.Drawing.Point(64, 146);
            this.txtCreated_by.Name = "txtCreated_by";
            this.txtCreated_by.Properties.ReadOnly = true;
            this.txtCreated_by.Size = new System.Drawing.Size(294, 20);
            this.txtCreated_by.StyleController = this.dataLayoutControl2;
            this.txtCreated_by.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(294, 20);
            this.txtName.StyleController = this.dataLayoutControl2;
            this.txtName.TabIndex = 5;
            // 
            // txtNo
            // 
            this.txtNo.Location = new System.Drawing.Point(64, 12);
            this.txtNo.Name = "txtNo";
            this.txtNo.Size = new System.Drawing.Size(294, 20);
            this.txtNo.StyleController = this.dataLayoutControl2;
            this.txtNo.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.emptySpaceItem1,
            this.layoutControlItem9});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(370, 400);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtNo;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem1.Text = "사번";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtName;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem2.Text = "이름";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txtCreated_by;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 134);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem3.Text = "입력자";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.txtId;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 86);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem4.Text = "아이디";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txtCreated_at;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 158);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem5.Text = "입력일시";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.txtPw;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem6.Text = "비밀번호";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.txtUpdated_by;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 182);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem7.Text = "수정자";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(40, 14);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.txtUpdated_at;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 206);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem8.Text = "수정일시";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(40, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 230);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(350, 150);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.rgStatus;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(0, 38);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(171, 38);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(350, 38);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "사용구분";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(40, 14);
            // 
            // frmStaffList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Name = "frmStaffList";
            this.Text = "사원 목록";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).EndInit();
            this.dataLayoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdated_at.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdated_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPw.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreated_at.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreated_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit txtNo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.RadioGroup rgStatus;
        private DevExpress.XtraEditors.TextEdit txtUpdated_at;
        private DevExpress.XtraEditors.TextEdit txtUpdated_by;
        private DevExpress.XtraEditors.TextEdit txtPw;
        private DevExpress.XtraEditors.TextEdit txtCreated_at;
        private DevExpress.XtraEditors.TextEdit txtId;
        private DevExpress.XtraEditors.TextEdit txtCreated_by;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}