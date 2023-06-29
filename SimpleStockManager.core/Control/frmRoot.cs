using DevExpress.Skins.XtraForm;
using DevExpress.XtraEditors;
using SimpleStockManager.core.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStockManager.core.Control
{
    public partial class frmRoot : DevExpress.XtraEditors.XtraForm
    {
        public frmRoot()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.IconOptions.Icon = SimpleStockManager.core.Helper.IconHelper.DefaultIcon;
            base.OnLoad(e);
        }
    }
}