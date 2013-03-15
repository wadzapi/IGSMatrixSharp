using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes
{
    class TridiagonalMatrix:Matrix
    {
        public TridiagonalMatrix(int rows, int cols)
            : base(rows, cols)
        {
        }

        public override void constFill(double x)
        {
            int minDim = Math.Min(_rows, _cols);
            //заполнение первой строки матрицы
            matrixArray[0, 0] = x;
            matrixArray[0, 1] = x;
            //заполнение последней строки матрицы
            matrixArray[minDim - 1, minDim - 2] = x;
            matrixArray[minDim - 1, minDim - 1] = x;
            for (int i = 1; i < minDim - 1; i++)
            {
                matrixArray[i, i - 1] = x;
                matrixArray[i, i] = x;
                matrixArray[i, i + 1] = x;
            }
        }

        public override void rndFill()
        {
            int minDim = Math.Min(_rows, _cols);
            //заполнение первой строки матрицы
            matrixArray[0, 0] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision); ;
            matrixArray[0, 1] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision); ;
            //заполнение последней строки матрицы
            matrixArray[minDim - 1, minDim - 2] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision);
            matrixArray[minDim - 1, minDim - 1] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision);
            for (int i = 1; i < minDim - 1; i++)
            {
                matrixArray[i, i - 1] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision);
                matrixArray[i, i] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision);
                matrixArray[i, i + 1 ] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision);
            }
        }
    }
}
