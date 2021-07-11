using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FightFileTool
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class FgoMainWindow : Window
    {
        public FgoMainWindow()
        {
            InitializeComponent();
            
        }
        


        private void OnFightFileLoad(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;
            openFileDialog.Multiselect = false;

            if(openFileDialog.ShowDialog().Value == true)
            {
                string fullpath = openFileDialog.FileName;
                string filename = openFileDialog.SafeFileName;
                FileNameShow.Text = filename;
                if (filename.EndsWith(".json"))
                {
                    Code.JsonDataManager.Instance.JsonLoad(fullpath,".json");
                }
                else
                {
                    MessageBox.Show("File not support");
                }
            }
        }
    }
}
