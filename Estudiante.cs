using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tercer_sistematico
{
    public class Estudiante
    {
        public String? Nombre { get; set; }
        public int[] Notas { get; set; }
        public double PromedioArregl()
        {
            double promedio = 0;
            for (int i = 0; i < Notas.Length; i++)
            {
                promedio += Notas[i];
            }
            promedio = promedio / Notas.Length;
            return promedio;
        }

    }
}
