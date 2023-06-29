﻿using BH_Library.Utils;
using BH_Library.Utils.Cryptograph;
using DevExpress.XtraPrinting.Native.WebClientUIControl;
using Newtonsoft.Json;
using SimpleStockManager.core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleStockManager.Login
{
    [JsonObject]
    public class LoginInfo
    {
        private readonly string _fileName;

        private static LoginInfo _instance;

        public static LoginInfo Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new LoginInfo();
                    _instance.ReadInfor();
                }
                return _instance;
            }
        }

        private LoginInfo()
        {
            _fileName = Application.StartupPath + @"\LoginOption.txt";
            this.DefaultValueToProperty();
        }

        public void ReadInfor()
        {
            try
            {
                if (File.Exists(_fileName))
                {
                    string readAllText = AES.Decrypt(File.ReadAllText(_fileName), Config.AES_KEY);
                    JsonConvert.PopulateObject(readAllText, this);
                }
            }
            catch (Exception ex)
            {
                if (File.Exists(_fileName))
                    File.Delete(_fileName);
#if DEBUG
                BhMsgBox.Error(ex.Message);
#else
                Console.WriteLine(ex.Message);
#endif
            }
        }

        public void SetInfor(string id, bool saveInfo)
        {
            Id = id;
            IsSaveInfo = saveInfo;
            if (saveInfo == false)
            {
                Id = string.Empty;
            }
            try
            {
                string json = JsonConvert.SerializeObject(this, Formatting.Indented);
                json = AES.Encrypt(json, Config.AES_KEY);
                File.WriteAllText(_fileName, json);
            }
            catch (Exception ex)
            {
#if DEBUG
                BhMsgBox.Error(ex.Message);
#else
                Console.WriteLine(ex.Message);
#endif
            }
        }


        [JsonProperty]
        [DefaultValue("")]
        public string Id { get; set; }

        [JsonProperty]
        [DefaultValue(false)]
        public bool IsSaveInfo { get; set; }

    }
}
