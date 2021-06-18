using System;
using System.Collections.Generic;
namespace MethodOverloadingPractice
{
    class Program
    {
        //TODO Create a method that takes two string names in the parameter. Have the method tell you which name is longer.
        public static void Names(string name, string name2)
        {
            if (name.Length > name2.Length)
            {
                Console.WriteLine($"{name} is longer than {name2}");
            }
            else if (name2.Length > name.Length)
            {
                Console.WriteLine($"{name2} is longer than {name}");
            }
            else if (name.Length == name2.Length)
            {
                Console.WriteLine($"{name} is the same length as {name2}");
            }
        }
        //TODO Create an overload method that takes a list of string names and an integer. The method will look for the first name that matches the length of the integer.
        public static void Names(List<string> names, int a)
        {
            foreach (var name in names)
            {
                if (name.Length == a)
                {
                    Console.WriteLine($"first name length equal to {a} is {name}");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            
            //TODO Call both methods here. Use a break point and watch as the code jumps to the different method overloads.
            var names = new List<string>() { "bob", "fred", "george" };
            Names(names, 4);
            Names("jerry", "amanda");

        }


    }
}
