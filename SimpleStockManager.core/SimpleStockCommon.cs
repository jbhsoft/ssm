using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStockManager.core
{
    public class SimpleStockCommon
    {
        public static string SqlitePath = @"Data Source="+ Application.StartupPath + @"\database\database.db";
        public static bool IsDataBaseConnection = false;

        public static bool IsRequiredRefreshCarList = true;

        public static string AdministratorID = "ssmadmin";

        public static Color SelectedColor = Color.FromArgb(154, 93, 240);
        public static Color HoverColor = Color.FromArgb(28, 141, 255);
        public static Color DefaultColor = Color.Black;
        public static Font HoverFont = new Font("굴림", 9, FontStyle.Bold);
        public static Font DefaultFont = new Font("굴림", 9);
    }
}
