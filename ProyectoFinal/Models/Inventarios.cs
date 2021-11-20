using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Models
{
    internal class Inventarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Proovedor { get; set; }
        public double Precio { get; set; }
        public double Peso { get; set; }
        public int Cajas { get; set; }

    }
}
