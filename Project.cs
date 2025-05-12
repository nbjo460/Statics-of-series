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
            convert_to_list(_dict);
            List<int> numbers = (List<int>)_dict[1];
            
            if (numbers.Count() < 3) 
            {
                return "You gave less then 3 numbers.\nTry again.";
            }
            foreach (int num in numbers)
            {
                if (num < 0)
                {
                    return $"{num} is an negative number. Try again. ONLY POSITIVE NUMERS.";
                }
            }
            return "excellent";
        }
        static void convert_to_list(Dictionary<int, object> _dict)
        {
            List<int> numbers = new List<int>();
            string str_num = (string) _dict[0];
            string[] arr_nums = str_num.Split(" ");

            foreach (string num in arr_nums)
            {
                int num_int;
                try 
                {
                    num_int = Convert.ToInt32(num);
                    numbers.Add(num_int);
                }
                catch //if contains leeters or special symbols
                {
                    string decompision_num = "";
                    foreach (char c in num) //ignore of non digits. but may be without digits.
                    {
                        if (Char.IsDigit(c))
                        {
                            decompision_num += c;
                        }
                    }
                    if (decompision_num.Length > 0) //validate, that it's will include digits
                    {
                        num_int = Convert.ToInt32(decompision_num);
                        numbers.Add(num_int);
                    }
                }
                _dict[1] = numbers;
            }


        }



        static void Main(string[] args)
        {
            run();
        }










    }
}
