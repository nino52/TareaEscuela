using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEscuela
{
    internal class Estudiante : Persona
    {

        public int NumeroUnico {  get; set; }

        public Estudiante (string nombre, int numero) : base (nombre)
        {
            NumeroUnico = NumeroUnico;
        }
    }
}
