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
    public partial class frmStaffPwUpdate : frmRoot
    { 
        public frmStaffPwUpdate()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtPw.Focus();
        } 

        private void txtPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNewPw.Focus();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (SqlManager.CheckPassword(txtPw.Text))
            {
                if (SqlManager.UpdatePassword(txtNewPw.Text))
                {
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("비밀번호를 업데이트 하였습니다.", "확인", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
            else
            {
                BhMsgBox.Error("기존 비밀번호가 올바르지 않습니다.");
            }
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNewPw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNewPw2.Focus();
            } 
        }

        private void txtNewPw2_KeyDown(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(null, null);
            }
        }
    }
}