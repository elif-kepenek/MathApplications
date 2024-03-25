namespace MathAplications
{
    public class Matrix {

        /// <summary>
        /// Matris oluşturur.
        /// </summary>
        /// <param name="row">Satır</param>
        /// <param name="column">Sütun</param>
        /// <param name="min">Min Değer</param>
        /// <param name="max">Max Değer</param>
        /// <returns>Matris</returns>
        public static int[,] CreateMatrix (int row = 3, int column = 3, int min = 1, int max = 9) {
            
            int[,] M = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    M[i, j] = new Random().Next(min, max);
                }
            }

            return M;
        }

        /// <summary>
        /// Parametre olarak aldığı matrisi yazdırır.
        /// </summary>
        /// <param name="M">Matris</param>
        public static void PrintMatrix (int[,] M) {

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write("{0,3}", M[i,j]);
                }
                Console.WriteLine();
            }            
        }

        /// <summary>
        /// Sıfır matris oluşturur.
        /// </summary>
        /// <param name="row">Satır</param>
        /// <param name="column">Sütun</param>
        /// <returns>Sıfır matris</returns>
        public static int[,] ZeroMatrix (int row, int column) {
            return CreateMatrix(row, column, 0, 0);
        }
    }
}