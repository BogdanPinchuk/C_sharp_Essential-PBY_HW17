using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    class Program
    {
        static void Main()
        {
            // Join Unicode
            Console.OutputEncoding = Encoding.Unicode;

            // Колекція авто
            List<Car> cars = new List<Car>();
            #region Cars
            cars.AddRange(new Car[]
                {
                // https://auto.vercity.ru/catalog/auto/
                new Car()
                {
                    Brand = "Mercedes-Benz",
                    Model = "GLS-Class",
                    Year = 2015,
                    Color = ConsoleColor.Gray
                },
                new Car()
                {
                    Brand = "BMW",
                    Model = "M6",
                    Year = 2012,
                    Color = ConsoleColor.Blue
                },
                new Car()
                {
                    Brand = "Mazda",
                    Model = "RX-8",
                    Year = 2008,
                    Color = ConsoleColor.Red
                },
                new Car()
                {
                    Brand = "Mitsubishi",
                    Model = "GTO",
                    Year = 1998,
                    Color = ConsoleColor.Green
                },
                });
            #endregion
            
            // Колекція водіїв
            List<Driver> drivers = new List<Driver>();
            #region Drivers
            drivers.AddRange(new Driver[]
                {
                new Driver()
                {
                    FullName = "Bogdan Pinchuk",
                    Model = "GLS-Class",
                    PhoneNumber = "11111"
                },
                new Driver()
                {
                    FullName = "Vlad Kucherenko",
                    Model = "M6",
                    PhoneNumber = "22222"
                },
                new Driver()
                {
                    FullName = "Vadim Milevskiy",
                    Model = "RX-8",
                    PhoneNumber = "33333"
                },
                new Driver()
                {
                    FullName = "Oleksiy Sholomnitskiy",
                    Model = "GTO",
                    PhoneNumber = "44444"
                },
                });
            #endregion

            // linq запит
            var query = from car in cars
                        join driver in drivers
                        on car.Model equals driver.Model
                        where car.Brand == "Mercedes-Benz"
                        select new { C = car, D = driver };

            // Виведення інформації
            foreach (var i in query)
            {
                Console.WriteLine($"\n\t{i.D.FullName}, моб. {i.D.PhoneNumber}, має авто " +
                    $"{i.C.Brand} {i.C.Model}, {i.C.Color} кольору {i.C.Year} року випуску.");
            }

            // linq запит
            query = from car in cars
                    join driver in drivers
                    on car.Model equals driver.Model
                    where driver.FullName == "Oleksiy Sholomnitskiy"
                    select new { C = car, D = driver };

            // Виведення інформації
            foreach (var i in query)
            {
                Console.WriteLine($"\n\t{i.D.FullName}, моб. {i.D.PhoneNumber}, має авто " +
                    $"{i.C.Brand} {i.C.Model}, {i.C.Color} кольору {i.C.Year} року випуску.");
            }

            // linq запит
            query = from car in cars
                    join driver in drivers
                    on car.Model equals driver.Model
                    where car.Year >= 2010
                    select new { C = car, D = driver };

            // Виведення інформації
            foreach (var i in query)
            {
                Console.WriteLine($"\n\t{i.D.FullName}, моб. {i.D.PhoneNumber}, має авто " +
                    $"{i.C.Brand} {i.C.Model}, {i.C.Color} кольору {i.C.Year} року випуску.");
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
