namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.CreateMatrix(4, 6, 2, 20);
            Matrix.PrintMatrix(Matris);

        }
    }
    
}