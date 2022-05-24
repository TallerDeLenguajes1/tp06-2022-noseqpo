using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP6
{
    

    public class Calculadora
    {
        private double operado;

        public Calculadora(double operado)
        {
            this.operado = operado;
        }

        public void Mostrar()
        {
            Console.WriteLine("\nEl valor actual es: ");
            Console.WriteLine(operado);
        }

        public void Limpiar()
        {
            this.operado = 0;
        }

        public static double Solicitar()
        {
            Console.WriteLine("\nIngrese un valor: ");
            double temp = Convert.ToDouble(Console.ReadLine());
            return temp;
        }

        public double Sumar(double termino)
        {
            operado += termino;
            return operado;
        }

        public double Restar(double termino)
        {
            operado -= termino;
            return operado;
        }
        public double Muktiplicar(double termino)
        {
            operado *= termino;
            return operado;
        }
        public double Dividir(double termino)
        {
            operado /= termino;
            return operado;
        }

    }
}
