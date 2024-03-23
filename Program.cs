namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("{0}! = {1}", n, NumberTheory.Factorial(n));
        }
    }
    
}