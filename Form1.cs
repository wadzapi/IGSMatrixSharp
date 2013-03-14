using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrixes
{
    public partial class Form1 : Form
    {
        private Matrix MatrixA;
        private Matrix MatrixB;
        private Matrix MatrixResult;
        private const int DefaultNumRows = 10;
        private const int DefaultNumCols = 10;


        public Form1()
        {
            InitializeComponent();
            InitMatrixes();
            this.dataGridView3.DataSource = MatrixA.Array;
            
        }

 

        private void InitMatrixes()
        {
            MatrixA = new Matrix(DefaultNumRows, DefaultNumCols);
            MatrixB = new Matrix(DefaultNumRows, DefaultNumCols);
            MatrixResult = new Matrix(DefaultNumRows, DefaultNumCols);
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
            /* Считывание числа столбцов и строк для  
             
            int rows = Int32.Parse(textBox1.Text);
            int cols = Int32.Parse(textBox2.Text);
            initGrid(this.dataGridView3, rows, cols);
            //Определение способа заполнения матриц
            switch (comboBox1.Text)
            {     
                case "":
                    MessageBox.Show("", "", MessageBoxButtons.OK);
                    break;
            }
             * */
        }
    }
}
