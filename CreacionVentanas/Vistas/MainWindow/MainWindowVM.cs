using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CreacionVentanas.Mensajes;
using CreacionVentanas.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CreacionVentanas
{
    class MainWindowVM : ObservableObject
    {
        private ServicioNavegacion sn;
        public RelayCommand AbrirCommand { get; }

        public RelayCommand UC1Command { get; }
        public RelayCommand UC2Command { get; }
        public RelayCommand CambiarTextoCommand { get; }

        private UserControl contenidoMostrar;

        public UserControl ContenidoMostrar
        {
            get { return contenidoMostrar; }
            set { SetProperty(ref contenidoMostrar, value); }
        }


        public MainWindowVM()
        {
            AbrirCommand = new RelayCommand(AbrirVentanaHija);
            UC1Command = new RelayCommand(CargarUC1);
            UC2Command = new RelayCommand(CargarUC2);
            CambiarTextoCommand = new RelayCommand(CarmbiarTexto);
            sn = new ServicioNavegacion();
            
            WeakReferenceMessenger.Default.Register<MainWindowVM, TextoInicialRequestMessage>(this, (r, m) =>
            {
                m.Reply("Klk");
            });
            
        }

        public void AbrirVentanaHija()
        {
            sn.AbrirVentanaHija();
        }

        public void CargarUC1()
        {
            ContenidoMostrar = sn.CargaUC1();
        }

        public void CargarUC2()
        {
            ContenidoMostrar = sn.CargaUC2();
        }
        public void CarmbiarTexto()
        {
            WeakReferenceMessenger.Default.Send(new CambiarTextoValueChangedMessage("kesloke"));
        }
    }
}
