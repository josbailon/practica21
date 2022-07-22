using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Aplicaciones
    {
        public int IdJob { get; set; }

        public string NombreAplicacion { get; set; }

        public Aplicaciones(int IdJob, string NombreAplicacion)
        {
            this.IdJob = IdJob;
            this.NombreAplicacion = NombreAplicacion;
        }
    }
}
