using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEscuela
{
    internal abstract class Persona

    {

        public String Nombre { get; set; }

        public Persona (String nombre)
        {

            Nombre = nombre;
        }
    }
}
