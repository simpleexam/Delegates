using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    internal class ObjectTextWorker
    {
        /// <summary>
        /// вывод информации может ли данная строка использоваться как пароль (длина не менее 6 симв и содержит символы)
        /// </summary>
        /// <param name="text"></param>
        public void CanUseAsPassword(string text)
        {
            if(text.Length>6 && isContainNumbers(ref text))
            {
                Console.WriteLine("подходит под пароль");
            }
            else Console.WriteLine("не подходит под пароль");
        }
        /// <summary>
        /// проверка наличия цифр в строке (хотя бы одной) 
        /// </summary>
        /// <param name="text"></param>
        /// <returns>true or false</returns>
        public bool isContainNumbers(ref string text)
        {
            foreach(var item in text)
            {
                if (Char.IsDigit(item))
                    return true;
            }
            return false;
        }
    }
}
