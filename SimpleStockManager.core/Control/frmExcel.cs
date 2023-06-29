using BH_Library.Utils;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Spreadsheet;
using DevExpress.Spreadsheet.Export;
using DevExpress.XtraSpreadsheet;
using ICSharpCode.SharpZipLib.Zip;
using SimpleStockManager.core.Model;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace SimpleStockManager.core.Control
{
    public partial class frmExcel : frmRoot
    {
        public delegate bool OnMassExecuteDataEventHandler(object sender, DataTable dataTable);

        public event OnMassExecuteDataEventHandler OnMassExecuteData;

        FrmExcelModel frmExcelModel = null;
        [Obsolete("디자이너 모드 때문에 남겨둠")]
        public frmExcel()
        {
            InitializeComponent();
        }

        public frmExcel(FrmExcelModel frmExcelModel)
        {
            this.frmExcelModel = frmExcelModel;
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Text = frmExcelModel.Title;
            if(frmExcelModel.VisibleInfo)
            layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            else
                layoutControlItem5.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            btnPath.Focus();
        }

        private void btnSampleDown_Click(object sender, EventArgs e)
        {
            
            using(SaveFileDialog sfd  = new SaveFileDialog())
            {
                sfd.FileName = frmExcelModel.FileName;
                sfd.Filter = "Excel files (*.xls,*xlsx)|*.xls;*xlsx";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    string result = sfd.FileName;
                    File.WriteAllBytes(result, frmExcelModel.File);
                    Process.Start(sfd.FileName);
                }
            }
                   
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(btnPath.Text))
            {
                BhMsgBox.Error("파일을 선택하세요");
                return;
            }

            SpreadsheetControl sc = new SpreadsheetControl();
            sc.LoadDocument(btnPath.Text);
            var dr = sc.ActiveWorksheet.GetDataRange();

            if (dr.RowCount > 3)
            {
                DataTable dt = new DataTable();
                for (int idy = 0; idy < dr.ColumnCount; idy++)
                {
                    dt.Columns.Add(dr[1, idy].Value.TextValue);
                }
                for (int idx = 0; idx < dr.RowCount-3; idx++)
                {
                    DataRow row = dt.NewRow();
                    for (int idy = 0; idy < dr.ColumnCount; idy++)
                    {
                        row[idy] = dr[idx+3, idy].Value;
                    }
                    dt.Rows.Add(row);
                }
                if (OnMassExecuteData != null)
                {
                    if(OnMassExecuteData(this, dt))
                    {
                        Close();
                    }
                    
                }
            }
            else
            {
                BhMsgBox.Error("엑셀파일이 올바르지 않습니다.");
            }
        }

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Index == 0)
            {
                if(string.IsNullOrEmpty(btnPath.Text) == false)
                    Process.Start(btnPath.Text);
            }
            else if(e.Button.Index == 1)
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Excel files (*.xls,*xlsx)|*.xls;*xlsx";
                    ofd.Multiselect = false;
                    if(ofd.ShowDialog() == DialogResult.OK)
                    {
                        btnPath.Text = ofd.FileName;    
                    }
                    
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
