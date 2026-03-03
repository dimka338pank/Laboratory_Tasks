using System;

namespace Task3
{
    public class Complex
    {
        public double Real { get; set; }
        public double Imaginary { get; set; }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex { Real = c1.Real + c2.Real, Imaginary = c1.Imaginary + c2.Imaginary };
        }

        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex { Real = c1.Real - c2.Real, Imaginary = c1.Imaginary - c2.Imaginary };
        }

        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex
            {
                Real = c1.Real * c2.Real - c1.Imaginary * c2.Imaginary,
                Imaginary = c1.Real * c2.Imaginary + c1.Imaginary * c2.Real
            };
        }

        public static Complex operator /(Complex c1, Complex c2)
        {
            double znamennik = c2.Real * c2.Real + c2.Imaginary * c2.Imaginary;
            return new Complex
            {
                Real = (c1.Real * c2.Real + c1.Imaginary * c2.Imaginary) / znamennik,
                Imaginary = (c1.Imaginary * c2.Real - c1.Real * c2.Imaginary) / znamennik
            };
        }

        public static implicit operator string(Complex c)
        {
            return c.ToString();
        }
        public override string ToString()
        {
            string sign;
            if (Imaginary >= 0)
                sign = "+";
            else       
                sign = "-";
            return $"{Real} {sign} {Math.Abs(Imaginary)}i";
        }
    }
}
