using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones_con_objetos
{
    class Persona
    {
        string dpi;
        string nombre;
        string apellido;
        DateTime fechaNacimiento;

        public string Dpi { get { return dpi; } set { dpi = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public DateTime Fechanacimiento { get { return fechaNacimiento; } set { fechaNacimiento = value; } }

    }
}