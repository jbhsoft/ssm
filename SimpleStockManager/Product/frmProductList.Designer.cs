namespace SimpleStockManager.Product
{
    partial class frmProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductList));
            this.dataLayoutControl2 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.rgStatus = new DevExpress.XtraEditors.RadioGroup();
            this.txtUpdated_by = new DevExpress.XtraEditors.TextEdit();
            this.txtUpdated_at = new DevExpress.XtraEditors.TextEdit();
            this.txtCreated_by = new DevExpress.XtraEditors.TextEdit();
            this.txtCreated_at = new DevExpress.XtraEditors.TextEdit();
            this.txtName = new DevExpress.XtraEditors.TextEdit();
            this.txtUm = new DevExpress.XtraEditors.TextEdit();
            this.txtCode = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).BeginInit();
            this.dataLayoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rgStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdated_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdated_at.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreated_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreated_at.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUm.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.Image")));
            this.btnDelete.Visible = false;
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
            this.dataLayoutControl2.Controls.Add(this.txtUpdated_by);
            this.dataLayoutControl2.Controls.Add(this.txtUpdated_at);
            this.dataLayoutControl2.Controls.Add(this.txtCreated_by);
            this.dataLayoutControl2.Controls.Add(this.txtCreated_at);
            this.dataLayoutControl2.Controls.Add(this.txtName);
            this.dataLayoutControl2.Controls.Add(this.txtUm);
            this.dataLayoutControl2.Controls.Add(this.txtCode);
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
            this.rgStatus.Location = new System.Drawing.Point(72, 84);
            this.rgStatus.Name = "rgStatus";
            this.rgStatus.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "사용"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "사용불가")});
            this.rgStatus.Size = new System.Drawing.Size(286, 34);
            this.rgStatus.StyleController = this.dataLayoutControl2;
            this.rgStatus.TabIndex = 12;
            // 
            // txtUpdated_by
            // 
            this.txtUpdated_by.Location = new System.Drawing.Point(72, 194);
            this.txtUpdated_by.Name = "txtUpdated_by";
            this.txtUpdated_by.Properties.ReadOnly = true;
            this.txtUpdated_by.Size = new System.Drawing.Size(286, 20);
            this.txtUpdated_by.StyleController = this.dataLayoutControl2;
            this.txtUpdated_by.TabIndex = 11;
            // 
            // txtUpdated_at
            // 
            this.txtUpdated_at.Location = new System.Drawing.Point(72, 170);
            this.txtUpdated_at.Name = "txtUpdated_at";
            this.txtUpdated_at.Properties.ReadOnly = true;
            this.txtUpdated_at.Size = new System.Drawing.Size(286, 20);
            this.txtUpdated_at.StyleController = this.dataLayoutControl2;
            this.txtUpdated_at.TabIndex = 10;
            // 
            // txtCreated_by
            // 
            this.txtCreated_by.Location = new System.Drawing.Point(72, 146);
            this.txtCreated_by.Name = "txtCreated_by";
            this.txtCreated_by.Properties.ReadOnly = true;
            this.txtCreated_by.Size = new System.Drawing.Size(286, 20);
            this.txtCreated_by.StyleController = this.dataLayoutControl2;
            this.txtCreated_by.TabIndex = 9;
            // 
            // txtCreated_at
            // 
            this.txtCreated_at.Location = new System.Drawing.Point(72, 122);
            this.txtCreated_at.Name = "txtCreated_at";
            this.txtCreated_at.Properties.ReadOnly = true;
            this.txtCreated_at.Size = new System.Drawing.Size(286, 20);
            this.txtCreated_at.StyleController = this.dataLayoutControl2;
            this.txtCreated_at.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(72, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(286, 20);
            this.txtName.StyleController = this.dataLayoutControl2;
            this.txtName.TabIndex = 6;
            // 
            // txtUm
            // 
            this.txtUm.Location = new System.Drawing.Point(72, 60);
            this.txtUm.Name = "txtUm";
            this.txtUm.Properties.EditFormat.FormatString = "#,#";
            this.txtUm.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtUm.Size = new System.Drawing.Size(286, 20);
            this.txtUm.StyleController = this.dataLayoutControl2;
            this.txtUm.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(72, 12);
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(286, 20);
            this.txtCode.StyleController = this.dataLayoutControl2;
            this.txtCode.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(370, 400);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.AppearanceItemCaption.Font = new System.Drawing.Font("굴림", 9F);
            this.layoutControlItem1.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem1.Control = this.txtCode;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem1.Text = "상품코드";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(48, 12);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.AppearanceItemCaption.Font = new System.Drawing.Font("굴림", 9F);
            this.layoutControlItem2.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem2.Control = this.txtUm;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem2.Text = "단가";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(48, 12);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.AppearanceItemCaption.Font = new System.Drawing.Font("굴림", 9F);
            this.layoutControlItem3.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem3.Control = this.txtName;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem3.Text = "상품명";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(48, 12);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.Font = new System.Drawing.Font("굴림", 9F);
            this.layoutControlItem5.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem5.Control = this.txtCreated_at;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 110);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem5.Text = "등록자";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(48, 12);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 206);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(350, 174);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.AppearanceItemCaption.Font = new System.Drawing.Font("굴림", 9F);
            this.layoutControlItem6.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem6.Control = this.txtCreated_by;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 134);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem6.Text = "등록일시";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(48, 12);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.AppearanceItemCaption.Font = new System.Drawing.Font("굴림", 9F);
            this.layoutControlItem7.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem7.Control = this.txtUpdated_at;
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 158);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem7.Text = "수정자";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(48, 12);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.AppearanceItemCaption.Font = new System.Drawing.Font("굴림", 9F);
            this.layoutControlItem8.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem8.Control = this.txtUpdated_by;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 182);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(350, 24);
            this.layoutControlItem8.Text = "수정일시";
            this.layoutControlItem8.TextSize = new System.Drawing.Size(48, 12);
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.AppearanceItemCaption.Font = new System.Drawing.Font("굴림", 9F);
            this.layoutControlItem9.AppearanceItemCaption.Options.UseFont = true;
            this.layoutControlItem9.Control = this.rgStatus;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 72);
            this.layoutControlItem9.MaxSize = new System.Drawing.Size(0, 38);
            this.layoutControlItem9.MinSize = new System.Drawing.Size(114, 38);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(350, 38);
            this.layoutControlItem9.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem9.Text = "사용상태";
            this.layoutControlItem9.TextSize = new System.Drawing.Size(48, 12);
            // 
            // frmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "frmProductList";
            this.Text = "상품 목록";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl2)).EndInit();
            this.dataLayoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rgStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdated_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUpdated_at.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreated_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCreated_at.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUm.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl2;
        private DevExpress.XtraEditors.RadioGroup rgStatus;
        private DevExpress.XtraEditors.TextEdit txtUpdated_by;
        private DevExpress.XtraEditors.TextEdit txtUpdated_at;
        private DevExpress.XtraEditors.TextEdit txtCreated_by;
        private DevExpress.XtraEditors.TextEdit txtCreated_at;
        private DevExpress.XtraEditors.TextEdit txtName;
        private DevExpress.XtraEditors.TextEdit txtUm;
        private DevExpress.XtraEditors.TextEdit txtCode;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
    }
}