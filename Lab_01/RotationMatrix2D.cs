using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    class RotationMatrix2D :Matrix<double>
    {
        public RotationMatrix2D(float angle) : base(3, 3)
        {
            FillMatrix(0);
            FillDiagonal(1);
            this[0, 0] = Math.Cos(angle);
            this[0, 1] = Math.Sin(angle);
            this[1, 0] = -this[0, 1];
            this[1, 1] = this[0, 0];
        }

        public Vector2 Rotate(Vector2 vec)
        {
            Matrix<double> col = FromVec2DCol(vec);
            return ToVec2(Prod(this, col));
        }
    }
}
