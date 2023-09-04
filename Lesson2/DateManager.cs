using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class DateManager
    {
        public DateTime Date { get; set; }

        public DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }

        public int GetCurrentYear()
        {
            return DateTime.Now.Year;
        }
    }
}
