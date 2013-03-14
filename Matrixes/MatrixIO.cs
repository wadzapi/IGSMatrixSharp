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
        private const int defaultRowHeight = 20;//Высота строки
        private const int defaultColWidth = 20;//Ширина колонки

        //стандартный конструктор
        public MatrixGrid()
        {
            InitGrid(defaultRowsNum, defaultColsNum);
        }

        
        public MatrixGrid(int rowsNum, int colsNum)
        {
            InitGrid(rowsNum, colsNum);
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
            DataGridTextBoxColumn newCol = new DataGridTextBoxColumn();
            newCol.Width = defaultColWidth;

        }

        //изменение размера сетки
        public void Resize(int newRowsNum, int newColsNum)
        {
            while (newRowsNum > this.RowCount)
            {
                AddRow();
            }
            while (newRowsNum < this.RowCount)
            {
                this.Rows.RemoveAt(this.RowCount - 1);
            }
            while (newColsNum > this.ColumnCount)
            {
                AddColumn();
            }
            while (newColsNum < this.ColumnCount)
            {
                this.Columns.RemoveAt(this.ColumnCount - 1);
            }
        }

        //инициализация сетки
        private void InitGrid(int rowsNum, int colsNum)
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
            for (int r = 0; r < rowsNum; r++)
            {
                this.AddRow();
            }
            for (int c = 0; c < colsNum; c++)
            {
                this.AddColumn();
            }
            
        }

        //Очищение сетки
        private void Clear()
        {
            this.Columns.Clear();
            this.Rows.Clear();
        }

        public void FillNulls

        //Заполненине значениями матрицы
        public void FillCells(Matrix m)
        {
            //изменение размеров сетки
            int rows = m.rowsNum;
            int cols = m.colsNum;
            Resize(rows, cols);
            //Заполнение ячеек
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    this[r, c].Value = m[r, c];
                }
            }
        }

        //Чтение заданных пользователем значений
        public Matrix ReadCells()
        {
            int rows = this.RowCount;
            int cols = this.ColumnCount;
            Matrix m = null;
            if (rows > 0 && cols > 0)
            {
                m = new Matrix(rows, cols);
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; col++)
                    {
                        m[r, c] = Double.Parse(this[r, c].);
                    }
                }
            }
            return m;
        }
    }
}
