namespace Polynomial_3._3D
{
    internal class TestMyPolynomial
    {
        static void Main(string[] args)
        {
            // Test case 1
            double[] coeffs1 = { 1, -2, 0, 3 }; // Represents 1 - 2x + 3x^3
            MyPolynomial poly1 = new MyPolynomial(coeffs1);
            Console.WriteLine("Polynomial 1: " + poly1.ToString());
            Console.WriteLine("Degree of Polynomial 1: " + poly1.GetDegree());
            Console.WriteLine("Evaluate Polynomial 1 at x = 2: " + poly1.Evaluate(2));

            // Test case 2
            double[] coeffs2 = { 0, 1, 4 }; // Represents 1x + 4x^2
            MyPolynomial poly2 = new MyPolynomial(coeffs2);
            Console.WriteLine("\nPolynomial 2: " + poly2.ToString());
            Console.WriteLine("Degree of Polynomial 2: " + poly2.GetDegree());
            Console.WriteLine("Evaluate Polynomial 2 at x = 3: " + poly2.Evaluate(3));

            // Test addition
            MyPolynomial sum = poly1.Add(poly2);
            Console.WriteLine("\nSum of Polynomial 1 and Polynomial 2: " + sum.ToString());

            // Test multiplication
            MyPolynomial product = poly1.Multiply(poly2);
            Console.WriteLine("Product of Polynomial 1 and Polynomial 2: " + product.ToString());
        }
    }
}
