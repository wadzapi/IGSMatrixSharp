using System;


namespace Matrixes.Matrixes
{
    class DownTriangleMatrix: Matrix
    {
        public DownTriangleMatrix(int rows, int cols)
            : base(rows, cols)
        {
        }

        public override void constFill(double x)
        {
            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    matrixArray[row, col] = x;
                }
            }
        }

        public override void rndFill()
        {
            for (int row = 0; row < _rows; row++)
            {
                for (int col = 0; col <= row; col++)
                {
                    matrixArray[row, col] = rnd.NextDouble();
                }
            }
        }
    }
}
