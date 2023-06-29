using BH_Library.Utils;
using SimpleStockManager.core.Control;
using SimpleStockManager.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStockManager.Barcode
{
    public partial class frmBarcode : frmRoot
    {
        public frmBarcode()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitData();
        }

        private void InitData()
        {
            gridControl1.DataSource = BarcodeHelper.Instance.List;
        }

        private void btnDownAll_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    string path = fbd.SelectedPath;
                    string file = "Barcode List";
                    int idx = 0;
                    while (true)
                    {
                        if (idx == 0)
                            file = string.Format("{0}\\Barcode List.pdf", path);
                        else
                            file = string.Format("{0}\\Barcode List {1}.pdf", path, idx);
                        if (File.Exists(file))
                            idx++;
                        else
                        {
                            File.WriteAllBytes(file, Resources.code_list);
                            break;
                        }
                    }
                    Process.Start(file);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<int> rows = gridView1.GetSelectedRows().ToList();
            if(rows.Count<=0)
            {
                BhMsgBox.Warning("선택된 바코드가 없습니다.");
                return;
            }


            using(FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    foreach(int id in rows)
                    {
                        BarcodeModel bm = BarcodeHelper.Instance.List.Where(x => x.Id == (id + 1)).FirstOrDefault();
                        string path = fbd.SelectedPath;
                        string file = "";
                        int idx = 0;
                        while (true)
                        {
                            if (idx == 0)
                                file = string.Format("{0}\\{1}.png", path, bm.Title);
                            else
                                file = string.Format("{0}\\{1} {2}.png", path, bm.Title, idx);
                            if (File.Exists(file))
                                idx++;
                            else
                            {
                                File.Copy(bm.ResourcePath, file);
                                break;
                            }
                        }
                    }
                    Process.Start(fbd.SelectedPath);    
                }
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            BarcodeModel bm = gridView1.GetFocusedRow() as BarcodeModel;
            if (bm != null)
            {
                BarcodeModel sb = BarcodeHelper.Instance.List.Where(x => x.Id == bm.Id).First();
                pictureEdit1.EditValue = Image.FromFile(sb.ResourcePath);
            }
        }
    }
}
