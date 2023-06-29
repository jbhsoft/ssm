using BH_Library.Utils;
using BH_Library.Utils.IconEx;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Helpers.Docking;
using SimpleStockManager.Barcode;
using SimpleStockManager.core;
using SimpleStockManager.core.Control;
using SimpleStockManager.core.Model;
using SimpleStockManager.core.Session;
using SimpleStockManager.Login;
using SimpleStockManager.Product;
using SimpleStockManager.Properties;
using SimpleStockManager.Staff;
using SimpleStockManager.Stock;
using SimpleStockManager.Transation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SimpleStockManager
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Timer timer = null;
        string inputkey = "";
        Timer inputkeyTimer = null;

        public frmMain()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.IconOptions.Icon = Resources.MainIcon;
            timer = new Timer();    
            timer.Interval= 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
            inputkeyTimer = new Timer();
            inputkeyTimer.Interval = 1500;
            inputkeyTimer.Tick += InputkeyTimer_Tick;
            inputkeyTimer.Start();
            lbLoginInfo.Caption = string.Format("접속자:{0}({1})", SessionManager.UserName, SessionManager.UserId);

            ribbonPageAdmin.Visible = SessionHelper.Instance.UserInfo.IsAdmin;
            base.OnLoad(e);
        }


        private void Timer_Tick(object sender, EventArgs e)
        {
            lbTime.Caption = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }


        private void ShowForm(Menus menuId)
        {
            //escClick = 0;
            frmRoot frm = null;
            switch (menuId)
            {
                case Menus.상품목록: frm = new frmProductList();break;
                //case Menus.빠른입고: frm = new frmFamilyDependentsList(); break;
                //case Menus.빠른출고: frm = new frmCompanyList(); break;
                case Menus.입출고전체: frm = new frmTransationList(); break;
                case Menus.재고현황: frm = new frmStockReport(); break;
                case Menus.사용자: frm = new frmStaffList(); break;
                case Menus.바코드목록: frm = new frmBarcode(); break;
            }

            bool showMsg = true;
            if (frm != null)
            {
                CloseForm(false);
                //SetToolStripButton(true);
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                //frm.CommandButtonEnableChanged += frm_CommandButtonEnableChanged;
                //frm.StatusTextChangeEvent += frm_StatusTextChangeEvent;
                //frm.CustomFunctionSettingEvent += Frm_CustomFunctionSettingEvent;
                frm.FormClosed += Frm_FormClosed;
                frm.ControlBox = false;
                nowActiveForm = frm;
                showMsg = false;
                frm.Show();
            }
              
            if (showMsg)
                BhMsgBox.Error(string.Format("[{0}] 메뉴는 현재 준비중 입니다.", menuId.ToString()));
        }

        //private void SetToolStripButton(bool isEnable)
        //{
        //    btnInsert.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnCopy.Enabled = btnRefresh.Enabled = btnSearch.Enabled = btnExcel.Enabled = btnPrint.Enabled = btnClose.Enabled = isEnable;
        //    btnCustom1.Enabled = btnCustom1.Visible = false;
        //}

        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        frmRoot nowActiveForm = null;

        private void CloseForm(bool toolStripBtnDisable = true)
        {
            if (nowActiveForm != null)
            {
                nowActiveForm.Close();
                nowActiveForm.Dispose(); 
            }
        }

        #region 버튼 클릭 이벤트
        private void btnProductList_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(Menus.상품목록);
        }

        private void btnProductMassUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            FrmExcelModel fem = new FrmExcelModel();
            fem.Title = "상품 대량 등록/수정";
            fem.File = Resources.sample_product;
            fem.VisibleInfo = false;
            fem.FileName = string.Format("sample_product_{0}.xlsx", DateTime.Now.ToString("yyMMdd_HHmmss"));
            using (frmExcel frm = new frmExcel(fem))
            {
                frm.OnMassExecuteData += Frm_OnMassExecuteData;
                frm.ShowDialog(this);
            }
        }

        private bool Frm_OnMassExecuteData(object sender, DataTable dataTable)
        {
            int success = 0;
            int fail = 0;
            string errRow = string.Empty;
            for (int idx = 0; idx < dataTable.Rows.Count; idx++)
            {
                if (Product.SqlManager.InsertUpdateRow(dataTable.Rows[idx]))
                {
                    success++;
                }
                else
                {
                    fail++;
                    errRow += string.Format("{0}, ", idx + 4);
                }
            }

            if (fail > 0)
            {
                BhMsgBox.Error(string.Format("총 {0}개 중 {1}개 성공, {2}개 실패. \r\n 실패한 행번호:{3}",
                    dataTable.Rows.Count, success, fail, errRow));
                return false;
            }
            else
            {
                BhMsgBox.Alarm("데이터 입력이 완료되었습니다.");
                return true;
            }
        }

        private void btnIn_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (frmQuickTransation frm = new frmQuickTransation(TransationTypes.입고))
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this);
                inputkey = string.Empty;
                inputkeyTimer.Start();
            }
        }

        private void btnOut_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (frmQuickTransation frm = new frmQuickTransation(TransationTypes.출고))
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.ShowDialog(this);
                inputkey = string.Empty;
                inputkeyTimer.Start();
            }
        }

        private void btnInout_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(Menus.입출고전체);
        }

        private void btnReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(Menus.재고현황);
        }

        private void btnUserList_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(Menus.사용자);
        }

        private void btnUserMassUpdate_ItemClick(object sender, ItemClickEventArgs e)
        { 
            FrmExcelModel fem = new FrmExcelModel();
            fem.Title = "사용자 대량 등록/수정";
            fem.File = Resources.sample_user;
            fem.VisibleInfo = true;
            fem.FileName = string.Format("sample_staff_{0}.xlsx", DateTime.Now.ToString("yyMMdd_HHmmss"));
            using (frmExcel frm = new frmExcel(fem))
            {
                frm.StartPosition = FormStartPosition.CenterParent;
                frm.OnMassExecuteData += Frm_OnMassExecuteStaff;
                frm.ShowDialog(this);
            }
        }

        private bool Frm_OnMassExecuteStaff(object sender, DataTable dataTable)
        {
            int success = 0;
            int fail = 0;
            string errRow = string.Empty;
            for (int idx = 0; idx < dataTable.Rows.Count; idx++)
            {
                if (Staff.SqlManager.InsertUpdateRow(dataTable.Rows[idx]))
                {
                    success++;
                }
                else
                {
                    fail++;
                    errRow += string.Format("{0}, ", idx + 4);
                }
            }

            if (fail > 0)
            {
                BhMsgBox.Error(string.Format("총 {0}개 중 {1}개 성공, {2}개 실패. \r\n 실패한 행번호:{3}",
                    dataTable.Rows.Count, success, fail, errRow));
                return false;
            }
            else
            {
                BhMsgBox.Alarm("데이터 입력이 완료되었습니다.");
                return true;
            }
        }
        #endregion

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                inputkeyTimer.Stop();
                inputkey = string.Empty;
                btnIn_ItemClick(null, null);
            }
            else if (e.KeyCode == Keys.F4)
            {
                inputkeyTimer.Stop();
                inputkey = string.Empty;
                btnOut_ItemClick(null, null);
            }
            else if(e.KeyCode == Keys.Enter)
            {
                if(inputkey.ToLower() == "btnitemin0")
                {
                    inputkeyTimer.Stop();
                    inputkey = string.Empty;
                    btnIn_ItemClick(null, null);
                }
                else if (inputkey.ToLower() == "btnitemout")
                {
                    inputkeyTimer.Stop();
                    inputkey = string.Empty;
                    btnOut_ItemClick(null, null);
                } 
            }
            else
            {
                inputkey += e.KeyData.ToString();
            }
        }

        private void InputkeyTimer_Tick(object sender, EventArgs e)
        {
            inputkey = string.Empty;
        }

        private void btnStaffPwUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (SessionManager.UserId == SimpleStockCommon.AdministratorID)
            {
                BhMsgBox.Alarm("관리자 비밀번호는 변경 불가 입니다.\r\n노출되지 않도록 주의하세요");
            }
            else
            {
                using (frmStaffPwUpdate frm = new frmStaffPwUpdate())
                {
                    frm.StartPosition = FormStartPosition.CenterParent;
                    frm.ShowDialog(this);
                }
            }
        }

        private void btnAbout_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (frmAbout aboutForm = new frmAbout(""))
            {
                aboutForm.Icon = Resources.MainIcon;
                aboutForm.ShowDialog();
            }
        }

        private void btnClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            CloseForm();
        }

        private void btnCodeTable_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowForm(Menus.바코드목록);
        }
    }
}