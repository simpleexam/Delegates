using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal static class TextWorker
    {
        /// <summary>
        /// печать текста посимволько на каждой строке
        /// </summary>
        /// <param name="str">исходный текст</param>
        public static void PrintTextToChar(string str)
        {
            Console.WriteLine("работа метода PrintTextToChar");
            char[] chars = str.ToCharArray();
            foreach (var item in chars)
                Console.WriteLine(item);
        }
        /// <summary>
        /// сдвиг каждого символа строки на единицу по таблице символов
        /// </summary>
        /// <param name="str">исходная строка</param>
        public static void CesarCode(string str)
        {
            Console.WriteLine("работа метода CesarCode");
            char[] chars = str.ToCharArray();
            for( int i = 0; i<chars.Length; i++)
            {
               
                chars[i] = ++chars[i];
            }
            Console.WriteLine(new String(chars));
        }
    }
}
