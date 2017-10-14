using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammalTYPE
{
    class Bear :Mammal
    {

        public virtual decimal WeightRate { get; set; }
        public virtual string food { get; set; }

        public override void DisplayType()
        {
            for (int i = 1; i <= BearType.Length; i++)
            {
                Console.WriteLine(i + ". " + BearType[i - 1]);
            }
        }

        public override string Displayspec(int n)
        {
            return BearType[n - 1];
        }

        public override void Feed_Time()
        {
            Console.WriteLine("              Feed at 9AM and 3PM");
        }

        public static string[] BearType = { "Black", "Polar"};

    }

    class Black : Bear
    {
        public Black()
        {
            WeightRate = 0.014m;
            food = " berries, green vegetation, flowers, fruits, fish";
        }
    }

    class Polar : Bear
    {
        public Polar()
        {
            WeightRate = 0.016m;
            food = " berries, fish";
        }     
    }
}
