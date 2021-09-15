using System;

namespace FractionLib
{
    public class Fraction
    {
        public int Numerator { get; private set; }
        public int Denumerator { get; private set; }

        public Fraction(int numerator = 0, int denumerator = 1)
        {
            Set(numerator, denumerator);
        }

        public void Set(int numerator = 0, int denumerator = 1)
        {
            Numerator = denumerator != 0 ? numerator : 0;
            Denumerator = denumerator != 0 ? denumerator : 1;
        }

        public override string ToString()
        {
            return $"{Numerator}/{Denumerator}";
        }


        //
        // Перегрузка унарных операций
        //

        public static Fraction operator -(Fraction fr)
        {
            return new Fraction(-fr.Numerator, fr.Denumerator);
        }

        public static Fraction operator ++(Fraction fr)
        {
            return fr + 1;
        }

        public static Fraction operator --(Fraction fr)
        {
            return fr - 1;
        }



        //
        // Перегрузка бинарных операций
        //

        public static Fraction operator +(Fraction fr1, Fraction fr2)
        {
            return new Fraction(
                fr1.Numerator * fr2.Denumerator + fr1.Denumerator * fr2.Numerator,
                fr1.Denumerator * fr2.Denumerator);
        }

        public static Fraction operator +(Fraction fr, int n)
        {
            return new Fraction(
                fr.Numerator + fr.Denumerator * n,
                fr.Denumerator);
        }

        public static Fraction operator +(int n, Fraction fr)
        {
            return fr + n;
        }

        public static Fraction operator -(Fraction fr1, Fraction fr2)
        {
            return new Fraction(
                fr1.Numerator * fr2.Denumerator - fr1.Denumerator * fr2.Numerator,
                fr1.Denumerator * fr2.Denumerator);
        }

        public static Fraction operator -(Fraction fr, int n)
        {
            return new Fraction(
                fr.Numerator - fr.Denumerator * n,
                fr.Denumerator);
        }

        public static Fraction operator -(int n, Fraction fr)
        {
            return fr - n;
        }

        public static Fraction operator *(Fraction fr1, Fraction fr2)
        {
            return new Fraction(
                fr1.Numerator * fr2.Numerator,
                fr1.Denumerator * fr2.Denumerator);
        }

        public static Fraction operator *(Fraction fr, int n)
        {
            return new Fraction(fr.Numerator + n, fr.Denumerator);
        }

        public static Fraction operator *(int n, Fraction fr)
        {
            return fr * n;
        }

        public static Fraction operator /(Fraction fr1, Fraction fr2)
        {
            return new Fraction(
                fr1.Numerator * fr2.Denumerator,
                fr1.Denumerator * fr2.Numerator);
        }

        public static Fraction operator /(Fraction fr, int n)
        {
            return new Fraction(fr.Numerator, fr.Denumerator * n);
        }

        public static Fraction operator /(int n, Fraction fr)
        {
            return new Fraction(n * fr.Denumerator, fr.Numerator);
        }


        //
        // Перегрузка операций сравнения >, <, >= и <=
        //

        public static bool operator >(Fraction fr1, Fraction fr2)
        {
            return (double)fr1.Numerator / fr1.Denumerator > (double)fr2.Numerator / fr2.Denumerator;
        }

        public static bool operator <(Fraction fr1, Fraction fr2)
        {
            return (double)fr1.Numerator / fr1.Denumerator < (double)fr2.Numerator / fr2.Denumerator;
        }

        public static bool operator >=(Fraction fr1, Fraction fr2)
        {
            return (double)fr1.Numerator / fr1.Denumerator >= (double)fr2.Numerator / fr2.Denumerator;
        }

        public static bool operator <=(Fraction fr1, Fraction fr2)
        {
            return (double)fr1.Numerator / fr1.Denumerator <= (double)fr2.Numerator / fr2.Denumerator;
        }


        //
        // Перегрузка операций сравнения == и !=
        //
        // При перегрузке любой из этих операций рекомендуется переопределять так же
        // унаследованные от класса Object методы GetHashCode() и Equals(object)
        //

        public static bool operator ==(Fraction fr1, Fraction fr2)
        {
            return (double)fr1.Numerator / fr1.Denumerator == (double)fr2.Numerator / fr2.Denumerator;
        }

        public static bool operator !=(Fraction fr1, Fraction fr2)
        {
            return (double)fr1.Numerator / fr1.Denumerator != (double)fr2.Numerator / fr2.Denumerator;
        }

        public override int GetHashCode()
        {
            //
            // Классический вариант из Рихтера
            //
            //unchecked
            //{
            //    return (Numerator * 397) ^ Denumerator;
            //}

            //
            // Используем класс HashCode, добавленный в .NET Core 2.1
            //
            return HashCode.Combine(Numerator, Denumerator);
        }

        public override bool Equals(object other)
        {
            if (other is null) return false;
            if (object.ReferenceEquals(this, other)) return true;
            if (GetType() != other.GetType()) return false;
            return Equals(other as Fraction);
        }

        protected bool Equals(Fraction other)
        {
            return ((double)Numerator / Denumerator).CompareTo((double)other.Numerator / other.Denumerator) == 0;
        }


        //
        // Перегрузка логических операций
        //
        // Явно перегрузить &&, || и ?: нельзя, но можно их перегрузить неявно,
        // перегрузив операции &, |, true, и false
        //

        public static bool operator !(Fraction fr)
        {
            return fr.Numerator == 0;
        }

        public static bool operator &(Fraction fr1, Fraction fr2)
        {
            return fr1.Numerator != 0 && fr2.Numerator != 0;
        }

        public static bool operator |(Fraction fr1, Fraction fr2)
        {
            return fr1.Numerator != 0 || fr2.Numerator != 0;
        }

        public static bool operator true(Fraction fr)
        {
            return fr.Numerator != 0;
        }

        public static bool operator false(Fraction fr)
        {
            return fr.Numerator == 0;
        }


        //
        // Перегрузка операций преобразования
        //

        public static explicit operator double(Fraction fr)
        {
            return (double)fr.Numerator / fr.Denumerator;
        }
    }
}
