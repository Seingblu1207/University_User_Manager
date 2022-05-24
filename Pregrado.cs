using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Pregrado : Estudiante
    {

        private string[] datos = new string[4];

        public Pregrado(string nombre, string id, string fecha_nacimiento, string nombre_acudiente, string[] datos) : base(nombre, id, fecha_nacimiento, nombre_acudiente)
        {
        }

        public string[] Datos { get => datos; set => datos = value; }
    }
}
