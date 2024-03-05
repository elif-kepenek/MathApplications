namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {

            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2*{0:F2}*{1:F2}={2:F2}", Circle.pi, r, Circle.PerimeterOfCircle(r));
        }
    }
    
}