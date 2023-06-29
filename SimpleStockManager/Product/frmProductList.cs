using BH_Library.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraPrinting;
using DevExpress.XtraSpreadsheet;
using SimpleStockManager.core;
using SimpleStockManager.core.Control;
using SimpleStockManager.core.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace SimpleStockManager.Product
{
    public partial class frmProductList : frmList
    {
        DataTable AllData = new DataTable();

        public frmProductList()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitEvent();
            InitGridColumn();
            InitLoadData();
            if (SessionManager.UserId != SimpleStockCommon.AdministratorID)
                btnDelete.Visible = true;
            else
                btnDelete.Visible = false;
        }

        private void InitGridColumn()
        {
            base.AddColumn("item_cd", "상품코드");
            base.AddColumn("item_um", "단가");
            base.AddColumn("item_name", "상품명");
            base.AddColumn("item_status", "상태");
            base.AddColumn("created_by", "등록자", false);
            base.AddColumn("created_at", "등록일시", false);
            base.AddColumn("updated_by", "수정자", false);
            base.AddColumn("updated_at", "수정일시", false);
        }


        private void InitLoadData()
        {
            AllData = SqlManager.LoadList();
            gridControl1.DataSource = AllData;
            base.SetDataInfo(string.Format("총 : {0:#,#}건", AllData.Rows.Count));
        }

        private void InitEvent()
        {
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged;
        }
         

        private void LoadRowData(string item_cd)
        {
            DataRow[] rows = AllData.Select("item_cd = '" + item_cd.Trim() + "'");
            if (rows.Length == 1)
            {
                txtCode.Text = rows[0]["item_cd"].ToStringEx();
                txtName.Text = rows[0]["item_name"].ToStringEx();
                txtUm.Text = rows[0]["item_um"].ToStringEx();
                string item_status = rows[0]["item_status"].ToStringEx();
                if (item_status == "사용")
                    rgStatus.SelectedIndex = 0;
                else
                    rgStatus.SelectedIndex = 1;
                txtCreated_by.Text = rows[0]["created_by"].ToStringEx();
                txtCreated_at.Text = rows[0]["created_at"].ToStringEx();
                txtUpdated_by.Text = rows[0]["updated_by"].ToStringEx();
                txtUpdated_at.Text = rows[0]["updated_at"].ToStringEx();
            }
        }

        private void ResetControl()
        {
            txtCode.Text 
                = txtUm.Text 
                = txtName.Text 
                = txtCreated_at.Text 
                = txtCreated_by.Text 
                = txtUpdated_at.Text
                = txtUpdated_by.Text ="";
            rgStatus.SelectedIndex= 0;
        }


        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if(e.FocusedRowHandle>=0)
            {
                string item_cd = gridView1.GetFocusedRowCellValue("item_cd").ToStringEx();
                txtCode.ReadOnly = true;
                LoadRowData(item_cd);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResetControl();
            txtCode.ReadOnly = false;
            txtCode.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SessionManager.UserId != SimpleStockCommon.AdministratorID)
            {
                BhMsgBox.Error("삭제는 관리자만 가능합니다.");
            }
            else
            {
                if(SqlManager.CheckDelete(txtCode.Text))
                {
                    BhMsgBox.Error("입출고 데이터가 있는 상품은 삭제 할 수 없습니다. \r\n입출고 이력을 먼저 지우세요");
                }
                else if (BhMsgBox.Question("삭제는 복구가 불가능 합니다. \r\n\r\n삭제하시겠습니까?", "삭제") == DialogResult.Yes)
                {
                    SqlManager.DeleteRow(txtCode.Text);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.ReadOnly)
            {
                SqlManager.UpdateRow(txtCode.Text, txtName.Text, txtUm.EditValue.ToDecimalEx(), rgStatus.SelectedIndex);
            }
            else
            {
                if(SqlManager.CheckItemCd(txtCode.Text))
                {
                    BhMsgBox.Warning("이미 사용 중인 상품코드 입니다. \r\n상품코드: " + txtCode.Text, "중복");
                }
                else
                    SqlManager.InsertRow(txtCode.Text, txtName.Text, txtUm.EditValue.ToDecimalEx());
            }
            ResetControl();
            InitLoadData();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = "product_list_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                sfd.Filter = "Excel 통합 문서|*.xlsx"; 
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    List<GridColumn> columns = gridView1.Columns.Where(x => x.Visible == false).ToList();
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
