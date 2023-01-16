using CommunityToolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreacionVentanas.Mensajes
{
    public class CambiarTextoValueChangedMessage : ValueChangedMessage<string>
    {
        public CambiarTextoValueChangedMessage(string texto) : base(texto) { }
    }
}
