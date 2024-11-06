using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPrestamo.Modelo
{
    public class Ahorro
    {
        public int IdCliente { get; set; }
        public decimal Monto { get; set; }
        public String Fecha { get; set; }
        public decimal TotalAhorrado { get; set; }
        public string Firma { get; set; }
        public int Multa { get; set; }
        public int IdTipoMoneda { get; set; }
    }
}
