﻿using System.Collections.Generic;
using System.Linq;

namespace Opiniometro_WebApp.Models
{
    public class AsignarPeriodoViewModel
    {
        // Lista de grupos
        public IEnumerable<Grupo> Grupos { get; set; }

        // Lista de formularios
        public IEnumerable<Formulario> Formularios { get; set; }
    }

}