using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0
{
    /// <summary>
    /// Тип не є числовим
    /// </summary>
    class IsNotNumberException : Exception
    {
        /// <summary>
        /// Виключення спричинене тим, що тип не є числовим
        /// </summary>
        public IsNotNumberException() { }

        public override string Message
            => "Тип не є числовим";
    }
}
