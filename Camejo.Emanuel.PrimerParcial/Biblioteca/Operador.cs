using System;

namespace Biblioteca
{
    public class Operador:Persona
    {
        
        private string usuario;
        private string pass;

        /// <summary>
        /// Constructor, donde inicializo los atributos de la clase base
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="dni"></param>
        /// <param name="usuario"></param>
        /// <param name="pass"></param>
        public Operador(string nombre,int dni,string usuario,string pass):base(nombre,dni)
        {
            this.usuario = usuario;
            this.pass = pass;
        }



    }
}
