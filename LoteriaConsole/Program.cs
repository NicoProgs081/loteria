using System;
using System.Collections.ObjectModel;
using LoteriaConsole.Clase;
using LoteriaConsole.Servicio;
using LoteriaConsole.Dal;
using System.Collections.Generic;

namespace LoteriaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Apostador ApostadorPrueba = new Apostador();
            ApostadorDal ListaApostadoresDal = new ApostadorDal();

            int BuscarIdapostador;
            int numapostadores;

            Console.WriteLine();
            Console.WriteLine("Hello World!");

            Console.Write("Ingrese el numero de Apostadores ");
            numapostadores = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numapostadores; i++)
            {
                int validarvalor;
                int validarnumero;

                Console.WriteLine("Ingresar apostador!");
                Console.Write("Digite el ID del Apostador ");
                ApostadorPrueba.IDApostador = int.Parse(Console.ReadLine());

                Console.Write("Digite el nombre del Apostador ");
                ApostadorPrueba.Nombre = Console.ReadLine();

                Console.Write("Digite el Valor de la Apuesta ");
                ApostadorPrueba.ValorApuesta = double.Parse(Console.ReadLine());
                validarvalor = ApostadorPrueba.ValApuesta(ApostadorPrueba.ValorApuesta);
                if (validarvalor < 0)
                    Console.WriteLine("Error en el valor ingresado de la apuesta verifique por favor");

                Console.Write("Digite el Numero de la Apuesta ");
                ApostadorPrueba.NumeroApostar = int.Parse(Console.ReadLine());
                validarnumero = ApostadorPrueba.NumApostar(ApostadorPrueba.NumeroApostar);

                if (validarnumero < 0)
                    Console.WriteLine("Error en el valor ingresado del numero de la apuesta verifique por favor");

                if ((validarvalor == 0) && (validarnumero == 0))
                {
                    if (ListaApostadoresDal.AddApostador(ApostadorPrueba.IDApostador,
                                                     ApostadorPrueba.Nombre,
                                                     ApostadorPrueba.ValorApuesta,
                                                     ApostadorPrueba.NumeroApostar) != 0)
                        Console.Write("\nApostador Ingresado Correctacmente");
                }
                else
                {
                    Console.Write("\nFavor volver a Ingresar el apostador ");
                    i--;
                }                    
            }


            Console.WriteLine("Buscar el Apostador");
            Apostador FindApostador = new Apostador();            

            Console.Write("Digite el ID del Apostador ");
            BuscarIdapostador = int.Parse(Console.ReadLine());
            FindApostador = ListaApostadoresDal.GetApostador(BuscarIdapostador);

            if (FindApostador == null)
                Console.Write("Apostador no encontrado");
            else
                Console.Write("Apostador con nombre {0} encontrado", FindApostador.Nombre);

            //crear la mesa
            Ruleta Ruleta1 = new Ruleta();
            Ruleta1.IDRuleta = 1;
            Ruleta1.EstadoRuleta = "A";


        }
    }
}
