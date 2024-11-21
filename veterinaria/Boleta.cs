using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veterinaria
{
    public class Boleta
    {
        public int Codigo { get; set; }
        public Mascota Mascota { get; set; }
        public Servicio Servicio1 { get; set; }
        public Servicio Servicio2 { get; set; }
        public double Total { get; set; }
    }
}
