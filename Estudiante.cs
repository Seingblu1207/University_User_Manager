using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    abstract class Estudiante : Miembro
    {

        private string nombre_acudiente;

        public Estudiante(string nombre, string id, string fecha_nacimiento, string nombre_acudiente) : base(nombre, id, fecha_nacimiento)
        {
        }
    }
}
