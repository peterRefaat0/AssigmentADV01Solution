using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentADV01.generic_Range
{
    public class Range<T> where T : IComparable<T>
    {
        private  T _min;
        private  T _max;

        public Range(T min, T max)
        {
            if (min.CompareTo(max) > 0)
            {
                throw new ArgumentException("Minimum value must be less than or equal to maximum value");
            }

            _min = min;
            _max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(_min) >= 0 && value.CompareTo(_max) <= 0;
        }

        public int Length()
        {
         
            return (int)Convert.ChangeType(_max, typeof(int)) - (int)Convert.ChangeType(_min, typeof(int)) + 1;
        }
    }
}
