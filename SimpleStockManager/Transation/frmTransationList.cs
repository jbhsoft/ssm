using BH_Library.Utils;
using DevExpress.XtraGrid.Columns;
using SimpleStockManager.core;
using SimpleStockManager.core.Control;
using SimpleStockManager.core.Session;
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
using System.Xml.Linq;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace SimpleStockManager.Transation
{
    public partial class frmTransationList : frmRoot
    {
        DataTable AllData = new DataTable();

        public frmTransationList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitGridColumn();
            InitLoadData();
#if DEBUG
            lySeq.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
#endif
            if (SessionManager.UserId != SimpleStockCommon.AdministratorID)
                btnDelete.Visible = true;
            else
                btnDelete.Visible = false;
        } 

        private void InitGridColumn()
        {
            AddColumn("seq", "seq", false);
            AddColumn("date", "일자");
            AddColumn("type", "구분");
            AddColumn("item_cd", "상품코드");
            AddColumn("item_name", "상품명");
            AddColumn("qty", "수량");
            AddColumn("created_by", "등록자", false);
            AddColumn("created_at", "등록일시", false);
            AddColumn("updated_by", "수정자", false);
            AddColumn("updated_at", "수정일시", false);
        }


        private void InitLoadData()
        {
            AllData = SqlManager.LoadList();
            gridControl1.DataSource = AllData;
            SetDataInfo(string.Format("총 : {0:#,#}건", AllData.Rows.Count));
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SessionManager.UserId != SimpleStockCommon.AdministratorID)
            {
                BhMsgBox.Error("삭제는 관리자만 가능합니다.");
            }
            else if (BhMsgBox.Question("삭제는 복구가 불가능 합니다. \r\n\r\n삭제하시겠습니까?", "삭제") == DialogResult.Yes)
            {
                SqlManager.DeleteRow(txtSeq.Text.ToIntEx());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string strDate = DateTime.Now.ToString("yyyy-MM-dd");
            if (dtDate.EditValue != null)
                strDate = ((DateTime)dtDate.EditValue).ToString("yyyy-MM-dd");
            if (ctlTransation1.CodeReadOnly)
            {
                SqlManager.UpdateTransation(txtSeq.Text.ToIntEx(), ctlTransation1.TransationType, ctlTransation1.ItemCode, ctlTransation1.Qty, strDate);
            }
            else
            {
                SqlManager.SaveTransation(ctlTransation1.TransationType, ctlTransation1.ItemCode, ctlTransation1.Qty, strDate);
            }
            ResetControl();
            InitLoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResetControl();
            rgType.SelectedIndex = -1;
            ctlTransation1.btnReset_Click();
            ctlTransation1.CodeReadOnly = false;
            rgType.Focus();
        }

        private void ResetControl()
        {
            rgType.SelectedIndex = -1;
            dtDate.EditValue = DateTime.Now;
            ctlTransation1.btnReset_Click();
            txtSeq.Text = "";
            ctlTransation1.CodeReadOnly = false;
            ctlTransation1.CodeReadFocus();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                int seq = gridView1.GetFocusedRowCellValue("seq").ToIntEx();
                ctlTransation1.CodeReadOnly = true;
                ctlTransation1.LoadRowData(seq);
                DataRow[] rows = AllData.Select("seq = " + seq.ToString() + "");
                if (rows.Length == 1)
                {
                    txtSeq.Text = seq.ToString();
                    string tranType = rows[0]["type"].ToStringEx();
                    if (tranType == "입고")
                        rgType.SelectedIndex = 0;
                    else if (tranType == "출고")
                        rgType.SelectedIndex = 1;
                    dtDate.EditValue = rows[0]["date"].ToStringEx();
                    txtCreated_by.Text = rows[0]["created_by"].ToStringEx();
                    txtCreated_at.Text = rows[0]["created_at"].ToStringEx();
                    txtUpdated_by.Text = rows[0]["updated_by"].ToStringEx();
                    txtUpdated_at.Text = rows[0]["updated_at"].ToStringEx();
                }
            }
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e)
        {
            string str = e.CellValue.ToStringEx();
            if (str.Length > 10)
                e.DisplayText = str.Substring(0, 10);

        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = "transation_list_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                sfd.Filter = "Excel 통합 문서|*.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    List<GridColumn> columns = gridView1.Columns.Where(x => x.Visible == false && x.FieldName != "seq").ToList();
                    columns.ForEach(x =>
                    {
                        x.Visible = true;
                    });
                    gridControl1.ExportToXlsx(sfd.FileName);
                    columns.ForEach(x =>
                    {
                        x.Visible = false;
                    });
                    Process.Start(sfd.FileName);
                }
            }
        }
    }
}
