namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.CreateMatrix(2,4);

            Matrix.PrintMatrix(Matris);

            Console.WriteLine("Elemanlar toplamı: {0}", Matrix.SumOfElements(Matris));

        }
    }
    
}