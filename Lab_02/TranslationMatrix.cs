namespace Lab_02
{
    class TranslationMatrix : Matrix<double>
    {
        public TranslationMatrix(double dx, double dy) : base(3, 3)
        {
            FillMatrix(0);
            FillDiagonal(1);
            Data[0, 2] = dx;
            Data[1, 2] = dy;
        }

        public TranslationMatrix Inverse()
        {
            TranslationMatrix t = (TranslationMatrix) Clone();
            t[0, 2] *= -1;
            t[1, 2] *= -1;
            return t;
        }
    }
}
