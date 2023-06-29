using SimpleStockManager.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStockManager.Barcode
{
    public class BarcodeHelper
    {
        private static BarcodeHelper _instance = null;
        public List<BarcodeModel> List = new List<BarcodeModel>();
        public static BarcodeHelper Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BarcodeHelper();
                    _instance.InitLoad();
                }
                return _instance;
            }
        }

        public void InitLoad()
        {
            List.Add(new BarcodeModel(1, "빠른 입고", Resources.btnItemIn));
            List.Add(new BarcodeModel(2, "빠른 출고", Resources.btnItemOut));
            List.Add(new BarcodeModel(3, "초기화", Resources.btnReset));
            List.Add(new BarcodeModel(4, "저장", Resources.btnSave));
            List.Add(new BarcodeModel(5, "저장 후 계속", Resources.btnSaveContinue));
            List.Add(new BarcodeModel(6, "닫기", Resources.btnClose));
            List.Add(new BarcodeModel(7,  "리셋", Resources.btnReset));
            List.Add(new BarcodeModel(8,  "수량 + 1", Resources.btnp01));
            List.Add(new BarcodeModel(9, "수량 + 3", Resources.btnp03));
            List.Add(new BarcodeModel(10, "수량 + 5", Resources.btnp05));
            List.Add(new BarcodeModel(11, "수량 + 10", Resources.btnp10));
            List.Add(new BarcodeModel(12, "수량 + 20", Resources.btnp20));
            List.Add(new BarcodeModel(13, "수량 + 30", Resources.btnp30));
            List.Add(new BarcodeModel(14, "수량 + 50", Resources.btnp50));
            List.Add(new BarcodeModel(15, "수량 - 1", Resources.btnm01));
            List.Add(new BarcodeModel(16, "수량 - 3", Resources.btnm03));
            List.Add(new BarcodeModel(17, "수량 - 5", Resources.btnm05));
            List.Add(new BarcodeModel(18, "수량 - 10", Resources.btnm10));
            List.Add(new BarcodeModel(19, "수량 - 20", Resources.btnm20));
            List.Add(new BarcodeModel(20, "수량 - 30", Resources.btnm30));
            List.Add(new BarcodeModel(21, "수량 - 50", Resources.btnm50));
        } 
    }
}
