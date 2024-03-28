namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.CreateSymmetricMatrix(5);

            Matrix.PrintMatrix(Matris);

        }
    }
    
}