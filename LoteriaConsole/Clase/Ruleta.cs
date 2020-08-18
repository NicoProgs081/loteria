using LoteriaConsole.Servicio;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace LoteriaConsole.Clase
{

    public class Ruleta : IRuleta
    {
        public int IDRuleta { get; set; }
        public int Apertura { get; set; }
        public double CierreApuestas { get; set; }
        public string EstadoRuleta { get; set; }
        public List<int> ListaNumeros { get; set; }

        public string ApuestaRuleta(string TipoApuesta, int Numero, string color)
        {
            var rand = new Random();
            IDRuleta = Numero;
            int NumRuleta;

            if (TipoApuesta == "N")
            {
                NumRuleta = rand.Next(0, 36);
                if (NumRuleta == Numero)
                    return "Ruleta cae en Numero [" + Numero.ToString() + "]; a Ganado";
                else
                    return "Ruleta cae en Numero [" + Numero.ToString() + "]; a Perdido";
            }
            else
            {
                //NumRuleta = rand.Next(0, 36);
                string[] Colorruleta = { "Negro", "Rojo" };
                int mIndex = rand.Next(Colorruleta.Length);
                if (color == Colorruleta[mIndex])
                    return "Ruleta cae en el color [" + color + "]; a Ganado";
                else
                    return "Ruleta cae en el color [" + color + "] a Perdido";
            }
        }
    }
}
