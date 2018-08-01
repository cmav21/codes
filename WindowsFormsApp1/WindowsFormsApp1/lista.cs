using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class lista
    {
        elemento inicio;

        public void Agregar(elemento nuevo)
        {
            if(inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Agregar(inicio, nuevo);
            }
        }

        public void Agregar(elemento posicion, elemento nuevo)
        {
            if(posicion.siguiente != null)
            {
                Agregar(posicion.siguiente, nuevo);
            }
            else
            {
                posicion.siguiente = nuevo;
            }
        }

        public string Mostrar()
        {
            string cadena = "";
            elemento temp = inicio;
            while(temp.siguiente != null)
            {
                cadena += temp.Numero + ", ";
                temp = temp.siguiente;
            }
            cadena += temp.Numero;

            return cadena;
        }

    }
}
