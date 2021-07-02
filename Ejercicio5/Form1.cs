using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random aletorio = new Random();
            int[,] matriz;
            int fila, columna;
            fila = int.Parse(FilatextBox.Text);
            columna = int.Parse(ColumnatextBox.Text);
            matriz = new int[fila, columna];

            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz.Length; j++)
                {
                    matriz[i, j] = aletorio.Next(100);
                }
            }
            NumerosAletorioslistBox.Items.Add(matriz);
        }
    }
}
