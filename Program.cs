namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            int s1 = Convert.ToInt32(Console.ReadLine());
            int s2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("LCM({0},{1})={2}", s1, s2, NumberTheory.LeastCommonMultiple(s1, s2));
        }
    }
    
}