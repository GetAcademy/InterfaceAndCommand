using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndCommand
{
    class Stats
    {
        private int _sum;
        private int _count;

        public string GetStats()
        {
            var average = (float)_sum / _count;
            return $"Snitt = {average} Sum={_sum} Ant={_count}";
        }

        public void Reset()
        {
            _sum = 0;
            _count = 0;
        }

        public void AddNumber(int number)
        {
            _sum += number;
            _count++;
        }
    }
}
