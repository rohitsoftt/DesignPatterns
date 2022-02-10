using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorProgram.Classes
{
    public class DaysInMonthCollection : IEnumerable<MonthWithDays>
    {
        public IEnumerator<MonthWithDays> GetEnumerator()
        {
            return new DaysInMonthEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
