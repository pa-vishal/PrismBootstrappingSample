using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using FirstModule.ViewModel;

namespace FirstModule
{
    /// <summary>
    /// Interaction logic for FillMainRegion.xaml
    /// </summary>
    public partial class FillMainRegion : UserControl
    {
        public FillMainRegion()
        {
            InitializeComponent();
            this.DataContext = new TheFirstViewModel();
        }
    }
}
