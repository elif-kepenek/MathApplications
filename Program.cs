namespace MathAplications
{
    class Program
    {
        static void Main (string[] args) {
            
            int[,] Matris = Matrix.DiagonalMatrix(5);

            Matrix.PrintMatrix(Matris);

            Console.WriteLine("{0}", Matrix.IsItDiagonalMatrix(Matris) ? "Köşegen matris": "Köşegen matris değil");
        }
    }
    
}