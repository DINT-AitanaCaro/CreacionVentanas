using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CreacionVentanas.Servicios
{
    class ServicioNavegacion
    {
        public bool? AbrirVentanaHija()
        {
            VentanaHija nueva = new VentanaHija();
            return nueva.ShowDialog();
        }

        public UserControl CargaUC1()
        {
            return new UserControl1();
        }

        public UserControl CargaUC2()
        {
            return new UserControl2();
        }
    }
}
