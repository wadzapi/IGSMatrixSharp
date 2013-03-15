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

        private const int DefaultNumRows = 10;
        private const int DefaultNumCols = 10;
        //Сетки отображения матриц 
        private MatrixGrid MGridA;
        private MatrixGrid MGridB;
        private MatrixGrid MGridС;
        private TextBox ScalarResultBox;
        
        public Form1()
        {
            InitializeComponent();
            this.comboBox1.SelectedIndex = 0;
            InitMatrixGrids();
        }

        public void InitMatrixGrids()
        {
            //Добавление на форму окна отображения матрицы A
            MGridA = new MatrixGrid();
            MGridA.Location = new System.Drawing.Point(16, 143);
            MGridA.Name = "MGridA";
            MGridA.Size = new System.Drawing.Size(320, 220);
            this.Controls.Add(MGridA);
            //Добавление на форму окна отображения матрицы B
            MGridB = new MatrixGrid();
            MGridB.Location = new System.Drawing.Point(380, 142);
            MGridB.Name = "MGridA";
            MGridB.Size = new System.Drawing.Size(320, 220);
            this.Controls.Add(MGridB);
            //Добавление на форму окна отображения матрицы для вывода результатов
            MGridС = new MatrixGrid();
            MGridС.Location = new System.Drawing.Point(380, 382);
            MGridС.Name = "MGridA";
            MGridС.Size = new System.Drawing.Size(320, 220);
            MGridС.Visible = false;
            this.Controls.Add(MGridС);
            //Добавляем текстовое поле для вывода скалярной величины (напр. определителя)
            ScalarResultBox = new TextBox();
            ScalarResultBox.Location = new System.Drawing.Point(380, 382);
            ScalarResultBox.Visible = false;
            this.Controls.Add(ScalarResultBox);
        }

         private bool fillMatrix(out Matrix m)
        {
            m = null;
            int rows; //Число строк
            int cols; //Число столбцов
            if (Int32.TryParse(textBox1.Text, out rows) == false)
            {
                MessageBox.Show("В поле числа строк задан недопустимый символ!");
                return false;
            }
            if (Int32.TryParse(textBox2.Text, out cols) == false)
            {
                MessageBox.Show("В поле числа столбцов задан недопустимый символ!");
                return false;
            }
            switch (comboBox1.SelectedIndex)
            {
                case 0: 
                //Прямоугольная матрица
                    m = new Matrix(rows, cols);
                    break;
                case 1: 
                //Диагональная матрица
                    m = new DiagMatrix(rows, cols);
                    break;
                case 2:
                //Трехдиагональная матрица
                    m = new TridiagonalMatrix(rows, cols);
                    break;
                case 3:
                //Верхняя треугольная матрица
                    m = new UpTriangleMatrix(rows, cols);
                    break;
                case 4:
                //Нижняя треугольная матрица
                    m = new DownTriangleMatrix(rows, cols);
                    break;
            }
            //Определение способа заполнения матриц
            if (rows > 0 && cols > 0)
            {
                if (radioButton1.Checked)
                {
                    //ручное заполнение
                    m.constFill(0.0d);
                }
                else if (radioButton2.Checked)
                {
                    //заполнение случайным числом
                    m.rndFill();
                }
                else if (radioButton3.Checked)
                {
                    //заполнение заданным числом
                    double x;  //Число для заполнения матрицы
                    if (double.TryParse(textBox3.Text, out x))
                    {
                        m.constFill(x);
                    }
                    else
                    {
                        MessageBox.Show("В поле числа заполнения задан недопустимый символ!");
                        return false;
                    }
                }
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Matrix MatrixB;
            if (fillMatrix(out MatrixB))
                MGridB.FillCells(MatrixB);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Matrix MatrixA;
            if (fillMatrix(out MatrixA))
                MGridA.FillCells(MatrixA);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Matrix MatrixA = MGridA.ReadCells();
            Matrix MatrixB = MGridB.ReadCells();
            if (MatrixA != null)
            {
                if (radioButton9.Checked)
                {
                    //Определитель A
                    MGridС.Visible = false;
                    ScalarResultBox.Visible = true;
             
                    //ScalarResultBox.Text = Matrix.
                }
                else if (radioButton6.Checked)
                {
                    //Транспонировать A
                    MGridС.Visible = true;
                    ScalarResultBox.Visible = false;
                }
                else if (radioButton8.Checked)
                {
                    double k;
                    if (Double.TryParse(textBox5.Text, out k))
                    {
                        //Умножить A * k
                        MGridС.Visible = true;
                        ScalarResultBox.Visible = false;
                    }
                }
            }
            if (MatrixB != null)
            {
                if (radioButton11.Checked)
                {
                    //Определитель B
                    MGridС.Visible = false;
                    ScalarResultBox.Visible = true;
                }
                else if (radioButton12.Checked)
                {
                    //Транспонировать B
                    MGridС.Visible = true;
                    ScalarResultBox.Visible = false;
                }
                else if (radioButton13.Checked)
                {
                    double k;
                    if (Double.TryParse(textBox4.Text, out k))
                    {
                        //Умножить B * k
                        MGridС.Visible = true;
                        ScalarResultBox.Visible = false;
                    }
                }
            }
            if (MatrixA != null && MatrixB != null)
            {
                if (radioButton5.Checked)
                {
                    //Сложить A + B
                    MGridС.Visible = true;
                    ScalarResultBox.Visible = false;
                }
                else if (radioButton10.Checked)
                {
                    //Вычесть A - B
                    MGridС.Visible = true;
                    ScalarResultBox.Visible = false;
                }
                else if (radioButton4.Checked)
                {
                    //Умножить A*B
                    MGridС.Visible = true;
                    ScalarResultBox.Visible = false;
                }
                else if (radioButton7.Checked)
                {
                    //Умножить B*A
                    MGridС.Visible = true;
                    ScalarResultBox.Visible = false;
                }
            }
        }


    }
}
