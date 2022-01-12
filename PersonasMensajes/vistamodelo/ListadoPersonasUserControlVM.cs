using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PersonasMensajes
{
    class ListadoPersonasUserControlVM : ObservableObject
    {
        private readonly PersonasService servicioPersonas;

        private ObservableCollection<Persona> listaPersonas;

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set { SetProperty(ref listaPersonas, value); }
        }

        private Persona personaSeleccionada;

        public Persona PersonaSeleccionada
        {
            get { return personaSeleccionada; }
            set { SetProperty(ref personaSeleccionada, value); }
        }

        public ListadoPersonasUserControlVM()
        {
            servicioPersonas = new PersonasService();
            ListaPersonas = servicioPersonas.ObtenerPersonas();
            WeakReferenceMessenger.Default.Register<NuevaPersonaMessage>(this, (r, m) =>
            {
                ListaPersonas.Add(m.Value);
            });

            WeakReferenceMessenger.Default.Register<ListadoPersonasUserControlVM, PersonaSeleccionadaMessage>(this, (r, m) =>
            {
                if (!m.HasReceivedResponse)
                    m.Reply(PersonaSeleccionada);
            });
        }
    }
}
