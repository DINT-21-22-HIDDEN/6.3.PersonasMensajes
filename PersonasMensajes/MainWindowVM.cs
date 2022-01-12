using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace PersonasMensajes
{
    class MainWindowVM : ObservableObject
    {
        private readonly NavigationService navegacion;

        public RelayCommand AbrirNuevaPersonaCommand { get; }
        public RelayCommand AbrirListadoPersonasCommand { get; }
        public RelayCommand AbrirConsultaPersonaCommand { get; }

        private UserControl contenidoVentana;

        public UserControl ContenidoVentana
        {
            get { return contenidoVentana; }
            set { SetProperty(ref contenidoVentana, value); }
        }


        public MainWindowVM()
        {
            navegacion = new NavigationService();

            AbrirListadoPersonasCommand = new RelayCommand(AbrirListadoPersonas);
            AbrirNuevaPersonaCommand = new RelayCommand(AbrirNuevaPersona);
            AbrirConsultaPersonaCommand = new RelayCommand(AbrirConsultaPersona);
        }

        private void AbrirConsultaPersona()
        {
            ContenidoVentana = navegacion.ObtenerConsultaPersona();
        }

        private void AbrirNuevaPersona()
        {
            ContenidoVentana = navegacion.ObtenerNuevaPersona();
        }

        private void AbrirListadoPersonas()
        {
            ContenidoVentana = navegacion.ObtenerListadoPersonas();
        }
    }
}
