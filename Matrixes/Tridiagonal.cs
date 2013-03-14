using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes
{
    class Tridiagonal:Matrix
    {
        public Tridiagonal(int rows, int cols)
            : base(rows, cols)
        {
        }

        public override void constFill(double x)
        {
            int minDim = Math.Min(_rows, _cols);
            for (int i = 1; i < minDim - 1; i++)
            {
                matrixArray[i - 1, i - 1] = x;
                matrixArray[i, i] = x;
                matrixArray[i, i + 1] = x;
            }
        }

        public override void rndFill()
        {
            int minDim = Math.Min(_rows, _cols);
            for (int i = 1; i < minDim - 1; i++)
            {
                matrixArray[i - 1, i - 1] = rnd.NextDouble() * Matrix.MaxRndVal;
                matrixArray[i, i] = rnd.NextDouble() * Matrix.MaxRndVal;
                matrixArray[i, i + 1] = rnd.NextDouble() * Matrix.MaxRndVal;
            }
        }
    }
}
