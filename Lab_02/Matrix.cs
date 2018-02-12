using System;

namespace Lab_02
{
    public class MatrixOperationException : Exception
    {
        public MatrixOperationException(string message) : base(message)
        {
            
        }
    }

    public class MatrixProductException : MatrixOperationException
    {
        public MatrixProductException(string message, Matrix<double> a,  Matrix<double> b)
            : base(message + "a.cols must be equal to b.rows; a.cols = " + a.Cols + " and b.rows = " + b.Rows)
        {
        }
    }

    public struct Vector2
    {
        public float X, Y;

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
    public struct Vector3
    {
        public float X, Y, Z;

        public Vector3(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

    public class Matrix<T>: ICloneable  where T : struct, IComparable 
    {

        protected readonly uint _rows;
        protected readonly uint _cols;
        protected readonly T[,] Data;

        public uint Rows
        {
            get { return _rows; }
        }
        public uint Cols
        {
            get { return _cols; }
        }
        

        public Matrix(uint rows, uint cols)
        {
            _rows = rows;
            _cols = cols;
            Data = new T[rows, cols];
        }

        public static Matrix<T> GetFilledMatrix(uint rows, uint cols, T filler)
        {
            Matrix<T> result = new Matrix<T>(rows, cols);
            for(uint i = 0; i < rows; i++)
            for (uint j = 0; j < cols; j++)
                result[i, j] = filler;
            return result;
        }

        public static void GetFilledMatrix(Matrix<T> matrix, T filler)
        {
            for (uint i = 0; i < matrix.Rows; i++)
                for (uint j = 0; j < matrix.Cols; j++)
                    matrix[i, j] = filler;
        }

        public void FillMatrix(T filler)
        {
            for (uint i = 0; i < Rows; i++)
            for (uint j = 0; j < Cols; j++)
                this[i, j] = filler;
        }

        public static Matrix<T> GetDiagonalMatrix(uint size, T filler)
        {
            Matrix<T> result = new Matrix<T>(size, size);
            for (uint i = 0; i < size; i++)
                result[i, i] = filler;
            return result;
        }

        public static void FillDiagonal(Matrix<T> matrix, T filler)
        {
            for (uint i = 0; i < matrix.Rows; i++)
                matrix[i, i] = filler;
        }

        public void FillDiagonal(T filler)
        {
            for (uint i = 0; i < Rows; i++)
                Data[i, i] = filler;
        }

        public static Matrix<double> FromVec2DCol(Vector2 vec)
        {
            Matrix<double> matrix = new Matrix<double>(3, 1);
            matrix[0, 0] = vec.X;
            matrix[1, 0] = vec.Y;
            matrix[2, 0] = 1;
            return matrix;
        }
        public static Matrix<double> FromVec3DCol3(Vector3 vec)
        {
            Matrix<double> matrix = new Matrix<double>(3, 1);
            matrix[0, 0] = vec.X;
            matrix[1, 0] = vec.Y;
            matrix[2, 0] = vec.Y;
            return matrix;
        }

        public static Matrix<double> FromVec3DCol(Vector3 vec)
        {
            Matrix<double> matrix = new Matrix<double>(4, 1);
            matrix[0, 0] = vec.X;
            matrix[1, 0] = vec.Y;
            matrix[2, 0] = vec.Y;
            matrix[3, 0] = 1;
            return matrix;
        }

        public static Vector2 ToVec2(Matrix<double> m)
        {
            return new Vector2((float)m[0, 0], (float)m[1, 0]);
        }

        public static Vector3 ToVec3(Matrix<double> m)
        {
            if(m.Rows < 3 || m.Cols != 1)
                throw new MatrixOperationException("Matrix is not a column");
            return new Vector3((float)m[0, 0], (float)m[1, 0], (float)m[2, 0]);
        }

        public T this[uint i, uint j]
        {
            get { return Data[i,j]; }
            set
            {
                Data[i,j] = value;
            }
        }


        public static Matrix<double> Summ(Matrix<double> a, Matrix<double> b)
        {
            if(a.Rows != b.Rows || a.Cols != b.Cols)
                throw new MatrixOperationException("Invalid sizes");
            Matrix<double> c = new Matrix<double>(a.Rows, a.Cols);
            
            for (uint i = 0; i < c.Rows; i++)
            for (uint j = 0; i < c.Cols; j++)
                c[i, j] = a[i, j] + b[i, j];
            return c;
        }

        public static Matrix<double> Prod(Matrix<double> a, Matrix<double> b)
        {
            if (a.Cols != b.Rows)
                throw new MatrixOperationException("Invalid sizes");

            Matrix<double> c = new Matrix<double>(a.Rows, b.Cols);
            for (uint i = 0; i < c.Rows; i++)
            for (uint j = 0; j < c.Cols; j++)
            {
                c[i, j] = 0;
                for (uint r = 0; r < a.Cols; r++)
                {
                    double summ = a[i, r] * b[r, j];
                    c[i, j] = c[i, j] + summ;
                }
            }
            return c;
        }

        public static Matrix<double> Prod(Matrix<double> matrix, double multiplier)
        {
            for (uint i = 0; i < matrix.Rows; i++)
            for (uint j = 0; i < matrix.Cols; j++)
                matrix[i, j] *= multiplier;
            return matrix;
        }

        public static bool operator ==(Matrix<T> a, Matrix<T> b)
        {
            if (a.Rows != b.Rows)
                return false;
            if (a.Cols != b.Cols)
                return false;
            for (uint i = 0; i < a.Rows; i++)
            for (uint j = 0; i < a.Cols; j++)
                if (!a[i, j].Equals(b[i, j]))
                    return false;
            return true;
        }

        public static bool operator !=(Matrix<T> a, Matrix<T> b)
        {
            return !(a == b);
        }

        protected bool Equals(Matrix<T> other)
        {
            return _rows == other._rows && _cols == other._cols && Equals(Data, other.Data);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != GetType()) return false;
            return Equals((Matrix<T>)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (int)_rows;
                hashCode = (hashCode * 397) ^ (int)_cols;
                hashCode = (hashCode * 397) ^ (Data != null ? Data.GetHashCode() : 0);
                return hashCode;
            }
        }

        public Matrix<T> Transposed()
        {
            Matrix<T> trans = new Matrix<T>(_rows, _cols);
            for (uint i = 0; i < _rows; i++)
            for (uint j = 0; i < _cols; j++)
            {
                trans[j, i] = Data[i, j];
            }
            return trans;
        }

        public object Clone()
        {
            Matrix<T> clone = new Matrix<T>(_rows, _cols);
            for (uint i = 0; i < _rows; i++)
            for (uint j = 0; j < _cols; j++)
            {
                clone[i, j] = Data[i, j];
            }
            return clone;
        }

        public void Transpose()
        {
            Matrix<T> clone = (Matrix<T>)Clone();
            for (uint i = 0; i < _rows; i++)
            for (uint j = 0; j < _cols; j++)
            {
                this[i, j] = clone[j, i];
            }
        }

        private static Matrix<double> ExcludeRowCol(Matrix<double> matrix, uint row, uint col)
        {
            Matrix<double> result = new Matrix<double>(matrix.Rows - 1, matrix.Cols - 1);
            for (uint i = 0, X = 0; i < matrix.Rows; i++, X++)
            {
                if (i == row)
                {
                    X--;
                    continue;
                }
                for (uint j = 0, Y = 0; j < matrix.Cols; j++, Y++)
                {
                    if (j == col)
                    {
                        Y--;
                        continue;
                    }
                    result[X, Y] = matrix[i, j];
                }
            }
            return result;
        }

        public static double CalculateDeterminant(Matrix<double> matrix)
        {
            if (matrix.Rows == 1 && matrix.Cols == 1)
                return matrix[0, 0];
            if(matrix.Rows != matrix.Cols)
                throw new MatrixOperationException("Illegal size of matrix. Impossible to find determinant of not square matrix");
            double result = 0;
            for (uint i = 0; i < matrix.Cols; i++)
            {
                if (i % 2 == 0)
                    result += matrix[0, i] * CalculateDeterminant(ExcludeRowCol(matrix, 0, i));
                else
                    result -= matrix[0, i] * CalculateDeterminant(ExcludeRowCol(matrix, 0, i));
            }
            return result;
        }

        private static void LineMul(Matrix<double> m, uint line, double k)
        {
            for (uint j = 0; j < m.Cols; j++)
                m[line, j] *= k;
        }

        private static void LineSumm(Matrix<Double> m, uint line1, uint line2, double k)
        {
            for (uint j = 0; j < m.Cols; j++)
                m[line1, j] += k * m[line2, j];
        }

        public static Matrix<double> GetInverseMatrix(Matrix<double> matrix)
        {

            var a = (Matrix<double>)matrix.Clone();
            if(a.Rows != a.Cols)
                throw new MatrixOperationException("Illegal size");

            if(CalculateDeterminant(a) == 0)
                throw new MatrixOperationException("Determinant must not be equal to zero");
            Matrix<double> e = new Matrix<double>(a.Rows, a.Cols);
            for(uint i = 0; i < e.Rows; i++)
            for(uint j = 0; j < e.Cols; j++)
                if (i == j)
                    e[i, j] = 1;
                else e[i, j] = 0;

            // Make (1, 1) unary
            double k = 1.00f / a[0, 0];
            LineMul(a, 0, k);
            LineMul(e, 0, k);

            for (uint i = 0; i < a.Rows - 1; i++)
            {
                // For each upper line
                for (uint line = i + 1; line < a.Rows; line++)
                {
                    if (Math.Abs(a[i, i]) > 0.001f)
                    {
                        double mul = a[line, i] / a[i, i];
                        LineSumm(a, line, i, -mul);
                        LineSumm(e, line, i, -mul);
                    }
                }
            }

            // Make diagonal unary
            for (uint i = 0; i < a.Cols; i++)
            {
                double mul = 1 / a[i,i];
                LineMul(a, i, mul);
                LineMul(e, i, mul);
            }

            return e;
        }

        public static void CopyData(Matrix<T> dest, Matrix<T> src)
        {
            if(dest.Rows != src.Rows || dest.Cols != src.Cols)
                throw new MatrixOperationException("Not equal sizes");
            for (uint i = 0; i < dest.Rows; i++)
                for (uint j = 0; j < dest.Cols; j++)
                    dest[i, j] = src[i, j];
        }

        [Obsolete("NOT IMPLEMENTED")]
        public static void PrintMatrix(Matrix<double> m)
        {
            string msg = "";
            for (uint i = 0; i < m.Rows; i++)
            {
                for (uint j = 0; j < m.Cols; j++)
                    msg += m[i, j] + " ";
            }
        }
    }

    public class SquareMatrix<T> : Matrix<T> where T : struct, IComparable
    {
        public SquareMatrix(uint size) : base(size, size)
        {
            
        }
    }

    public class SqMatrixDouble : SquareMatrix<double>
    {
        public SqMatrixDouble(uint size) : base(size)
        {
            
        }

        public double Determinant()
        {
            return CalculateDeterminant(this);
        }

        public SqMatrixDouble GetInversed()
        {
            return (SqMatrixDouble)GetInverseMatrix(this);
        }

        public static SqMatrixDouble Identity(uint size)
        {
            Matrix<double> m = GetFilledMatrix(size, size, 0);
            m.FillDiagonal(1.0f);
            return (SqMatrixDouble)m;
        }

        public static SqMatrixDouble Zero(uint size)
        {
            Matrix<double> m = GetFilledMatrix(size, size, 0);
            return (SqMatrixDouble)m;
        }
    }

}
