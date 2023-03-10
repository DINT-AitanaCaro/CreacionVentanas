using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Messaging;
using CreacionVentanas.Mensajes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionVentanas
{
    class UserControl1VM : ObservableRecipient
    {
        public string mensaje;
        public string Mensaje
        {
            get { return mensaje; }
            set { SetProperty(ref mensaje, value); }
        }

        public UserControl1VM()
        {
            Mensaje = WeakReferenceMessenger.Default.Send<TextoInicialRequestMessage>();
            WeakReferenceMessenger.Default.Register<CambiarTextoValueChangedMessage>(this, (r, m) =>
            {
                Mensaje = m.Value;
            });
        }
    }
}
