using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraGrafica
{
   public class Operaciones
    {
        private string operacion;
        private string resultado;

        public string Operacion
        {
            get
            {
                return operacion;
            }

            set
            {
                operacion = value;
            }
        }

        public string Resultado
        {
            get
            {
                return resultado;
            }

            set
            {
                resultado = value;
            }
        }
    }
}
