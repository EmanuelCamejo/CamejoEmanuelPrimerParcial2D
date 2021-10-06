using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Pc:Negocio
    {
        public enum EHard
        {
            Microfono,Camara,Auricular
        }
        public enum ESoft 
        {
            Office2000,VisualBasic,ICQ
        }

        public enum EJuegos 
        {
            CounterStrick,AgeOfEmpires,Quake3Arena
        }

        public enum ESo
        {
            Windows2000, MacOSX
        }

        private string idPc;
        private string estadoPc;
        private EHard hard;
        private ESoft soft;
        private EJuegos juego;

        
        
    }
}
