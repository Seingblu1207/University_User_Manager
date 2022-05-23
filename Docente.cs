using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Docente : Miembro
    {

        private List<String> l_titulos;
        private string area = "";

        public Docente(string nombre, uint id, uint fecha_nacimiento) : base(nombre, id, fecha_nacimiento)
        {
        }

        public List<string> L_titulos { get => l_titulos;}
        public string Area { get => area; set => area = value; }
    }
}
