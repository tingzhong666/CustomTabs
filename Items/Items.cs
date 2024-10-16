using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;

namespace SolidRebar.AllRebar.SmallBoxGirderRebar.CustomContorls
{
    public class TZItems : TreeViewItem
    {
        public ICommand SelectCommand
        {
            get { return (ICommand)GetValue(SelectCommandProperty); }
            set { SetValue(SelectCommandProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectCommand.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectCommandProperty =
            DependencyProperty.Register("SelectCommand", typeof(ICommand), typeof(TZItems), new PropertyMetadata(null));

        public TZItems()
        {
            //MouseLeftButtonDown += TZItems_MouseLeftButtonDown;
            MouseLeftButtonUp += TZItems_MouseLeftButtonUp;

        }

        private void TZItems_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            //MessageBox.Show("TZItems_MouseLeftButtonDown");
            if (SelectCommand != null)
            {
                SelectCommand.Execute(DataContext);
            }
        }

        private void TZItems_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
            MessageBox.Show("TZItems_MouseLeftButtonDown");
            if (SelectCommand != null)
            {
                SelectCommand.Execute(DataContext);
            }

        }



        protected override DependencyObject GetContainerForItemOverride()
        {
            var instance = new TZItems
            {
                Padding = new Thickness(Padding.Left + 20, 0, 0, 0)
            };
            return instance;
        }
    }
}
