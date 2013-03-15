using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes
{
    class Matrix
    {
        protected int _rows;
        protected int _cols;
        protected double[,] matrixArray;
        protected Random rnd;
        public double MaxRndVal = 100.0d;//Максимальное значение случайного числа
        public int MaxPrecision = 1; //Число знаков после запятой

        public Matrix(int rows, int cols)
        {
            this._rows = rows;
            this._cols = cols;
            matrixArray = new double[_rows, _cols];
            rnd = new Random();
            initElemets();
        }

        //инициализация элементов массива нулями
        protected virtual void initElemets()
        {
            for (int r = 0; r < _rows; r++)
            {
                for (int c = 0; c < _cols; c++)
                {
                    matrixArray[r, c] = 0;
                }
            }
        }

        public double this[int rowIndex, int colIndex]
        {
            get
            {
                return matrixArray[rowIndex, colIndex];
            }
            set
            {
                matrixArray[rowIndex, colIndex] = value;
            }
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
                return _rows;
            }
        }

        public double[,] Array
        {
            get
            {
                return this.matrixArray;
            }
            set
            //установка значений массива матрицы
            {

                if (value.GetLength(0) == matrixArray.GetLength(0) && value.GetLength(1) == matrixArray.GetLength(1))
                {
                    for (int r = 0; r < _rows; r++)
                    {
                        for (int c = 0; c < _cols; c++)
                        {
                            matrixArray[r, c] = value[r, c];
                        }
                    }
                }
                else
                {
                    throw new MatrixException("Размерность массива-аргумента должна совпадать с размерностью матрицы!!");
                }
            }
        }


        public virtual void rndFill()
        {
            for (int r = 0; r < _rows; r++)
            {
                for (int c = 0; c < _cols; c++)
                {
                    matrixArray[r, c] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision);
                }
            }
        }

        public virtual void constFill(double x)
        {
            for (int r = 0; r < _rows; r++)
            {
                for (int c = 0; c < _cols; c++)
                {
                    matrixArray[r, c] = x;
                }
            }
        }



        //нахождение минора матрицы
        public static Matrix Minor(Matrix m, int rowNum, int colNum)
        {
            int minorRows = m.rowsNum - 1;
            int minorCols = m.colsNum - 1;
            Matrix minor = new Matrix(minorRows, minorCols);
            int ri = 0;
            int ci = 0;
            for (int row = 0; row < minorRows; row++)
            {
                if (row == rowNum)
                    ri++;
                ci = 0;
                for (int col = 0; col < minorCols; col++)
                {
                    if (col == colNum)
                        ci++;
                    minor[row, col] = m[ri, ci];
                    ci++;
                }
                ri++;
            }
            return minor;
        }

        /*
         * Алгоритм транспонирования матриц
         */
        public static Matrix Transpose(Matrix m)
        {
            int rows = m.colsNum;
            int cols = m.rowsNum;
            Matrix transp = new Matrix(rows, cols);
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    transp[r, c] = m[c, r];
                }
            }
            return transp;
        }

        /*
         *  Стандартный алгоритма умножения матриц
         */
        public static Matrix operator *(Matrix a, Matrix b)
        {
            Matrix product = null;
            if (a.colsNum == b.rowsNum)
            {
                int rowsNum = a.rowsNum;
                int colsNum = b.colsNum;
                int kMax = a.colsNum;
                product = new Matrix(rowsNum, colsNum);
                for (int r = 0; r < rowsNum; r++)
                {
                    for (int c = 0; c < colsNum; c++)
                    {
                        product[r, c] = 0d;
                        for (int k = 0; k < kMax; k++)
                        {
                            product[r, c] += a[r, k] * b[k, c];
                        }
                    }
                }
            }
            else
            {
                throw new MatrixException("Умножение матриц невозможно! Число столбцов первой матрицы должно совпадать с числом строк во второй.");
            }
            return product;
        }

        public static Matrix operator *(Matrix a, double x)
        {
            int rowsNum = a.rowsNum;
            int colsNum = a.colsNum;
            Matrix product = new Matrix(rowsNum, colsNum);
            for (int r = 0; r < rowsNum; r++)
            {
                for (int c = 0; c < colsNum; c++)
                {
                    product[r, c] = a[r, c] * x;
                }
            }
            return product;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix sumMatr = null;
            if (a.colsNum == b.colsNum && a.rowsNum == b.rowsNum)
            {
                int rows = a.rowsNum;
                int cols = a.colsNum;
                sumMatr = new Matrix(rows, cols);
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        sumMatr[r, c] = a[r, c] + b[r, c];
                    }
                }
            }
            else
            {
                throw new MatrixException("Сложение невозможно! Размерности слагаемых матриц должны совпадать.");
            }
            return sumMatr;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix substrMatr;
            if (a.colsNum == b.colsNum && a.rowsNum == b.rowsNum)
            {
                int rows = a.rowsNum;
                int cols = a.colsNum;
                substrMatr = new Matrix(rows, cols);
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        substrMatr[r, c] = a[r, c] - b[r, c];
                    }
                }
            }
            else
            {
                throw new MatrixException("Вычитаение невозможно! Размерности вычитаемых матриц должны совпадать.");
            }
            return substrMatr;
        }

        /*
         *  Вычисление определителя матрицы, согласно теореме Лапласа
         *  Th. Лапласа: Определитель квадратной матрицы раверн сумме произведений элементов 
         *  любой строки(столбца) на их алгебраические дополнения
         */
        public static double Determinant(Matrix m)
        {
            double det = 0d;
            int rows = m.rowsNum;
            int cols = m.colsNum;
            if (rows == cols)
            {
                if (rows == 1)
                {
                    det = m[0, 0];
                }
                else if (rows == 2)
                {
                    det = m[0, 0] * m[1, 1] - m[1, 0] * m[0, 1];
                }

                else
                {
                    //Нахождение определителя разложением по Th. Лапласа по элементам первой строки
                    int row = 0;
                    for (int col = 0; col < cols; col++)
                    {
                        Matrix minor = Minor(m, row, col);
                        det += Math.Pow(-1, 2 + row + col) * m[row, col] * Determinant(minor);
                    }
                }
            }
            else
            {
                throw new MatrixException("Невозможно вычислить определитель. Для вычисления определителя матрица должна быть квадратной.");
            }
            return det;
        }
    }
}
