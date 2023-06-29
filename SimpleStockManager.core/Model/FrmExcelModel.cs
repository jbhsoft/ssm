using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleStockManager.core.Model
{
    public class FrmExcelModel
    {
        public FrmExcelModel()
        {

        }

        public FrmExcelTypes FrmExcelTypes { get; set; }

        public string DownExcelBtnText { get; set; }
        public string Title { get; set; }
        [DefaultValue(false)]   
        public bool VisibleInfo { get;set; }
        public byte[] File { get; set; }
        public string FileName { get; set; }
    }
}
