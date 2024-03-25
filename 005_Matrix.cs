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
    }
}