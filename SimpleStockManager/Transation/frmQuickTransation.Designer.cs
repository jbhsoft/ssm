namespace SimpleStockManager.Transation
{
    partial class frmQuickTransation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuickTransation));
            this.ctlTran = new SimpleStockManager.Transation.ctlTransation();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ctlTran);
            this.panelControl1.Size = new System.Drawing.Size(479, 343);
            // 
            // btnReset
            // 
            this.btnReset.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.ImageOptions.Image")));
            this.btnReset.Location = new System.Drawing.Point(93, 359);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.ImageOptions.Image")));
            this.btnSave.Location = new System.Drawing.Point(193, 359);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveContinue
            // 
            this.btnSaveContinue.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveContinue.ImageOptions.Image")));
            this.btnSaveContinue.Location = new System.Drawing.Point(293, 359);
            this.btnSaveContinue.Click += new System.EventHandler(this.btnSaveContinue_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(395, 359);
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ctlTran
            // 
            this.ctlTran.CodeReadOnly = false;
            this.ctlTran.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlTran.ItemCode = null;
            this.ctlTran.Location = new System.Drawing.Point(0, 0);
            this.ctlTran.Margin = new System.Windows.Forms.Padding(0);
            this.ctlTran.Name = "ctlTran";
            this.ctlTran.Size = new System.Drawing.Size(479, 343);
            this.ctlTran.TabIndex = 0;
            this.ctlTran.TransationType = SimpleStockManager.core.TransationTypes.입고;
            // 
            // frmQuickTransation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 393);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(505, 425);
            this.MinimumSize = new System.Drawing.Size(505, 425);
            this.Name = "frmQuickTransation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "빠른 입고";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmQuickTransation_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctlTransation ctlTran;
    }
}