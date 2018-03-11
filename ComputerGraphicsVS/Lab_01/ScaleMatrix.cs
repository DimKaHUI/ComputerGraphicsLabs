namespace Lab_01
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
            Matrix<double> col = FromVec2DCol(vec);
            TranslationMatrix translate = new TranslationMatrix(-xc, -yc);
            col = Prod(translate, col);
            col = Prod(this, col);
            col = Prod(translate.Inverse(), col);
            return new Vector2((float)col[0, 0], (float)col[1, 0]);
        }
    }
}
