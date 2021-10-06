using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Llamada : Cabina
    {
        private double valorExcedente;
        private int prefijo;
        private int numero;
        public const double costoLocal = 1;
        public const double costoLargaDistancia = 2.5;
        public const double costoInternacional = 5;

        

        public decimal CalcularPercioFinal(Cliente cliente, EtipoLlamada tipoLlamada)
        {
            decimal resultado = 0;

            return resultado;
        }

        public decimal CalcularCostoLlamada(Cabina unaCabina,)
        {
            
        }









    }
}
