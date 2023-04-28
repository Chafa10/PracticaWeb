using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Carreras
    {
        public int Expediente { get; set; }
        public string Nombre { get; set; }
        public string Modalidad { get; set; }
        public int HorasTotales { get; set; }
        public bool EstadoDeLaCarrera { get; set; }
    }
}
