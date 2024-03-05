namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {

            double r = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Alan: {0:F2}", Circle.AreaOfTheCircle(r, 60));
        }
    }
    
}