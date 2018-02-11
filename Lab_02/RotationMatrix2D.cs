using System;
using System.Runtime.CompilerServices;

namespace Lab_02
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

        public Vector2 Rotate(float x, float y)
        {
            return Rotate(new Vector2(x, y));
        }

        public Vector2 RotateAround(Vector2 vec, Vector2 pos)
        {
            vec.X -= pos.X;
            vec.Y -= pos.Y;
            vec = Rotate(vec);
            vec.X += pos.X;
            vec.Y += pos.Y;
            return vec;
        }

        public Vector2 RotateAround(float x, float y, float xc, float yc)
        {
            return RotateAround(new Vector2(x, y), new Vector2(xc, yc));
        }

        public float RotX(float x, float y)
        {
            Vector2 vec = new Vector2(x, y);
            return Rotate(vec).X;
        }

        public float RotY(float x, float y)
        {
            Vector2 vec = new Vector2(x, y);
            return Rotate(vec).Y;
        }

        public const double DegToRad =  Math.PI / 180.0f;
    }
}
