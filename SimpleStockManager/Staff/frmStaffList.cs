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
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace SimpleStockManager.Staff
{
    public partial class frmStaffList : frmList
    {
        DataTable AllData = new DataTable();
        public frmStaffList()
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
            base.AddColumn("staff_no", "사번");
            base.AddColumn("staff_name", "이름");
            base.AddColumn("staff_id", "아이디");
            base.AddColumn("staff_status", "상태");
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
            gridView1.FocusedRowChanged += GridView1_FocusedRowChanged; ;
        }

        private void GridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle >= 0)
            {
                string staff_no = gridView1.GetFocusedRowCellValue("staff_no").ToStringEx();
                txtNo.ReadOnly = true;
                LoadRowData(staff_no);
            }
        }


        private void LoadRowData(string staff_no)
        {
            DataRow[] rows = AllData.Select("staff_no = '" + staff_no.Trim() + "'");
            if (rows.Length == 1)
            {
                txtNo.Text = rows[0]["staff_no"].ToStringEx();  
                txtName.Text = rows[0]["staff_no"].ToStringEx();
                txtId.Text = rows[0]["staff_id"].ToStringEx();
                if(rows[0]["staff_status"].ToStringEx() == "재직")
                    rgStatus.SelectedIndex = 0;
                else if(rows[0]["staff_status"].ToStringEx() == "퇴직")
                    rgStatus.SelectedIndex = 1;
                else
                    rgStatus.SelectedIndex = -1;
                txtName.Text = rows[0]["staff_name"].ToStringEx();
                txtCreated_by.Text = rows[0]["created_by"].ToStringEx();
                txtCreated_at.Text = rows[0]["created_at"].ToStringEx();
                txtUpdated_by.Text = rows[0]["updated_by"].ToStringEx();
                txtUpdated_at.Text = rows[0]["updated_at"].ToStringEx();
            }
        }

        private void ResetControl()
        {
            txtNo.Text
                = txtId.Text
                = txtName.Text
                = txtCreated_at.Text
                = txtCreated_by.Text
                = txtUpdated_at.Text
                = txtUpdated_by.Text = "";
            rgStatus.SelectedIndex = 0;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResetControl();
            txtNo.ReadOnly = false;
            txtNo.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (SessionManager.UserId != SimpleStockCommon.AdministratorID)
            {
                BhMsgBox.Error("삭제는 관리자만 가능합니다.");
            }
            else
            {
                if (SqlManager.CheckDelete(txtNo.Text))
                {
                    BhMsgBox.Error("입력한 데이터가이 있는 계정은 삭제 할 수 없습니다.\r\n해당 계정으로 생성한 모든 데이터를 먼저 지우세요");
                }
                else if (BhMsgBox.Question("삭제는 복구가 불가능 합니다. \r\n\r\n삭제하시겠습니까?", "삭제") == DialogResult.Yes)
                {
                    SqlManager.DeleteRow(txtNo.Text);
                    ResetControl();
                    InitLoadData();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNo.ReadOnly)
            {
                if (SqlManager.CheckStaff_id(txtNo.Text, txtId.Text) == false)
                    BhMsgBox.Warning("이미 사용 중인 아이디 입니다. \r\n아이디 " + txtId.Text, "중복");
                else
                {
                    SqlManager.UpdateRow(txtNo.Text, txtId.Text, txtName.Text, rgStatus.SelectedIndex == -1 ? "재직" : "퇴직", txtPw.Text);
                    ResetControl();
                    InitLoadData();
                }
            }
            else
            {
                if (SqlManager.CheckStaff_id(txtNo.Text, txtId.Text) == false)
                    BhMsgBox.Warning("이미 사용 중인 아이디 입니다. \r\n아이디 " + txtId.Text, "중복");
                else if (SqlManager.CheckStaff_no(txtNo.Text))
                    BhMsgBox.Warning("이미 사용 중인 사번 입니다. \r\n사번 " + txtNo.Text, "중복");
                else
                {
                    SqlManager.InsertRow(txtNo.Text, txtId.Text, txtName.Text, txtPw.Text);
                    ResetControl();
                    InitLoadData();
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = "staff_list_" + DateTime.Now.ToString("yyyyMMddHHmmss");
                sfd.Filter = "Excel 통합 문서|*.xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
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
