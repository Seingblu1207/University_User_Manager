using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Asignatura
    {

        private string nombre = "";
        private uint grado;
        private List<Docente> l_docentes;

        public Asignatura(string nombre, uint grado)
        {
            this.nombre = nombre;
            this.grado = grado;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public uint Grado { get => grado; set => grado = value; }
        internal List<Docente> L_docentes { get => l_docentes;}



    }
}
