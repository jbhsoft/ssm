using SimpleStockManager.Properties;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace SimpleStockManager.Barcode
{
    public class BarcodeModel
    {
        public int Id { get; set; }
        public bool Selected { get; set; }
        public string Title { get; set; }
        public string ResourcePath { get; set; }

        public BarcodeModel(int id, string title, Bitmap resourcePath)
        {
            Id = id;
            Title = title;
            string rootPath = Application.StartupPath + "\\barcode_img\\";
            if(Directory.Exists(rootPath) == false)
                Directory.CreateDirectory(rootPath);
            string fat = "{0}{1}.png"; 
            string fileName = string.Format(fat, rootPath, id);
            if (File.Exists(fileName) == false)
                resourcePath.Save(fileName);
            ResourcePath = fileName;
            Selected = false;
        }
    }
}