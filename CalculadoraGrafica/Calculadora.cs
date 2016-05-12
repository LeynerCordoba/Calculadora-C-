using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraGrafica
{
    class Calculadora
    {
        private int numero_uno { get; set; }
        private int numero_dos { get; set; }

        public Calculadora() {
            numero_dos = 0;
            numero_uno = 0;
        }

        public int Sumar(int num1, int num2) {
            int resultado = num1 + num2;
            return resultado;
        }

        public int Restar(int num1, int num2)
        {
            int resultado = num1 - num2;
            return resultado;
        }

        public int Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            return resultado;
        }

        public int Dividir(int num1, int num2)
        {
            int resultado = num1 / num2;
            return resultado;
        }
    }

}
