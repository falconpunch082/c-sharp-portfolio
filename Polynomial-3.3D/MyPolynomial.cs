using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomial_3._3D
{
    class MyPolynomial
    {
        // Declaring array to store coefficients
        private double[] _coeffs;

        // Constructor
        public MyPolynomial(double[] coeffs)
        {
            _coeffs = new double[coeffs.Length]; // Set length of array using the length of provided coeff list
            Array.Copy(coeffs, _coeffs, coeffs.Length); // Then copy the provided coeff list to the coeff variable of the object
        }

        // Method to get the degree of the polynomial
        public int GetDegree()
        {
            return _coeffs.Length - 1; // Minus one to consider constant
        }

        // Method to evaluate the polynomial for a given x
        public double Evaluate(double x)
        {
            double result = 0;
            for (int i = 0; i < _coeffs.Length; i++) // For each element in the Polynomial array
            {
                result += _coeffs[i] * Math.Pow(x, i); // Multiply the coefficient by x provided to the power of the current degree
            }
            return result;
        }

        // Method to add another polynomial to this polynomial
        public MyPolynomial Add(MyPolynomial another)
        {
            int maxDegree = Math.Max(this.GetDegree(), another.GetDegree()); // The highest degree of the result is the highest degree of each polynomial, whichever is highest.
            Array.Resize(ref _coeffs, maxDegree + 1);

            for (int i = 0; i <= maxDegree; i++) // For each degree in both Polynomials
            {
                double anotherCoeff = i <= another.GetDegree() ? another._coeffs[i] : 0; // Using ternary conditional operator to determine if max coeff has been reached

                _coeffs[i] += anotherCoeff; // Readjust coeffs in invoker poly class according to addition
            }

            return this;
        }

        // Method to multiply this polynomial by another polynomial
        public MyPolynomial Multiply(MyPolynomial another)
        {
            int resultDegree = this.GetDegree() + another.GetDegree(); // The highest degree of the result is the addition of the powers of both polynomials
            double[] resultCoeffs = new double[resultDegree + 1];

            for (int i = 0; i <= this.GetDegree(); i++)
            {
                for (int j = 0; j <= another.GetDegree(); j++)
                {
                    resultCoeffs[i + j] += this._coeffs[i] * another._coeffs[j]; // This nested for loop imitates multiplication for polynomials, i.e. one degree of a polynomial is applied to every degree of another
                }
            }

            _coeffs = resultCoeffs; // Readjust coeffs in invoker poly class according to multiplication done above
            return this;
        }

        // Method to convert the polynomial to a string representation
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); // Using Stringbuilder class to represent a mutable string of characters

            for (int i = _coeffs.Length - 1; i >= 0; i--) // For each element in the Polynomial array
            {
                if (_coeffs[i] != 0) // If the coefficient is not zero
                {
                    if (sb.Length > 0) // If there is already an existing number (e.g. constant or degree)
                    {
                        sb.Append(_coeffs[i] > 0 ? " + " : " - ");
                    }
                    sb.Append($"{Math.Abs(_coeffs[i])}");

                    if (i > 0)
                    {
                        sb.Append(i > 1 ? $"x^{i}" : "x");
                    }
                }
            }

            return sb.ToString(); // Combines everything in sb to a final string
        }
    }
}
