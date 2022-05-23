using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Evaluacion
    {

        private Estudiante estudiante;
        private Asignatura asignatura;
        private double nota_final;

        public Evaluacion(Estudiante estudiante, Asignatura asignatura, double nota_final)
        {
            this.estudiante = estudiante;
            this.asignatura = asignatura;
            this.nota_final = nota_final;
        }

        public double Nota_final { get => nota_final; set => nota_final = value; }
        internal Estudiante Estudiante { get => estudiante; set => estudiante = value; }
        internal Asignatura Asignatura { get => asignatura; set => asignatura = value; }
    }
}
