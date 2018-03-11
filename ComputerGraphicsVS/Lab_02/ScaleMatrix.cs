namespace Lab_02
{
    class ScaleMatrix2D : Matrix<double>
    {
        public ScaleMatrix2D(float kx, float ky) : base(3, 3)
        {
            FillMatrix(0);
            Data[0, 0] = kx;
            Data[1, 1] = ky;
            Data[2, 2] = 1;
        }

        public Vector2 Scale(Vector2 vec)
        {
            Matrix<double> col = FromVec2DCol(vec);
            col = Prod(this, col);
            return ToVec2(col);
        }

        public Vector2 ScaleFrom(Vector2 vec, double xc, double yc)
        {
            vec.X -= (float)xc;
            vec.Y -= (float) yc;
            Matrix<double> col = FromVec2DCol(vec);
            
            col = Prod(this, col);
            
            return new Vector2((float)(col[0, 0] + xc), (float)(col[1, 0] + yc));
        }

        public static Vector2 ScaleFromAnalitic(Vector2 vec,Vector2 from, Vector2 coeff)
        {
            return new Vector2(coeff.X * vec.X + (1 - coeff.X) * from.X, coeff.Y * vec.Y + (1 - coeff.Y) * from.Y);
        }
    }
}
