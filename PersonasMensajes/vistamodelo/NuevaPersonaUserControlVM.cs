using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PersonasMensajes
{
    class NuevaPersonaUserControlVM : ObservableObject
    {
        private readonly NavigationService navegacion;

        private Persona nuevaPersona;

        public Persona NuevaPersona
        {
            get { return nuevaPersona; }
            set { SetProperty(ref nuevaPersona, value); }
        }

        private ObservableCollection<string> listaNacionalidades;

        public ObservableCollection<string> ListaNacionalidades
        {
            get { return listaNacionalidades; }
            set { SetProperty(ref listaNacionalidades, value); }
        }

        public RelayCommand AceptarNuevaPersonaCommand { get; }
        public RelayCommand NuevaNacionalidadCommand { get; }

        public NuevaPersonaUserControlVM()
        {
            navegacion = new NavigationService();
            NuevaPersona = new Persona();
            ListaNacionalidades = new ObservableCollection<string>() { "Italiana", "Española", "Francesa" };
            AceptarNuevaPersonaCommand = new RelayCommand(AñadirPersona);
            NuevaNacionalidadCommand = new RelayCommand(AñadirNacionalidad);
            WeakReferenceMessenger.Default.Register<NuevaNacionalidadMessage>(this, (r, m) =>
            {
                ListaNacionalidades.Add(m.Value);
            });
        }

        private void AñadirNacionalidad()
        {
            navegacion.AbrirDialogoNacionalidad();
        }

        private void AñadirPersona()
        {
            WeakReferenceMessenger.Default.Send(new NuevaPersonaMessage(NuevaPersona));
        }
    }
}
