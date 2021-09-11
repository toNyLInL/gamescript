using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace WpfFileEdit.Converter
{
     class AppleTypeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string typeint = value.ToString();
            string typestr = string.Empty;
            switch (typeint)
            {
                case "0":
                    typestr = "不吃苹果";
                    break;
                case "1":
                    typestr = "金苹果";
                    break;
                case "2":
                    typestr = "银苹果";
                    break;
                case "1000":
                    typestr = "彩苹果";
                    break;
            }

            return typestr;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
