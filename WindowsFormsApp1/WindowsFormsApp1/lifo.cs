using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class lifo
    {
        public Stack<int> pila1 = new Stack<int>();
        public Stack<int> pila2 = new Stack<int>();
        private static Random aleatorio;

        public lifo()
        {
            aleatorio = new Random();
            GenerarElementos();   
        }

        private void GenerarElementos()
        {
            int incremento = 1;
            int valor = 0;
            int elementosEnPila1 = pila1.Count;
            int elementosEnPila2 = pila2.Count;
            for (int i = 0; i < 100; i++)
            {
                valor = aleatorio.Next(0, 10 + incremento);
               if(elementosEnPila1 == 0)
                {
                    pila1.Push(valor);
                    incremento += 2;
                    elementosEnPila1++;
                }
                else if (pila1.Peek() < valor)
                {
                    pila1.Push(valor);
                    incremento += 2;
                }    
            }

            for (int i = 0; i < 100; i++)
            {
                valor = aleatorio.Next(0, 10 + incremento);
                if (elementosEnPila2 == 0)
                {
                    pila2.Push(valor);
                    incremento += 2;
                    elementosEnPila2++;
                }
                else if (pila2.Peek() < valor)
                {
                    pila2.Push(valor);
                    incremento += 2;
                }
            }
        }
    }
}
