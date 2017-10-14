using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hwk5;

namespace MammalTYPE
{



    class Monkey :Mammal
    {
        public virtual decimal WeightRate { get; set; }

        public override void DisplayType()
        {
            for (int i = 1; i <= MonkeyType.Length; i++)
            {
                Console.WriteLine(i + ". " + MonkeyType[i - 1]);
            }
        }

        public override string Displayspec(int n)
        {
            return MonkeyType[n - 1];
        }

        public override void Feed_Time()
        {
            Console.WriteLine("              Feed at 9AM, 12PM and 5PM.");
        }

        public static string[] MonkeyType = { "Squirrel", "Howler", "Colobus" };

    }

    class Squirel : Monkey
    {
        public Squirel()
        {
            WeightRate = 0.006m;
        } 
    }

    class Howler : Monkey
    {
        public Howler()
        {
            WeightRate = 0.007m;
        }
       
    }

    class Colobus : Monkey
    {
        public Colobus()
        {
            WeightRate = 0.008m;
        }
     
    }

}
