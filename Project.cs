using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Project
    {

        static void create_statics(string _numbers)
        {
            string[] numbers = _numbers.Split(" ");

            if (validate_numbers(numbers))
            {

            }
        }

        static bool validate_numbers(string[]_numbers)
        {
            return true;
        }
        static void Main(string[] args)
        {

            string numbers= Console.ReadLine();
            create_statics(numbers);




            while (true)
            {

            }
        }
    }
}
