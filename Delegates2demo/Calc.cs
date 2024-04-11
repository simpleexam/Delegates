using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2demo
{
    internal static class Calc
    {
        /// <summary>
        /// вычисление суммы последовательности действительных чисел
        /// </summary>
        /// <param name="xx"></param>
        /// <returns></returns>
        public static double Summ(params double[] xx)
        {
            double summ = 0;
            foreach (var item in xx)
                summ+= item;

            return summ;
        }
        /// <summary>
        /// вычисление среднего значения последовательности действительных чисел
        /// </summary>
        /// <param name="yy"></param>
        /// <returns></returns>
        public static double Average(params double[] yy)
        {
            return Summ(yy)/yy.Length;
        }
        /// <summary>
        /// возврат максимального среди послед. действ чисел
        /// </summary>
        /// <param name="aa"></param>
        /// <returns></returns>
        public static double GetMax (params double[] aa)
        {
            return aa.Max();
        }
        /// <summary>
        /// возврат минимального среди послед. действ чисел
        /// </summary>
        /// <param name="aa"></param>
        /// <returns></returns>
        public static double GetMin(params double[] aa)
        {
            return aa.Min();
        }
    }
}
