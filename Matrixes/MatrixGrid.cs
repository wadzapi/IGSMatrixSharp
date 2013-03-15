using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matrixes
{
    class MatrixGrid : DataGridView
    {
        private const int defaultColsNum = 10; //Число столбцов по умолчанию
        private const int defaultRowsNum = 10;//Число строк по умолчанию
        private const int defaultRowHeight = 30;//Высота строки
        private const int defaultColWidth = 30;//Ширина колонки

        //стандартный конструктор
        public MatrixGrid():base()
        {
            InitGrid();
        }

        
        public MatrixGrid(int rowsNum, int colsNum):base()
        {
            InitGrid();
            this.ResizeMatrix(rowsNum, colsNum);
        }

        //добавление строки
        public void AddRow()
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Height = defaultRowHeight;
            newRow.Resizable = DataGridViewTriState.False;
            this.Rows.Add(newRow);
        }

        //добавление колонки
        public void AddColumn()
        {
            DataGridViewColumn newCol = new DataGridViewColumn();
            newCol.Width = defaultColWidth;
            newCol.CellTemplate = new DataGridViewTextBoxCell();
            this.Columns.Add(newCol);


        }

        public int RowsNum
        {
            get
            {
                return this.RowCount;
            }
            set
            {
                while (value > this.RowCount)
                {
                    AddRow();
                }
                while (value < this.RowCount)
                {
                    this.Rows.RemoveAt(this.RowCount - 1);
                }
            }
        }

        public int ColsNum
        {
            get
            {
                return this.ColumnCount;
            }
            set
            {
                while (value > this.ColumnCount)
                {
                    AddColumn();
                }
                while (value < this.ColumnCount)
                {
                    this.Columns.RemoveAt(this.ColumnCount - 1);
                }
            }
        }

        //изменение размера сетки
        public void ResizeMatrix(int newRowsNum, int newColsNum)
        {
            this.ColsNum = newColsNum;
            this.RowsNum = newRowsNum;
        }

        //инициализация сетки
        private void InitGrid()
        {
            this.AllowUserToDeleteRows = false;
            this.AllowUserToAddRows = false;
            this.AllowUserToResizeRows = false;
            this.AllowUserToResizeColumns = false;
            this.EnableHeadersVisualStyles = false;
            this.EditMode = DataGridViewEditMode.EditOnKeystroke;
            this.RowHeadersVisible = false;
            this.ColumnHeadersVisible = false;
            this.SelectionMode = DataGridViewSelectionMode.CellSelect;
        }

        //Очищение сетки
        private void Clear()
        {
            this.Columns.Clear();
            this.Rows.Clear();
        }

        //Заполненине значениями матрицы
        public void FillCells(Matrix m)
        {
            //изменение размеров сетки
            int rows = m.rowsNum;
            int cols = m.colsNum;
            ResizeMatrix(rows, cols);
            //Заполнение ячеек
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    this[c, r].Value = m[r, c];
                }
            }
        }

        //Чтение заданных пользователем значений
        public Matrix ReadCells()
        {
            int rows = this.RowCount;
            int cols = this.ColumnCount;
            Matrix m = null;
            try
            {
                if (rows > 0 && cols > 0)
                {
                    m = new Matrix(rows, cols);
                    for (int r = 0; r < rows; r++)
                    {
                        for (int c = 0; c < cols; c++)
                        {
                            m[r, c] = Double.Parse(this[c, r].Value.ToString());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                if (e is NullReferenceException || e is ArgumentNullException)
                    MessageBox.Show("В матрице есть незаполненные поля");
                if (e is FormatException)
                    MessageBox.Show("В поле матрицы введен недопустимый символ");
                if (e is OverflowException)
                    MessageBox.Show("Ошибка переполнения переменной!");
                return null;
            }
            return m;
        }
    }
}
