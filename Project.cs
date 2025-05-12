using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Project
    {

        static void run()
        {
            Dictionary<int, object> dict = new Dictionary<int, object>();
            List<int> numbers = new List<int>();

            dict.Add(0, "string numbers");
            dict.Add(1, numbers);

            request_input(dict);


        }


        static void request_input(Dictionary<int, object> _dict)
        {
           string numbers;
            while (true)
            {
                numbers = Console.ReadLine();
                string indication = validation_number(_dict);
                if (indication == "excellent")
                {
                    _dict[0] = numbers;
                    return;
                }
                Console.WriteLine(indication);
            }

        }
        static string validation_number(Dictionary<int, object> _dict)
        {
            return "";
        }




        static void Main(string[] args)
        {
            run();
        }










    }
}
