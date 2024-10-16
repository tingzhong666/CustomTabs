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

namespace SolidRebar.AllRebar.SmallBoxGirderRebar.CustomContorls
{
    public class TZTreeView : TreeView
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            var instance = new TZItems
            {
                Padding = new Thickness(20, 0, 0, 0)
            };
            return instance;
        }

        public ICommand SelectCommand
        {
            get { return (ICommand)GetValue(SelectCommandProperty); }
            set { SetValue(SelectCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectCommandProperty =
            DependencyProperty.Register("SelectCommand", typeof(ICommand), typeof(TZTreeView), new PropertyMetadata(null));
    }
}
