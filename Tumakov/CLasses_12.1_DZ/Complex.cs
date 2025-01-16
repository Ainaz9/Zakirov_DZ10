
namespace Tumakov
{
    public class Complex
    {
        public double Real { get; } // Действительная часть
        public double Imaginary { get; } // Мнимая часть

        // Конструктор
        public Complex(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Перегрузка оператора сложения
        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Real + b.Real, a.Imaginary + b.Imaginary);
        }

        // Перегрузка оператора вычитания
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex(a.Real - b.Real, a.Imaginary - b.Imaginary);
        }

        // Перегрузка оператора умножения
        public static Complex operator *(Complex a, Complex b)
        {
            return new Complex(
                a.Real * b.Real - a.Imaginary * b.Imaginary,
                a.Real * b.Imaginary + a.Imaginary * b.Real
            );
        }

        // Перегрузка оператора проверки на равенство
        public static bool operator ==(Complex a, Complex b)
        {
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) // Сравнивает ячейку памяти
                return ReferenceEquals(a, b);

            return a.Real == b.Real && a.Imaginary == b.Imaginary;
        }

        // Перегрузка оператора проверки на неравенство
        public static bool operator !=(Complex a, Complex b)
        {
            return !(a == b);
        }

        // Переопределение Equals
        public override bool Equals(object obj)
        {
            if (obj is Complex other)
            {
                return Real == other.Real && Imaginary == other.Imaginary;
            }

            return false;
        }

        // Переопределение GetHashCode
        public override int GetHashCode()
        {
            return HashCode.Combine(Real, Imaginary);
        }

        // Переопределение ToString
        public override string ToString()
        {
            if (Imaginary == 0)
                return $"{Real}";
            if (Real == 0)
                return $"{Imaginary}i";

            return Imaginary > 0
                ? $"{Real} + {Imaginary}i"
                : $"{Real} - {-Imaginary}i";
        }
    }
}
