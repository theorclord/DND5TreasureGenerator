using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorCore.Helper
{
    public class Dice
    {
        public int Sides { get; set; }
        public int Amount { get; set; }

        public Dice(int s, int a)
        {
            Sides = s;
            Amount = a;
        }
        public int Roll()
        {
            Random ran = new Random();
            int total = 0;
            for(int i = 0; i < Amount; i++)
            {
                total += ran.Next(Sides) + 1;
            }
            return total;
        }
    }
}
