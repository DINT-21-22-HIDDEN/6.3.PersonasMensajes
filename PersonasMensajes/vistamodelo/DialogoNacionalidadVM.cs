using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasMensajes
{
    class DialogoNacionalidadVM : ObservableObject
    {
        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }


        public DialogoNacionalidadVM()
        {

        }

        public void Aceptar()
        {
            //Aquí incluiremos la lógica necesaria cuando se pulse el botón aceptar
            WeakReferenceMessenger.Default.Send(new NuevaNacionalidadMessage(Nacionalidad));
        }
    }
}
