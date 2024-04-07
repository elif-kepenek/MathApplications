namespace MathAplications.Helper
{
    public class Helper {

        /// <summary>
        /// Hata mesajının konsolda renkli görünmesini sağlar.
        /// </summary>
        /// <param name="message">Mesaj</param>
        public static void PrintError (string message) {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\a");
            Console.WriteLine(message);
            Console.ResetColor();
            Console.WriteLine();
        }

        /// <summary>
        /// Parametre olarak aldığı diziyi ekrana yazdırır.
        /// </summary>
        /// <param name="datas">Dizi</param>
        public static void ArrayPrint (int[] datas) {
            Console.WriteLine("");
            for (int i = 0; i < datas.Length; i++)
            {
                Console.Write("{0, 3}", datas[i]);
            }
            Console.WriteLine("");
        }

        /// <summary>
        /// Parametre olarak aldığı matrisi yazdırır.
        /// </summary>
        /// <param name="M">Matris</param>
        public static void ArrayPrint (int[,] M) {

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    Console.Write("{0,3}", M[i,j]);
                }
                Console.WriteLine();
            }            
        }
        
    }
}