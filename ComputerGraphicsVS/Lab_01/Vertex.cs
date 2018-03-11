using System;

namespace Lab_01
{
    public struct Vertex : IComparable
    {
        public bool Equals(Vertex other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is Vertex && Equals((Vertex) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode() * 397) ^ Y.GetHashCode();
            }
        }

        public double X, Y;
        public int Index;

        public int CompareTo(object obj)
        {
            Vertex other = (Vertex)obj;
            if (Math.Abs(X - other.X) < 0.001f && Math.Abs(Y - other.Y) < 0.001f)
                return 1;
            return 0;
        }

        public override string ToString()
        {
            return String.Format("{0}:({1:0.00}; {2:0.00})", Index, X, Y);
        }

        public static bool operator ==(Vertex a, Vertex b)
        {
            return a.CompareTo(b) == 0;
        }

        public static bool operator !=(Vertex a, Vertex b)
        {
            return !(a == b);
        }

        public Vertex(double x, double y, int index)
        {
            X = x;
            Y = y;
            Index = index;
        }

        public Vertex(double x, double y)
        {
            X = x;
            Y = y;
            Index = -1;
        }

        public static double Magnitude(Vertex a, Vertex b)
        {
            return Math.Sqrt(Math.Pow(b.X - a.X, 2) + Math.Pow(b.Y - a.Y, 2));
        }

        public static double Angle(Vertex B, Vertex A, Vertex C)
        {
            // AC^2 = CB^2 + AB^2 - 2 * CB * AB * cos(ABC)
            // Cos(ABC) = (AC^2 - CB^2 - AB^2) / (2 * CB * AB)
            double a = Magnitude(C, B);
            double b = Magnitude(A, C);
            double c = Magnitude(A, B);
            if (Math.Abs(b) < 0.01f || Math.Abs(c) < 0.01f)
                return 0;
            double cosB = (Math.Pow(b, 2) + Math.Pow(c, 2) - Math.Pow(a, 2)) / (2 * b * c);
            return Math.Acos(cosB);
        }
    }
}
