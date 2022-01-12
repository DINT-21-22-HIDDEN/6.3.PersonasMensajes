using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PersonasMensajes
{
    class PersonasService
    {
        public ObservableCollection<Persona> ObtenerPersonas()
        {
            return new ObservableCollection<Persona> {
                new Persona("Pietro", 30, "Italiana"),
                new Persona("Julia", 25, "Española"),
                new Persona("Sophie", 35, "Francesa")
            };
        }
    }
}
