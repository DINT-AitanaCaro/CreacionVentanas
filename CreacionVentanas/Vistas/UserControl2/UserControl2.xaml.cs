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

namespace CreacionVentanas
{
    /// <summary>
    /// Lógica de interacción para UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        private UserControl2VM vm;
        public UserControl2()
        {
            InitializeComponent();
            vm = new UserControl2VM();
            this.DataContext = vm;

        }
    }
}
