using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Persona
    {
        private string nombre;
        private int dni;

        public Persona(string nombre,int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        
    }
}
