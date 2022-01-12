using Microsoft.Toolkit.Mvvm.Messaging.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasMensajes
{
    public class NuevaNacionalidadMessage : ValueChangedMessage<string>
    {
        public NuevaNacionalidadMessage(string nuevaNacionalidad) : base(nuevaNacionalidad) { }
    }

    public class NuevaPersonaMessage : ValueChangedMessage<Persona>
    {
        public NuevaPersonaMessage(Persona nuevaPersona) : base(nuevaPersona) { }
    }

    public class PersonaSeleccionadaMessage : RequestMessage<Persona> { }
}
