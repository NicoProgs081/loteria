using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using LoteriaConsole.Clase;

namespace LoteriaConsole.Servicio
{
    public interface IApostador
    {

        [Required(ErrorMessage = "Debe digitar el ID de persona")]
        public int IDApostador { get; set; }
        [Required(ErrorMessage = "Debe ingresar nombre de persona")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Debe ingresar el Valor de la apuesta")]
        public double ValorApuesta { get; set; }
        [Required(ErrorMessage = "Debe ingresar el numero a apostar")]
        public int NumeroApostar { get; set; }
        //Validar que el valor no sea mayor a mil dolares
        //validar el numero de 1 a 36
        public int ValApuesta(double Valor);
        public int NumApostar(double Valor);
        //public List<Apostador> apostador { get; set; }
    }
}
