using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SolidRebar.AllRebar.SmallBoxGirderRebar.CustomContorls
{
    public class Tab : ObservableObject
    {
        public readonly Guid Id = Guid.NewGuid();

        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private UIElement control;
        public UIElement Control
        {
            get { return control; }
            set { SetProperty(ref control, value); }
        }

        private ObservableCollection<Tab> children = new ObservableCollection<Tab>();
        public ObservableCollection<Tab> Children
        {
            get { return children; }
            set { SetProperty(ref children, value); }
        }

    }
}
