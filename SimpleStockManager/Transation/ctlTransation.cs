using BH_Library.Utils;
using DevExpress.XtraEditors;
using SimpleStockManager.core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStockManager.Transation
{
    public partial class ctlTransation : XtraUserControl
    {


        public TransationTypes TransationType { get; set; }
        public string ItemCode { get; set; }
        public decimal Qty
        {
            get
            {
                return txtQty.Value;
            }
        }


        public ctlTransation()
        {
            InitializeComponent();
        }

        public void btnReset_Click()
        {
            ItemCode = btnCode.Text = txtUm.Text = txtName.Text = "";
            txtQty.Value = 0;
            btnCode.Focus();
        }

        public void CodeReadFocus()
        {
            btnCode.Focus();
            btnCode.SelectAll();
        }

        public bool CodeReadOnly
        {
            get
            {
                return btnCode.ReadOnly;
            }
            set
            {
                btnCode.ReadOnly = value;
            }
        }

        public bool btnSave_Click()
        {
            if (txtQty.Value > 0)
            {
                return SqlManager.SaveTransation(TransationType, btnCode.Text, txtQty.Value);
            }
            return false;
        }

        public void btnSaveContinue_Click()
        {
            btnSave_Click();
            btnReset_Click();
        }


        private void btnCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DataTable dt = SqlManager.FindData(btnCode.Text);
            btnReset_Click();
            if (dt.Rows.Count == 1)
            {
                ItemCode =
                btnCode.Text = dt.Rows[0]["item_cd"].ToStringEx();
                txtUm.Text = dt.Rows[0]["item_um"].ToStringEx();
                txtName.Text = dt.Rows[0]["item_name"].ToStringEx();
                txtQty.Value = 0;
                txtQty.Focus();
                txtQty.SelectAll();
            }
            else
            {
                BhMsgBox.Error("올바르지 않은 품목 코드 입니다");
            }
        }

        private void btnQty_ButtonClick(object sender, EventArgs e)
        {
            SimpleButton btn = sender as SimpleButton;
            if (btn == null)
                return;

            bool minus = false;
            if (btn.Tag.ToString().StartsWith("-"))
                minus = true;
            decimal qty = btn.Tag.ToString().Replace("-", "").ToDecimalEx();
            SetQty(minus, qty);
        }

        public void SetQty(bool minus, decimal qty)
        {
            if (qty == 0)
                txtQty.Value = 0;
            else
                txtQty.Value = txtQty.Value + (qty * (minus ? -1 : 1));

            if (txtQty.Value <= 0) txtQty.Value = 0;
        }

        private void btnCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCode_ButtonClick(null, null);
            }
        }

        public void LoadRowData(int seq)
        {
            DataTable dt = SqlManager.FindRow(seq);
            if (dt.Rows.Count == 1)
            {
                ItemCode =
                btnCode.Text = dt.Rows[0]["item_cd"].ToStringEx();
                btnCode.ReadOnly = true;
                txtName.Text = dt.Rows[0]["item_name"].ToStringEx();
                txtUm.Text = dt.Rows[0]["item_um"].ToStringEx();
                txtQty.Value = dt.Rows[0]["qty"].ToDecimalEx();
            }
        } 
    }
}
