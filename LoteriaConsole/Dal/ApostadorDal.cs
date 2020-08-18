using LoteriaConsole.Clase;
using System;
using System.Collections.Generic;
using System.Text;

namespace LoteriaConsole.Dal
{
    public class ApostadorDal
    {
        public List<Apostador> ListaApostadores = new List<Apostador>();

        public int AddApostador(int IDApostador, string Nombre, double ValorApuesta, int NumeroApostar)
        {
            Apostador NewApostador = new Apostador
            {
                IDApostador = IDApostador,
                Nombre = Nombre,
                ValorApuesta = ValorApuesta,
                NumeroApostar = NumeroApostar
            };

            ListaApostadores.Add(NewApostador);

            return IDApostador;
        }

        public Apostador GetApostador(int idApostador)
        {
            Apostador FindApostador = new Apostador();
           
            if (ListaApostadores.Exists(x => x.IDApostador == idApostador))
            {
                FindApostador = ListaApostadores.Find(x => x.IDApostador == idApostador);
                return FindApostador;
            }
            else
            {
                return null;
            }
        }
    }
}
