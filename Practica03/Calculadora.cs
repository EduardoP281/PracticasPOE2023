using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica03
{
    internal class Calculadora
    {
        double num1, num2, resultado;

        public Calculadora(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double suma()
        {
            resultado = num1+ num2;
            return resultado;
        }
        public double resta()
        {
            resultado = num1 - num2;
            return resultado;
        }
        public double multiplicacion()
        {
            resultado = num1 * num2;
            return resultado;
        }
        public double division()
        {
            resultado = num1 / num2;
            return resultado;
        }
    }
}
