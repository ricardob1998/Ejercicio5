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
            int columna, fila;
            fila = int.Parse(FilatextBox.Text);
            columna = int.Parse(ColumnatextBox.Text);
            matriz = new int[fila, columna];
            dataGridView1.ColumnCount = columna;
            dataGridView1.RowCount = fila;

            for (int filas = 0; filas < matriz.GetLength(0); filas++)
            { 
                for (int col = 0; col < matriz.GetLength(1); col++)
                {
                    matriz[filas, col] = aletorio.Next(100);
                    
                }
            }

            for (int filas = 0; filas < matriz.GetLength(0); filas++)
            {
                for (int col = 0; col < matriz.GetLength(1); col++)
                {

                    dataGridView1.Rows[filas].Cells[col].Value = matriz[filas, col];
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilatextBox.Clear();
            ColumnatextBox.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
