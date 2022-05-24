using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    abstract class Miembro
    {

        private string nombre;
        private string id;
        private string fecha_nacimiento;
        

        Institucion Aguardiente = new Institucion();

        public Miembro(string nombre, string id, string fecha_nacimiento)
        {
        }
    }
}
