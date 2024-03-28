namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.CreateMatrix(5);

            Matrix.PrintMatrix(Matris);

            Console.WriteLine("{0}", Matrix.IsItSymmetricMatrix(Matris) ? "Simetrik": "Simetrik değil");
        }
    }
    
}