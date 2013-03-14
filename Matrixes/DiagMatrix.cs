using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrixes
{
    class DiagMatrix:Matrix
    {
        public DiagMatrix(int cols, int rows)
            : base(cols, rows)
        {
        }


        public override void constFill(double x)
        {
            int minDim = Math.Min(_rows, _cols);
            for (int i = 0; i < minDim; i++)
            {
                matrixArray[i, i] = x;
            }
        }

        public override void rndFill()
        {
            int minDim = Math.Min(this.rowsNum, this.colsNum);
            for (int i = 0; i < minDim; i++)
            {
                matrixArray[i, i] = rnd.NextDouble() * Matrix.MaxRndVal;
            }
        }
    }
}
