using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes
{
    static class MatrixOperations
    {
        /*
         * Алгоритм транспонирования матриц
         */
        public static Matrix Transpose(Matrix m)
        {
            int rows = m.rowsNum;
            int cols = m.colsNum;
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
        public static Matrix Multiply(Matrix a, Matrix b)
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

        public static Matrix Multiply(Matrix a, double x)
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

        public static Matrix sum(Matrix a, Matrix b)
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

        public static Matrix substract(Matrix a, Matrix b)
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
                    for (int col = 0; col < cols; cols++)
                    {
                        Matrix minor = m.Minor(row, col);
                        det += Math.Pow(-1, row + col) * m[row, col] * Determinant(minor);
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
