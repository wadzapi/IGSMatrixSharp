using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes
{
    class UpTriangleMatrix:Matrix
    {
        public UpTriangleMatrix(int rows, int cols): base(rows, cols)
        {

        }

        public override void constFill(double x)
        {
            int maxIter = Math.Min(_rows, _cols);
            for (int row = 0; row < maxIter; row++)
            {
                for (int col = row; col < _cols; col++)
                {
                    matrixArray[row, col] = x;
                }
            }
        }

        public override void rndFill()
        {
            int maxIter = Math.Min(_rows, _cols);
            for (int row = 0; row < maxIter; row++)
            {
                for (int col = row; col < _cols; col++)
                {
                    matrixArray[row, col] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision);
                }
            }
        }
    }
}
