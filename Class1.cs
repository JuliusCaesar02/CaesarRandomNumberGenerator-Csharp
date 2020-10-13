using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dadi
{
    class sub
    {
        int[] result;
        public int[] roll (int repeat, int value)
        {
            Random rnd = new Random();  
            result = new int[repeat];
            for (int i = 0; i < repeat; i++)
            {
                result[i] = Convert.ToInt32 (rnd.Next(1, value + 1));
            }
            return result;
        }

        public int somma(int repeat)
        {
            int somma = 0;
            for (int i = 0; i < repeat; i++)
            {
                somma += result[i];
            }
            return somma;
        }
    }
}
