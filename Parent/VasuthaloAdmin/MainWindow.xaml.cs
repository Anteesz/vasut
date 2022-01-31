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
using VasuthaloAlt;
using VasuthaloAlt.Model;
using VasuthaloAlt.Repository;

namespace VasuthaloAdmin
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VasuthaloContext vasuthaloContext = VasuthaloContext.Instance;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            _ = vasuthaloContext.Cities.Add(new City()
            {
                Name = "Varos 1"
            });
            _ = vasuthaloContext.SaveChanges();        
        }
    }
}
