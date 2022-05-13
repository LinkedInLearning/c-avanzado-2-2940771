using System;
using System.Collections.Generic;
using System.Text;

namespace Avanzado2_2
{
    class DatosDesarrolloAttribute : System.Attribute
    {
        public DateTime fechaCreacion;
        public string equipo;

        public DatosDesarrolloAttribute(string equipo)
        {
            this.equipo = equipo;
            fechaCreacion = DateTime.Now;
        }
    }
}
