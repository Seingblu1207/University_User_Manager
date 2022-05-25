using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Historia
    {

        private uint año;
        private ushort periodo;
        private List<Evaluacion> l_evaluacion;


        public Historia(uint año, ushort periodo)
        {
            this.año = año;
            this.periodo = periodo;
        }

        public uint Año { get => año; set => año = value; }
        public List<Evaluacion> L_evaluacion { get => l_evaluacion; }
        public ushort Periodo { get => periodo; set => periodo = value; }
    }
}
