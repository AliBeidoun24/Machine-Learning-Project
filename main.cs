using System;
using System.Collections.Generic;

namespace VSCodeNetTest
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please Enter amount of numbers you would like to add");
            List<string> strList = new List<string>();
            strList.Add("Test");
            strList.Add("of");
           
            
            List<int> intList = new List<int>();

            Console.WriteLine("Please Enter amount of numbers you would like to add");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Please enter number");
                int number = Convert.ToInt32(Console.ReadLine());
                intList.Add(number);
            }
            intList.Add(x);

            foreach(var str in strList)
            {
                Console.WriteLine(str);
            }

        }
    }
}