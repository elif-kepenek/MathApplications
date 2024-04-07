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

        
    }
}