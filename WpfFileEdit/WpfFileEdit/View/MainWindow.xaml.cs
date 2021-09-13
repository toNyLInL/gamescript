using System;
using System.Collections.Generic;
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
using WpfFileEdit.Model;

namespace WpfFileEdit
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            CheckFolderExist();
            JsonModel userdata = new JsonModel();
            apples = new List<AppleType>();
            apples.Add(AppleType.不吃苹果);
            apples.Add(AppleType.金苹果);
            apples.Add(AppleType.银苹果);
            apples.Add(AppleType.彩苹果);

              

            Apple.ItemsSource = apples; 
            
            
        }

        private void CheckFolderExist()
        {
            
        }

        public List<AppleType> apples ;  

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
                    filepath = fullpath;
                }
                else
                {
                    MessageBox.Show("File not support");
                }
            }
        }

        private void Apple_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int  result = (int)Apple.SelectedItem;
            MessageBox.Show("OnSelectedItemChanged " +result);
        }

        private string filepath;

        private void SaveFile(object sender, RoutedEventArgs e)
        {

        }
    }
}
