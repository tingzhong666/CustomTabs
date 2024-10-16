using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public class Tabs : Control
    {
        public ObservableCollection<Tab> Items
        {
            get { return (ObservableCollection<Tab>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Items.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsProperty =
            DependencyProperty.Register("Items", typeof(ObservableCollection<Tab>), typeof(Tabs), new PropertyMetadata(new ObservableCollection<Tab>()));



        public Tab Selected
        {
            get { return (Tab)GetValue(SelectedProperty); }
            set { SetValue(SelectedProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Selected.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedProperty =
            DependencyProperty.Register("Selected", typeof(Tab), typeof(Tabs), new PropertyMetadata(null));


        public RelayCommand<object> Select => new RelayCommand<object>((object obj) =>
        {
            if (obj is Tab tab)
            {
            //MessageBox.Show("test1");
                Selected = tab;
            }
        });
        public RelayCommand Select2 => new RelayCommand(() =>
        {
            MessageBox.Show("test2");
        });

    }
}
