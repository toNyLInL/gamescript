using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows;

namespace Code{
    public class JsonDataManager
    {
        private static JsonDataManager instance = new JsonDataManager();
        private JsonDataManager() { }
        public static JsonDataManager Instance
        {
            get
            {
                
                return instance;
            }
        }
        
        public struct RoundInfo
        {
            public List<int> round1 ;
            public List<int> round2 ;
            public List<int> round3 ;

        }
        public RoundInfo info;
        internal void JsonLoad(string filename, string singlename)
        {
            string json = File.ReadAllText(filename);
            MessageBox.Show(json);

        }
        internal void JsonWrite()
        {
            string str = JsonConvert.SerializeObject(info);
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory+"test.json", str);
            MessageBox.Show(str);
        }
    }
}
