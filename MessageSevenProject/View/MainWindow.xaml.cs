using MahApps.Metro.Controls;
using MessageSevenProject.ViewModel;
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

namespace MessageSevenProject.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow(MainWindowViewModel Vm)
        {
            InitializeComponent();
            ViewModel = Vm;
        }

        public MainWindowViewModel ViewModel
        {
            get
            {
                return (MainWindowViewModel)this.DataContext;
            }
            set
            {
                this.DataContext = value;
            }
        }

    }
}
