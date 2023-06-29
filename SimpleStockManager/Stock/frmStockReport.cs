using BH_Library.Utils;
using DevExpress.Utils.About;
using DevExpress.XtraGrid.Columns;
using SimpleStockManager.core;
using SimpleStockManager.core.Control;
using SimpleStockManager.core.Session;
using SimpleStockManager.Transation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStockManager.Stock
{
    public partial class frmStockReport : frmRoot
    {
        DataTable AllData = new DataTable();
        public frmStockReport()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitGridColumn();
            InitLoadData();
            dateEdit1.EditValue = DateTime.Now;
        }

        private void InitGridColumn()
        {
            AddColumn("item_cd", "상품코드");
            AddColumn("item_name", "상품명");
            AddColumn("qty", "수량");

            AddColumn2("date", "일자");
            AddColumn2("type", "구분");
            AddColumn2("qty", "수량");
        }


        private void InitLoadData()
        {
            AllData = SqlManager.LoadList(dateEdit1.DateTime.ToString("yyyy-MM-dd"));
            gridControl1.DataSource = AllData;
            SetDataInfo(string.Format("총 : {0:#,#}건", AllData.Rows.Count));
        }


        public void SetDataInfo(string info)
        {
            lbDataInfo.Text = info;
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

        int vIdx2 = 0;
        public void AddColumn2(string name, string caption, bool visible = true)
        {
            GridColumn col = new GridColumn();
            col.Caption = caption;
            col.Name = "col2_" + name;
            col.FieldName = name;
            col.Visible = visible;
            col.VisibleIndex = vIdx2++;
            gridView2.Columns.Add(col);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitLoadData();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                string item_cd = gridView1.GetFocusedRowCellValue("item_cd").ToStringEx();

                DataTable detailDt = SqlManager.LoadListDetail(dateEdit1.DateTime.ToString("yyyy-MM-dd"), item_cd);
                gridControl2.DataSource = detailDt;
                lbDataInfoDetail.Text = string.Format("총 : {0:#,#}건", detailDt.Rows.Count);
            }
        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            InitLoadData();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = dateEdit1.DateTime.ToString("yyyy-MM-dd") + "_재고현황_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                sfd.Filter = "Excel 통합 문서|*.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    gridControl1.ExportToXlsx(sfd.FileName);
                    Process.Start(sfd.FileName);
                }
            }
        }
    }
}
