using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes
{
    class Matrix
    {
        private int _rows;
        private int _cols;
        private double[,] matArray;

        public Matrix(int _rows, int _cols)
        {
            this._rows = _rows;
            this._cols = _cols;
            matArray = new double[_rows, _cols];
        }

        public double this[int rowIndex, int colIndex]
        {
            get
            {
                return matArray[rowIndex, colIndex];
            }
            set
            {
                matArray[rowIndex, colIndex] = value;
            }
        }

        public Matrix Minor(int colNum, int rowNum)
        {
            //нахождение минора матрицы
            int minorRows = _rows - 1;
            int minorCols = _cols - 1;
            Matrix minor = new Matrix(minorRows, minorCols);
            for (int row = 0; row < minorRows; row++)
            {
                for (int col = 0; col < minorCols; col++)
                {
                    ; ; ; ;////
                }
            }
            return minor;
        }

        public int colsNum
        {
            get
            {
                return _cols;
            }
        }

        public int rowsNum
        {
            get
            {
                return _cols;
            }
        }

        
    }
}
