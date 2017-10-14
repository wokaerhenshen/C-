using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MammalTYPE;

namespace MenuSpace
{
    class Menu
    {
        public static bool test_number(string number, int total_digit)
        {
           try
            {
                int var = Convert.ToInt32(number);
                for (int i = 1; i <= total_digit; i++)
                {
                    if (var == i)
                    {
                        return true;
                    }
                }
                return false;

            }

            catch
            {
                return false;
            }
        }
        public static bool test_weight(string n)
        {
            try
            {
                decimal var = Convert.ToDecimal(n);
                return true;
            }

            catch
            {
                return false;
            }
        }
        public static decimal get_weight()
        {
            Console.Write("Weight In KG: ");
            string weight = Console.ReadLine();
            test_weight(weight);
            if (test_weight(weight) == false)
            {
                invalid_input();
                Console.WriteLine("");
                return get_weight();
            }
            else
            {
                decimal weight_dec = Convert.ToDecimal(weight);
                if (weight_dec < 0)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Weight must be more than 0");
                    Console.WriteLine("");
                    return get_weight();
                }
                else
                {
                    return weight_dec;
                }
            }
        }

        public static void invalid_input()
        {
            Console.WriteLine("Invalid Entry.");
            
        }


        public static void species_title()
        {
            Console.WriteLine("");
            Console.WriteLine("================");
            Console.WriteLine("Species");
            Console.WriteLine("================");
        }
        public static void show_start()
        {
            Console.WriteLine("");
            Console.WriteLine("================");
            Console.WriteLine("Zoo Menu Planner");
            Console.WriteLine("================");
            Console.WriteLine("1. "+Mammal.MammalType[0]);
            Console.WriteLine("2. "+Mammal.MammalType[1]);
            Console.WriteLine("3. Quit");
            Console.Write("Selection:    ");
            string num = Console.ReadLine();
            bool tester = test_number(num, 3);
            int value;
            int.TryParse(num, out value);
            if (tester) {
                if ((value == 1) || (value ==2))
                {
                    Get_Spec(value);
                }
               
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("Thank you. Your session is now over.");
                    return ;
                }
            }

            else
            {
                invalid_input();
                show_start();
            }
        }


        public static void Get_Spec(int mammal_mumber)
        {
            const int NUM_MAMMALS = 2;
            Mammal[] mammals = new Mammal[NUM_MAMMALS];
            mammals[0] = new Monkey();
            mammals[1] = new Bear();
            Menu.species_title();
            mammals[mammal_mumber - 1].DisplayType();
            Console.Write("Selection:    ");
            string num = Console.ReadLine();
            bool tester;
            if (mammal_mumber == 1)
            {
                tester = test_number(num, 3);
            }
            else
            {
                tester = test_number(num, 2);
            }
            if (tester == false)
            {
                Menu.invalid_input();
                Get_Spec(mammal_mumber);
            }
            else
            {
                decimal weight = get_weight();
                Show_Detail(mammal_mumber, Convert.ToInt32(num), weight);
            }
        }

        public static void Show_Detail(int mammal_mumber, int spec, decimal weight)
        {
            const int NUM_MAMMALS = 2;
            const int NUM_BEARS = 2;
            const int NUM_MONKEYS = 3;

            Mammal[] mammals = new Mammal[NUM_MAMMALS];
            mammals[0] = new Monkey();
            mammals[1] = new Bear();

            Monkey[] monkeys = new Monkey[NUM_MONKEYS];
            monkeys[0] = new Squirel();
            monkeys[1] = new Howler();
            monkeys[2] = new Colobus();

            Bear[] bears = new Bear[NUM_BEARS];
            bears[0] = new Black();
            bears[1] = new Polar();

            Console.WriteLine("");
            Mammal.result_title();
            Console.WriteLine("Mammal Type:  " + Mammal.MammalType[mammal_mumber - 1]);
            Console.WriteLine("Species:      " + mammals[mammal_mumber - 1].Displayspec(spec));
            Console.WriteLine("Weight:       " + Math.Round(weight, 2).ToString() + " KG");
           
            if (mammal_mumber == 1)
            {
                Console.WriteLine("Serving:      " + Math.Round(monkeys[spec-1].WeightRate*weight, 3).ToString() + " KG fresh fruit, vegetables, nuts, insects, berries");
            }
            else
            {
                Console.WriteLine("Serving:      " + Math.Round(bears[spec - 1].WeightRate*weight, 3).ToString() + bears[spec-1].food);
            }
            Mammal.instructions();
            mammals[mammal_mumber - 1].Feed_Time();
            show_start();
        }
    }
}
