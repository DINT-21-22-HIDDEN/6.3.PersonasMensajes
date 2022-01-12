using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasMensajes
{
    class ConsultaPersonaUserControlVM : ObservableRecipient
    {
        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }

        public ConsultaPersonaUserControlVM()
        {
            PersonaSeleccionada = WeakReferenceMessenger.Default.Send<PersonaSeleccionadaMessage>();
        }
    }
}
