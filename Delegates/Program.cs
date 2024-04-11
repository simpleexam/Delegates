namespace Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintText printText = new PrintText(TextWorker.CesarCode); //2. создание делегатной переменной (объекта) с одновременной привязкой ссылки на метод
            printText += TextWorker.PrintTextToChar; //добавление в список вызовов делегатного объекта метода PrintTextToChar

            ObjectTextWorker otw = new ObjectTextWorker(); //вызов всех методов записанных в список вывово делегатной переменной

            printText += otw.CanUseAsPassword; // дозапись

            printText("some text66"); //обновленный вызов
        }
    }
}
