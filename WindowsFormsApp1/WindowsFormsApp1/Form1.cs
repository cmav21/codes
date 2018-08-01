using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        lifo lifo = new lifo();
        lista listaSimple = new lista();
        lista segundaLista = new lista();
        elemento elemento;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OrdenarDatosPila();
            textBox1.Text += "Primer pila " + listaSimple.Mostrar() + Environment.NewLine + 
                             "Segunda pila " + segundaLista.Mostrar() + Environment.NewLine;   
        }

        public void OrdenarDatosPila()
        {
            int valoresEnPila = lifo.pila1.Count;
            int valoresEnPila2 = lifo.pila2.Count;
            for(int i = 0; i < valoresEnPila; i++)
            {
                elemento = new elemento(lifo.pila1.Pop());
                listaSimple.Agregar(elemento);
            }

            for (int i = 0; i < valoresEnPila2; i++)
            {
                elemento = new elemento(lifo.pila2.Pop());
                segundaLista.Agregar(elemento);
            }
        }
    }
}
