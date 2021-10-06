using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente:Persona
    {
        
        private int edad;
        private string estado;
        private Negocio necesidad;
        private DateTime horaInicio;
        private EtipoLlamada tipoDeLlamada;

      
        #region Enumerados
        /// <summary>
        /// Enumerador para saber que tipo de llamada necesita realizar el Cliente
        /// </summary>
        public enum EtipoLlamada
        {
            Local, LargaDistancia, Internacional
        };
        #endregion

        #region Constructores
        /// <summary>
        /// Contructor que me permite crear el cliente y que elija el tipo de pc que va a usar
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="dni"></param>
        /// <param name="edad"></param>
        /// <param name="pc"></param>
        public Cliente(string nombre, int dni, int edad, Pc pc) : base(nombre, dni)
        {
            this.edad = edad;
            this.estado = "recepcionado";
            this.horaInicio = DateTime.Now;
        }

        /// <summary>
        /// Contructor que me permite crear el cliente y que elija el tipo de cabina que va a usar
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="dni"></param>
        /// <param name="edad"></param>
        /// <param name="cabinna"></param>
        public Cliente(string nombre, int dni, int edad, Cabina cabinna, EtipoLlamada tipoDeLlamada) : base(nombre, dni)
        {
            this.tipoDeLlamada = tipoDeLlamada;
            this.edad = edad;
            this.estado = "recepcionado";
            this.horaInicio = DateTime.Now;
        }

        #endregion


        #region Metodos
        /// <summary>
        /// Calculo los minutos de espera, tomando el incio al ciber y cuanto toma control de algun servicio
        /// </summary>
        /// <param name="horaInicio"></param>
        /// <returns>Retorna la cantidad de minutos que estuvo en espera</returns>
        public int MinutosEnEspera(DateTime horaInicio)
        {
            int resultado = 0;
            if (estado != "recepcionado")
            {
                //int resultado = horaInicio - ///DateTime.Now; Me falta hacer la sobrecarga de operador -
            }
            return resultado;
        }
        #endregion




    }
}
