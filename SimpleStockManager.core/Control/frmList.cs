using DevExpress.XtraGrid.Columns;
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
    public partial class frmList : frmRoot
    {
        public frmList()
        {
            InitializeComponent();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {

        }

        int vIdx = 0;
        public void AddColumn(string name, string caption, bool visible = true)
        {
            GridColumn col = new GridColumn();
            col.Caption = caption;
            col.Name = "col_" + name;
            col.FieldName = name;
            col.VisibleIndex = vIdx++;
            col.Visible = visible;
            gridView1.Columns.Add(col);
        }

        public void SetDataInfo(string info)
        {
            lbDataInfo.Text = info; 
        }
    }
}
