using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace SolidRebar.AllRebar.SmallBoxGirderRebar.CustomContorls.Items
{
    class IsSelectedConvert : MarkupExtension, IMultiValueConverter
    {
        //public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    return false;
        //}

        //public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        //{
        //    throw new NotImplementedException();
        //}

        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            try
            {
                if (values.Length < 2) return false;

                if (values[0] is Tab selected)
                {
                    if (values[1] is Tab currnet)
                    {
                        return currnet == selected;
                    }
                }
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show("IsSelectedConvert Exception");
                return false;
            }
        }


        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }
    }
}
