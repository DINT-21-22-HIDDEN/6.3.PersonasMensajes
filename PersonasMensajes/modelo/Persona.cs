using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonasMensajes
{
    public class Persona : ObservableObject
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private int? edad;

        public int? Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }

        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public Persona()
        {
        }

        public Persona(string nombre, int edad, string nacionalidad)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.nacionalidad = nacionalidad;
        }
    }
}
