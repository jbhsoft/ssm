namespace SimpleStockManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnUserList = new DevExpress.XtraBars.BarButtonItem();
            this.btnUserMassUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductList = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductMassUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnIn = new DevExpress.XtraBars.BarButtonItem();
            this.btnOut = new DevExpress.XtraBars.BarButtonItem();
            this.btnInout = new DevExpress.XtraBars.BarButtonItem();
            this.lbTime = new DevExpress.XtraBars.BarStaticItem();
            this.lbLoginInfo = new DevExpress.XtraBars.BarStaticItem();
            this.btnCodeTable = new DevExpress.XtraBars.BarButtonItem();
            this.btnStaffPwUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnAbout = new DevExpress.XtraBars.BarButtonItem();
            this.btnClose = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageAdmin = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnUserList,
            this.btnUserMassUpdate,
            this.btnProductList,
            this.btnProductMassUpdate,
            this.btnReport,
            this.btnIn,
            this.btnOut,
            this.btnInout,
            this.lbTime,
            this.lbLoginInfo,
            this.btnCodeTable,
            this.btnStaffPwUpdate,
            this.btnAbout,
            this.btnClose});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 17;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPageAdmin});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(1146, 160);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnUserList
            // 
            this.btnUserList.Caption = "사용자\r\n목록";
            this.btnUserList.Id = 1;
            this.btnUserList.ImageOptions.Image = global::SimpleStockManager.Properties.Resources.customer_16x16;
            this.btnUserList.ImageOptions.LargeImage = global::SimpleStockManager.Properties.Resources.customer_32x32;
            this.btnUserList.Name = "btnUserList";
            this.btnUserList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUserList_ItemClick);
            // 
            // btnUserMassUpdate
            // 
            this.btnUserMassUpdate.Caption = "사용자\r\n대량 등록";
            this.btnUserMassUpdate.Id = 2;
            this.btnUserMassUpdate.ImageOptions.Image = global::SimpleStockManager.Properties.Resources.usergroup_16x16;
            this.btnUserMassUpdate.ImageOptions.LargeImage = global::SimpleStockManager.Properties.Resources.usergroup_32x32;
            this.btnUserMassUpdate.Name = "btnUserMassUpdate";
            this.btnUserMassUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUserMassUpdate_ItemClick);
            // 
            // btnProductList
            // 
            this.btnProductList.Caption = "상품 목록";
            this.btnProductList.Id = 3;
            this.btnProductList.ImageOptions.Image = global::SimpleStockManager.Properties.Resources.add_product__1_;
            this.btnProductList.ImageOptions.LargeImage = global::SimpleStockManager.Properties.Resources.add_product__1_;
            this.btnProductList.Name = "btnProductList";
            this.btnProductList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductList_ItemClick);
            // 
            // btnProductMassUpdate
            // 
            this.btnProductMassUpdate.Caption = "상품\r\n대량 등록";
            this.btnProductMassUpdate.Id = 5;
            this.btnProductMassUpdate.ImageOptions.Image = global::SimpleStockManager.Properties.Resources.product__1_;
            this.btnProductMassUpdate.ImageOptions.LargeImage = global::SimpleStockManager.Properties.Resources.product__1_;
            this.btnProductMassUpdate.Name = "btnProductMassUpdate";
            this.btnProductMassUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnProductMassUpdate_ItemClick);
            // 
            // btnReport
            // 
            this.btnReport.Caption = "재고 현황";
            this.btnReport.Id = 6;
            this.btnReport.ImageOptions.Image = global::SimpleStockManager.Properties.Resources.schedule;
            this.btnReport.ImageOptions.LargeImage = global::SimpleStockManager.Properties.Resources.schedule;
            this.btnReport.Name = "btnReport";
            this.btnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReport_ItemClick);
            // 
            // btnIn
            // 
            this.btnIn.Caption = "빠른 입고\r\n(&F1)";
            this.btnIn.Id = 7;
            this.btnIn.ImageOptions.Image = global::SimpleStockManager.Properties.Resources.inbox__1_;
            this.btnIn.ImageOptions.LargeImage = global::SimpleStockManager.Properties.Resources.inbox__1_;
            this.btnIn.Name = "btnIn";
            this.btnIn.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnIn_ItemClick);
            // 
            // btnOut
            // 
            this.btnOut.Caption = "빠른 출고\r\n(&F4)";
            this.btnOut.Id = 8;
            this.btnOut.ImageOptions.Image = global::SimpleStockManager.Properties.Resources.upload__1_;
            this.btnOut.ImageOptions.LargeImage = global::SimpleStockManager.Properties.Resources.upload__1_;
            this.btnOut.Name = "btnOut";
            this.btnOut.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOut_ItemClick);
            // 
            // btnInout
            // 
            this.btnInout.Caption = "입출고\r\n전체";
            this.btnInout.Id = 9;
            this.btnInout.ImageOptions.Image = global::SimpleStockManager.Properties.Resources.inventory__1_;
            this.btnInout.ImageOptions.LargeImage = global::SimpleStockManager.Properties.Resources.inventory__1_;
            this.btnInout.Name = "btnInout";
            this.btnInout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnInout_ItemClick);
            // 
            // lbTime
            // 
            this.lbTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.lbTime.Id = 10;
            this.lbTime.Name = "lbTime";
            // 
            // lbLoginInfo
            // 
            this.lbLoginInfo.Id = 12;
            this.lbLoginInfo.Name = "lbLoginInfo";
            // 
            // btnCodeTable
            // 
            this.btnCodeTable.Caption = "스캐너용\r\n바코드";
            this.btnCodeTable.Id = 13;
            this.btnCodeTable.ImageOptions.Image = global::SimpleStockManager.Properties.Resources.barcode2_16x16;
            this.btnCodeTable.ImageOptions.LargeImage = global::SimpleStockManager.Properties.Resources.barcode2_32x32;
            this.btnCodeTable.Name = "btnCodeTable";
            this.btnCodeTable.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCodeTable_ItemClick);
            // 
            // btnStaffPwUpdate
            // 
            this.btnStaffPwUpdate.Caption = "비밀번호\r\n변경";
            this.btnStaffPwUpdate.Id = 14;
            this.btnStaffPwUpdate.ImageOptions.Image = global::SimpleStockManager.Properties.Resources.free_icon_change_password_10480727;
            this.btnStaffPwUpdate.ImageOptions.LargeImage = global::SimpleStockManager.Properties.Resources.free_icon_change_password_10480727;
            this.btnStaffPwUpdate.Name = "btnStaffPwUpdate";
            this.btnStaffPwUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnStaffPwUpdate_ItemClick);
            // 
            // btnAbout
            // 
            this.btnAbout.Caption = "About";
            this.btnAbout.Id = 15;
            this.btnAbout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.ImageOptions.Image")));
            this.btnAbout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAbout.ImageOptions.LargeImage")));
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAbout_ItemClick);
            // 
            // btnClose
            // 
            this.btnClose.Caption = "현재창\r\n닫기";
            this.btnClose.Id = 16;
            this.btnClose.ImageOptions.Image = global::SimpleStockManager.Properties.Resources.delete_16x162;
            this.btnClose.ImageOptions.LargeImage = global::SimpleStockManager.Properties.Resources.delete_32x32;
            this.btnClose.Name = "btnClose";
            this.btnClose.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnClose_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4,
            this.ribbonPageGroup2,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "메뉴";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProductList);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnProductMassUpdate);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "상품";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnIn);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnOut);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnInout, true);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "입고/출고";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnReport);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "보고서";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnStaffPwUpdate);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "내 정보";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup7.ItemLinks.Add(this.btnCodeTable);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnAbout);
            this.ribbonPageGroup7.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "도움";
            // 
            // ribbonPageAdmin
            // 
            this.ribbonPageAdmin.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup3});
            this.ribbonPageAdmin.Name = "ribbonPageAdmin";
            this.ribbonPageAdmin.Text = "관리자";
            this.ribbonPageAdmin.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUserList);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnUserMassUpdate);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "사용자";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Alignment = DevExpress.XtraBars.Ribbon.RibbonPageGroupAlignment.Far;
            this.ribbonPageGroup3.ItemLinks.Add(this.btnCodeTable);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnAbout);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnClose);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "도움";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.lbTime);
            this.ribbonStatusBar.ItemLinks.Add(this.lbLoginInfo);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 812);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1146, 24);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 836);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "간단 재고 관리";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnUserList;
        private DevExpress.XtraBars.BarButtonItem btnUserMassUpdate;
        private DevExpress.XtraBars.BarButtonItem btnProductList;
        private DevExpress.XtraBars.BarButtonItem btnProductMassUpdate;
        private DevExpress.XtraBars.BarButtonItem btnReport;
        private DevExpress.XtraBars.BarButtonItem btnIn;
        private DevExpress.XtraBars.BarButtonItem btnOut;
        private DevExpress.XtraBars.BarButtonItem btnInout;
        private DevExpress.XtraBars.BarStaticItem lbTime;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPageAdmin;
        private DevExpress.XtraBars.BarStaticItem lbLoginInfo;
        private DevExpress.XtraBars.BarButtonItem btnCodeTable;
        private DevExpress.XtraBars.BarButtonItem btnStaffPwUpdate;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.BarButtonItem btnAbout;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem btnClose;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
    }
}