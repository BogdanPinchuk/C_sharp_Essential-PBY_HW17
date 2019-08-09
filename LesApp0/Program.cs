using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    class Program
    {
        static void Main()
        {
            // Join Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // випадкові числа
            Random rnd = new Random();

            #region тип sbyte
            {
                // створення змінних
                sbyte a = (sbyte)rnd.Next(sbyte.MinValue, sbyte.MaxValue),
                    b = (sbyte)rnd.Next(sbyte.MinValue, sbyte.MaxValue);
                // створення екземпляру калькулятора
                Calculator<sbyte> calc = Calculator<sbyte>.Factory();
                Console.WriteLine($"\n\tРозрахунок з використанням типу {a.GetType().Name}");
                Console.WriteLine($"\n\t{a:N0} + {b:N0} = {calc.Add(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} - {b:N0} = {calc.Sub(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} * {b:N0} = {calc.Mul(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} / {b:N0} = {calc.Div(a, b):N0}");

#if true
                // Cпроба ділення на 0
                try
                {
                    Console.WriteLine($"\n\t{a} / 0 = {calc.Div(a, 0)}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"\n\t" + e.Message);
                }
#endif

            }
            #endregion

            Console.Write("\n" + new string('*', 80));

            #region тип short
            {
                // створення змінних
                short a = (short)rnd.Next(short.MinValue, short.MaxValue),
                    b = (short)rnd.Next(short.MinValue, short.MaxValue);
                // створення екземпляру калькулятора
                Calculator<short> calc = Calculator<short>.Factory();
                Console.WriteLine($"\n\tРозрахунок з використанням типу {a.GetType().Name}");
                Console.WriteLine($"\n\t{a:N0} + {b:N0} = {calc.Add(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} - {b:N0} = {calc.Sub(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} * {b:N0} = {calc.Mul(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} / {b:N0} = {calc.Div(a, b):N0}");

#if true
                // Cпроба ділення на 0
                try
                {
                    Console.WriteLine($"\n\t{a} / 0 = {calc.Div(a, 0)}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"\n\t" + e.Message);
                }
#endif

            }
            #endregion

            Console.Write("\n" + new string('*', 80));

            #region тип long
            {
                // створення змінних
                long a = rnd.Next(int.MinValue, int.MaxValue),
                    b = rnd.Next(int.MinValue, int.MaxValue);
                // створення екземпляру калькулятора
                Calculator<long> calc = Calculator<long>.Factory();
                Console.WriteLine($"\n\tРозрахунок з використанням типу {a.GetType().Name}");
                Console.WriteLine($"\n\t{a:N0} + {b:N0} = {calc.Add(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} - {b:N0} = {calc.Sub(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} * {b:N0} = {calc.Mul(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} / {b:N0} = {calc.Div(a, b):N0}");

#if true
                // Cпроба ділення на 0
                try
                {
                    Console.WriteLine($"\n\t{a} / 0 = {calc.Div(a, 0)}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"\n\t" + e.Message);
                }
#endif

            }
            #endregion

            Console.Write("\n" + new string('*', 80));

            #region тип float
            {
                // створення змінних
                float a = rnd.Next(int.MinValue, int.MaxValue),
                    b = rnd.Next(int.MinValue, int.MaxValue);
                // створення екземпляру калькулятора
                Calculator<float> calc = Calculator<float>.Factory();
                Console.WriteLine($"\n\tРозрахунок з використанням типу {a.GetType().Name}");
                Console.WriteLine($"\n\t{a:N0} + {b:N0} = {calc.Add(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} - {b:N0} = {calc.Sub(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} * {b:N0} = {calc.Mul(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} / {b:N0} = {calc.Div(a, b):N3}");

#if true
                // Cпроба ділення на 0
                try
                {
                    Console.WriteLine($"\n\t{a} / 0 = {calc.Div(a, 0)}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"\n\t" + e.Message);
                }
#endif

            }
            #endregion

            Console.Write("\n" + new string('*', 80));

            #region тип decimal
            {
                // створення змінних
                decimal a = rnd.Next(int.MinValue, int.MaxValue),
                    b = rnd.Next(int.MinValue, int.MaxValue);
                // створення екземпляру калькулятора
                Calculator<decimal> calc = Calculator<decimal>.Factory();
                Console.WriteLine($"\n\tРозрахунок з використанням типу {a.GetType().Name}");
                Console.WriteLine($"\n\t{a:N0} + {b:N0} = {calc.Add(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} - {b:N0} = {calc.Sub(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} * {b:N0} = {calc.Mul(a, b):N0}");
                Console.WriteLine($"\n\t{a:N0} / {b:N0} = {calc.Div(a, b):N3}");

#if true
                // Cпроба ділення на 0
                try
                {
                    Console.WriteLine($"\n\t{a} / 0 = {calc.Div(a, 0)}");
                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"\n\t" + e.Message);
                }
#endif

            }
            #endregion
            
            Console.Write("\n" + new string('*', 80));

            #region тип string
            {
                Console.WriteLine($"\n\tСпроба користуватися в калькуляторі типом string");
                // спроба створенняекземпляру калькулятора
                try
                {
                    Calculator<string> calc = Calculator<string>.Factory();

                }
                catch (IsNotNumberException e)
                {
                    Console.WriteLine($"\n\t" + e.Message);
                }

            }
            #endregion

            Console.Write("\n" + new string('*', 80));

            #region тип bool
            {
                Console.WriteLine($"\n\tСпроба користуватися в калькуляторі типом bool");
                // спроба створенняекземпляру калькулятора
                try
                {
                    Calculator<bool> calc = Calculator<bool>.Factory();

                }
                catch (IsNotNumberException e)
                {
                    Console.WriteLine($"\n\t" + e.Message);
                }
            }
            #endregion

            // repeat
            DoExitOrRepeat();
        }

        /// <summary>
        /// Метод виходу або повторення методу Main()
        /// </summary>
        static void DoExitOrRepeat()
        {
            Console.WriteLine("\n\nСпробувати ще раз: [т, н]");
            Console.Write("\t");
            var button = Console.ReadKey(true);

            if ((button.KeyChar.ToString().ToLower() == "т") ||
                (button.KeyChar.ToString().ToLower() == "n")) // можливо забули переключити розкладку клавіатури
            {
                Console.Clear();
                Main();
                // без використання рекурсії
                //Process.Start(Assembly.GetExecutingAssembly().Location);
                //Environment.Exit(0);
            }
            else
            {
                // закриває консоль
                Environment.Exit(0);
            }
        }
    }
}
