using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Postgrado : Estudiante
    {

        private string[,] datos = new string[4, 5];

        public Postgrado(string nombre, uint id, uint fecha_nacimiento, string nombre_acudiente, string[,] datos) : base(nombre, id, fecha_nacimiento, nombre_acudiente)
        {
        }

        public string[,] Datos { get => datos; set => datos = value; }
    }
}
