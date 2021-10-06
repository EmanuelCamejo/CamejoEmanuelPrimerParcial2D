using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Ciber
    {
        List<Cliente> clientes;
        List<Pc> computadoras;
        List<Cabina> cabinas;


        private Ciber()
        {
            clientes = new List<Cliente>();
            computadoras = new List<Pc>();
            cabinas = new List<Cabina>();
        }






        public static Ciber operator +(Cliente unCliente, Pc unaPc)
        {
            
        }



        
    }
}
