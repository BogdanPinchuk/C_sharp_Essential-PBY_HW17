using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp2
{
    class Program
    {
        static void Main()
        {
            // Join Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // створення списків зі словами
            List<string> en = new List<string>(),
                ua = new List<string>(),
                ru = new List<string>();
            en.AddRange(new string[]
            {
                "God",
                "Good",
                "Sun",
                "Boy",
                "Girl",
                "Rainbow",
                "Happyness",
                "Mother",
                "Father",
                "Brain",
            });
            ua.AddRange(new string[]
            {
                "Бог",
                "Добро",
                "Сонце",
                "Хлопець",
                "Дівчина",
                "Веселка",
                "Щастя",
                "Мати",
                "Батько",
                "Мозок",
            });
            ru.AddRange(new string[]
            {
                "Бог",
                "Благо",
                "Солнце",
                "Парень",
                "Девушка",
                "Радуга",
                "Счастье",
                "Мать",
                "Отец",
                "Мозг",
            });

            // колекція
            var dictionary = en.Zip(ua.Zip(ru, (u, r) => new { Ua = u, Ru = r }), (e, ur) => new { En = e, ur.Ua, ur.Ru });

            // Вивід даних
            Console.WriteLine("\n\tДані словника:\n");

            foreach (dynamic i in dictionary)
            {
                Console.WriteLine($"\tEng: {i.En}, Ukr: {i.Ua}, Rus: {i.Ru};");
            }

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
