using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    /// <typeparam name="T">Тип змінних для виконання розрахунків</typeparam>
    class Calculator<T>
    {
        /// <summary>
        /// Блокуємо доступ до конструктора
        /// </summary>
        private Calculator() { }

        /// <summary>
        /// Фабричний метод
        /// </summary>
        /// <returns></returns>
        public static Calculator<T> Factory()
        {
            // Аналіз по типу чи передана змінна є числом
            // // http://qaru.site/questions/81099/c-how-to-determine-whether-a-type-is-a-number
            if (5 <= (int)Type.GetTypeCode(typeof(T)) &&
                (int)Type.GetTypeCode(typeof(T)) <= 15)
            {
                return new Calculator<T>();
            }
            else
            {
                // виключення, того, що тип не є числовим
                throw new IsNotNumberException();
            }
        }

        /// <summary>
        /// Сума
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public dynamic Add(dynamic a, dynamic b)
            => a + b;

        /// <summary>
        /// Різниця
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public dynamic Sub(dynamic a, dynamic b)
            => a - b;

        /// <summary>
        /// Добуток
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public dynamic Mul(dynamic a, dynamic b)
            => a * b;

        /// <summary>
        /// Частка
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public dynamic Div(dynamic a, dynamic b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Спроба поділити на нуль.");
            }

            return a / b;
        }
    }

}
