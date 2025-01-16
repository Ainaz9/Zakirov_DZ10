
namespace Tumakov
{
    public class Rational
    {
        private int numerator;   // Числитель
        private int denominator; // Знаменатель

        // Конструктор
        public Rational(int numerator, int denominator)
        {
            if (denominator == 0)
                throw new ArgumentException("Знаменатель не может быть равен нулю.");

            // Упрощение дроби при создании
            int gcd = GCD(numerator, denominator);
            this.numerator = numerator / gcd;
            this.denominator = denominator / gcd;

            // Обеспечение положительного знаменателя
            if (this.denominator < 0)
            {
                this.numerator = -this.numerator;
                this.denominator = -this.denominator;
            }
        }

        // Упрощение дроби
        private static int GCD(int a, int b)
        {
            return b == 0 ? Math.Abs(a) : GCD(b, a % b);
        }

        // Операторы сравнения
        public static bool operator ==(Rational a, Rational b)
        {
            return a.Equals(b);
        }

        public static bool operator !=(Rational a, Rational b)
        {
            return !a.Equals(b);
        }

        public static bool operator <(Rational a, Rational b)
        {
            return (float)a < (float)b;
        }

        public static bool operator >(Rational a, Rational b)
        {
            return (float)a > (float)b;
        }

        public static bool operator <=(Rational a, Rational b)
        {
            return (float)a <= (float)b;
        }

        public static bool operator >=(Rational a, Rational b)
        {
            return (float)a >= (float)b;
        }

        // Операторы арифметики
        public static Rational operator +(Rational a, Rational b)
        {
            return new Rational(
                a.numerator * b.denominator + b.numerator * a.denominator,
                a.denominator * b.denominator
            );
        }

        public static Rational operator -(Rational a, Rational b)
        {
            return new Rational(
                a.numerator * b.denominator - b.numerator * a.denominator,
                a.denominator * b.denominator
            );
        }

        public static Rational operator *(Rational a, Rational b)
        {
            return new Rational(a.numerator * b.numerator, a.denominator * b.denominator);
        }

        public static Rational operator /(Rational a, Rational b)
        {
            if (b.numerator == 0)
                throw new DivideByZeroException("Деление на ноль.");
            return new Rational(a.numerator * b.denominator, a.denominator * b.numerator);
        }

        public static Rational operator %(Rational a, Rational b)
        {
            var div = a / b;
            return a - (new Rational(div.numerator / div.denominator, 1) * b);
        }

        // Преобразования типов
        public static explicit operator int(Rational r)
        {
            return r.numerator / r.denominator;
        }

        public static explicit operator float(Rational r)
        {
            return (float)r.numerator / r.denominator;
        }

        public static explicit operator Rational(int value)
        {
            return new Rational(value, 1);
        }

        public static explicit operator Rational(float value)
        {
            int denominator = 1000000;
            int numerator = (int)(value * denominator);
            return new Rational(numerator, denominator);
        }

        // Операторы инкремента и декремента
        public static Rational operator ++(Rational r)
        {
            return new Rational(r.numerator + r.denominator, r.denominator);
        }

        public static Rational operator --(Rational r)
        {
            return new Rational(r.numerator - r.denominator, r.denominator);
        }

        // Переопределение метода Equals
        public override bool Equals(object obj)
        {
            if (obj is Rational other)
            {
                return numerator == other.numerator && denominator == other.denominator;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(numerator, denominator);
        }

        // Переопределение метода ToString
        public override string ToString()
        {
            return denominator == 1 ? $"{numerator}" : $"{numerator}/{denominator}";
        }
    }
}
