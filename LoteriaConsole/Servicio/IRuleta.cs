using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LoteriaConsole.Servicio
{
    public interface IRuleta
    {
        [Required(ErrorMessage = "Debe digitar el ID de ruleta")]
        public int IDRuleta { get; set; }
        [Required(ErrorMessage = "Debe digitar la apertura de ruleta 0 cerrado diferente de 0 abierto")]
        public int Apertura { get; set; }
        public double CierreApuestas { get; set; }
        public string EstadoRuleta { get; set; }
        public List<int> ListaNumeros { get; set; }
        public string ApuestaRuleta(string TipoApuesta, int Numero, string color);
    }
}
