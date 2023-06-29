using SimpleStockManager.core;
using SimpleStockManager.core.Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStockManager.Transation
{
    public partial class frmQuickTransation : frmTransationRoot
    {
        Timer inputKeyTimer = null;
        string inputkey = string.Empty;

        [Obsolete("디자이너 모드 때문에 남겨둠")]
        public frmQuickTransation()
        {
            InitializeComponent();
        }

        TransationTypes TransationType = TransationTypes.입고;
        public frmQuickTransation(TransationTypes transationType)
        {
            InitializeComponent();
            TransationType = transationType;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (TransationType == TransationTypes.입고)
                this.Text = "빠른 입고";
            else
                this.Text = "빠른 출고";
            ctlTran.TransationType = TransationType;

            inputKeyTimer = new Timer();
            inputKeyTimer.Interval = 1500;
            inputKeyTimer.Tick += InputkeyTimer_Tick;
            inputKeyTimer.Start();


        }
        private void InputkeyTimer_Tick(object sender, EventArgs e)
        {
            inputkey = string.Empty;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ctlTran.btnSave_Click())
                Close();
        }

        private void btnSaveContinue_Click(object sender, EventArgs e)
        {
            ctlTran.btnSaveContinue_Click();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ctlTran.btnReset_Click();
        }

        private void frmQuickTransation_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                inputkey = inputkey.ToLower();
                if (inputkey.StartsWith("btnp") || inputkey.StartsWith("btnm") || inputkey.StartsWith("btnz"))
                {
                    //btnpd0d1
                    bool minus = inputkey.StartsWith("btnm") ? true : false;
                    decimal qty = 0;
                    inputkey = inputkey.Replace("btnp", "").Replace("btnm", "").Replace("btnz", "");
                    switch (inputkey)
                    {
                        case "d0d1": qty = 1; break;
                        case "d0d3": qty = 3; break;
                        case "d0d5": qty = 5; break;
                        case "d1d0": qty = 10; break;
                        case "d2d0": qty = 20; break;
                        case "d3d0": qty = 30; break;
                        case "d5d0": qty = 50; break;
                        default: qty = 0; break;
                    }
                    ctlTran.SetQty(minus, qty);
                }
                else if (inputkey == "btnreset")
                {
                    ctlTran.btnReset_Click();
                }
                else if (inputkey == "btnsave0")
                {
                    ctlTran.btnSave_Click();
                }
                else if (inputkey == "btnsavec")
                {
                    ctlTran.btnSaveContinue_Click();
                }
                else if(inputkey == "btnclose")
                {
                    Close();
                }
            }
            else
            {
                inputkey += e.KeyData.ToString();
            }
        }
    }
}
