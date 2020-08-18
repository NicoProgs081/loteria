using System;
using System.Collections.Generic;
using System.Text;
using LoteriaConsole.Servicio;

namespace LoteriaConsole.Clase
{
    public class Apostador : IApostador
    {        
        public int IDApostador { get; set; }
        public string Nombre { get; set; }
        public double ValorApuesta { get; set; }
        public int NumeroApostar { get; set; }

        public int NumApostar(double Valor)
        {
            if (Valor > 36)
                return -1;
            else
            if (Valor < 0)
                return -2;
            else
                return 0;
        }

        public int ValApuesta(double Valor)
        {
            if (Valor > 10000)
                return - 1;
            else
            if (Valor <= 0)
                return - 2;
            else
                return 0;   
        }
    }
}
