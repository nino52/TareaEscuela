﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaEscuela
{
    internal class Curso
    {
        public string Nombre { get; set; }
        public int RecuentoClases { get; set; }
        public int RecuentoEjercicios { get; set; }

        public Curso(string nombre, int recuentoClases, int recuentoEjercicios) 
        {
        
            Nombre = nombre;
            RecuentoClases = recuentoClases;
            RecuentoEjercicios = recuentoEjercicios;
        }
    }
}
