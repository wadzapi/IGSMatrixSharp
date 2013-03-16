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
            //Заполнение главной диагонали
            int maxIter = Math.Min(_rows, _cols);
            for (int i = 0; i < maxIter; i++)
            {
               matrixArray[i, i] = x;
            }
            //заполнение верхней наддиагонали
            maxIter = Math.Min(_rows - 1, _cols);
            for (int i = 0; i < maxIter; i++)
            {
                matrixArray[i+1, i] = x;
            }
            //заполнение нижней поддиагонали
            maxIter = Math.Min(_rows, _cols - 1);
            for (int i = 0; i < maxIter; i++)
            {
                matrixArray[i, i + 1] = x;
            }
        }
        

        public override void rndFill()
        {
            //Заполнение главной диагонали
            int maxIter = Math.Min(_rows, _cols);
            for (int i = 0; i < maxIter; i++)
            {
               matrixArray[i, i] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision);
            }
            //заполнение верхней наддиагонали
            maxIter = Math.Min(_rows - 1, _cols);
            for (int i = 0; i < maxIter; i++)
            {
                matrixArray[i+1, i] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision);
            }
            //заполнение нижней поддиагонали
            maxIter = Math.Min(_rows, _cols - 1);
            for (int i = 0; i < maxIter; i++)
            {
                matrixArray[i, i + 1] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision);
            }
        }
    }
}
