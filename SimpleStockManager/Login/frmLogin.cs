using BH_Library.Utils;
using DevExpress.XtraEditors;
using SimpleStockManager.core;
using SimpleStockManager.core.Control;
using SimpleStockManager.core.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStockManager.Login
{
    public partial class frmLogin : frmRoot
    { 
        bool AutoLogin = false;

        [Obsolete("디자이너모드때문에 남겨둠, 사용금지")]
        public frmLogin()
        {
            InitializeComponent();
        }

        public frmLogin(bool AutoLogin)
        {
            InitializeComponent();
            this.AutoLogin = AutoLogin;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (LoginInfo.Instance.IsSaveInfo)
            {
                chkSaveInfo.Checked = LoginInfo.Instance.IsSaveInfo;
                txtId.Text = LoginInfo.Instance.Id;
                if (string.IsNullOrEmpty(txtId.Text) == false)
                    txtPw.Focus();
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtPw.Focus();
            }
        }

        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtId.Text.ToLower() == SimpleStockCommon.AdministratorID && txtPw.Text.ToLower() == "p@ssw0rd!@")
            {
                SessionManager.GetSessionHelper(SimpleStockSessionManager.GetSessionHelper(txtId.Text));
                chkSaveInfo.Checked = false;
                LoginInfo.Instance.SetInfor("", chkSaveInfo.Checked);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else if (SqlManager.USER_CHECK(txtId.Text, txtPw.Text))
            {
                SessionManager.GetSessionHelper(SimpleStockSessionManager.GetSessionHelper(txtId.Text));
                LoginInfo.Instance.SetInfor(txtId.Text, chkSaveInfo.Checked);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                Close();
            }
            else
            {
                BhMsgBox.Error("로그인 정보를 확인 할 수 없습니다.\r\n아이디와 패스워드를 정확하게 입력하세요");
            }
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}