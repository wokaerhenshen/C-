using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MammalTYPE
{
    
    public class Mammal
    {
        public virtual void DisplayType() {}

        public virtual string Displayspec(int n)
        {
            return "";
        }

        public virtual void Feed_Time(){}

        public static  string[] MammalType = { "Monkey", "Bear" };

        public static void result_title()
        {
            Console.WriteLine("Meal Recommendation");
            Console.WriteLine("================");
           
        }

        public static void instructions()
        {
            Console.WriteLine("Instructions: Keep area secure at all times.");
        }
    }
}
