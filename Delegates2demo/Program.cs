namespace Delegates2demo
{
    delegate double CalculateDelegate(params double[] numbers); //1. описание делегата
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(0.09+0.01);


            CalculateDelegate calcDelegate = Calc.GetMax; //2. создание объекта делегата
            
            //добавление методов в список вызовов
            calcDelegate += Calc.GetMin;
            calcDelegate += Calc.Average;
            calcDelegate += Calc.Summ;

            //в результате возвращается результат только для последнего метода в списке вызовов
            Console.WriteLine(calcDelegate(5.2,-8.6,55.6,-3.8));


            calcDelegate -= Calc.Summ;//удаление метода из списка вызово
            Console.WriteLine(calcDelegate(5.2, -8.6, 55.6, -3.8));
        }
    }
}
