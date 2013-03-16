using System;


namespace Matrixes
{
    class DownTriangleMatrix: Matrix
    {
        public DownTriangleMatrix(int rows, int cols)
            : base(rows, cols)
        {
        }

        public override void constFill(double x)
        {
            int maxIter = Math.Min(_rows, _cols); 
            for (int row = 0; row < maxIter; row++)
            {
                for (int col = 0; col <= row; col++)
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
                for (int col = 0; col <= row; col++)
                {
                    matrixArray[row, col] = Math.Round(rnd.NextDouble() * MaxRndVal, MaxPrecision);
                }
            }
        }
    }
}
