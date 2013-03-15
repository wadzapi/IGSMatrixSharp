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
            for (int row = 0; row < rowsNum; row++)
            {
                for (int col = row; col < _cols; col++)
                {
                    matrixArray[row, col] = x;
                }
            }
        }

        public override void rndFill()
        {
            for (int row = 0; row < rowsNum; row++)
            {
                for (int col = row; col < _cols; col++)
                {
                    matrixArray[row, col] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision);
                }
            }
        }
    }
}
