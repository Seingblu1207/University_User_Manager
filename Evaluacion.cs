using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Evaluacion
    {

        private string estudiante;
        private string asignatura;
        private double nota_final;

        public Evaluacion(string estudiante, string asignatura, double nota_final)
        {
            this.estudiante = estudiante;
            this.asignatura = asignatura;
            this.nota_final = nota_final;
        }

        public double Nota_final { get => nota_final; set => nota_final = value; }
        internal string Estudiante { get => estudiante; set => estudiante = value; }
        internal string Asignatura { get => asignatura; set => asignatura = value; }
    }
}
