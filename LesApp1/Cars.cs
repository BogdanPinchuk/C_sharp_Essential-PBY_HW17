using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp1
{
    /// <summary>
    /// Автомобіль
    /// </summary>
    class Car
    {
        /// <summary>
        /// Марка авто
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Модель авто
        /// </summary>
        public string Model { get; set; }
        /// <summary>
        /// Рік випуску авто
        /// </summary>
        public int Year { get; set; }
        /// <summary>
        /// Колір авто
        /// </summary>
        public ConsoleColor Color { get; set; }
    }
}
