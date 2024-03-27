namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.CreateMatrix(5,5);

            Matrix.PrintMatrix(Matris);

            Console.WriteLine(Matrix.Trace(Matris));
        }
    }
    
}