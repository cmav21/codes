using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class elemento
    {
        private int numero;
        private elemento _siguiente;

        public int Numero
        {
            get { return numero; }
        }

        public elemento siguiente
        {
            set { _siguiente = value; }
            get { return _siguiente; }
        }

        public elemento(int valor)
        {
            this.numero = valor;
        }
    }
}
