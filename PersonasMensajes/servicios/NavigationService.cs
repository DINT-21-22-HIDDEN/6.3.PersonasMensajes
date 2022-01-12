using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;

namespace PersonasMensajes
{
    class NavigationService
    {
        private static UserControl listadoPersonas = new ListadoPersonasUserControl();

        public NavigationService()
        {
            
        }

        public UserControl ObtenerNuevaPersona()
        {
            return new NuevaPersonaUserControl();
        }

        public UserControl ObtenerListadoPersonas()
        {
            return listadoPersonas;
        }

        public bool? AbrirDialogoNacionalidad()
        {
            DialogoNacionalidad dialogo = new DialogoNacionalidad();
            return dialogo.ShowDialog();
        }

        internal UserControl ObtenerConsultaPersona()
        {
            return new ConsultaPersonaUserControl();
        }
    }
}
