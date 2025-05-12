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
            List<string> numbers_strings = new List<string>();
            List<int> numbers = new List<int>();

            numbers_strings.Add("");

            request_input(numbers, numbers_strings);

            bool infinity = true;
            while (infinity)
            {
                menu(numbers, numbers_strings);
            }


        }


        static void request_input(List<int> _list_numbers, List<string> _numbers_string)
        {
           string numbers;
            while (true)
            {
                numbers = Console.ReadLine();
                string indication = validation_number(_list_numbers, _numbers_string);
                if (indication == "excellent")
                {
                    _numbers_string[0] = numbers;
                    return;
                }
                Console.WriteLine(indication);
            }

        }
        static string validation_number(List<int> _list_numbers, List<string> _numbers_string)
        {
            convert_to_list(_list_numbers, _numbers_string);
            
            
            if (_list_numbers.Count() < 3) 
            {
                return "You gave less then 3 numbers.\nTry again.";
            }
            foreach (int num in _list_numbers)
            {
                if (num < 0)
                {
                    return $"{num} is an negative number. Try again. ONLY POSITIVE NUMERS.";
                }
            }
            return "excellent";
        }
        static void convert_to_list(List<int> _list_numbers, List<string> _numbers_string)
        {
            string str_num = _numbers_string[0];
            string[] arr_nums = str_num.Split(" ");

            foreach (string num in arr_nums)
            {
                int num_int;
                try 
                {
                    num_int = Convert.ToInt32(num);
                    _list_numbers.Add(num_int);
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
                        _list_numbers.Add(num_int);
                    }
                }
            }


        }

        static void menu(List<int> _list_numbers, List<string> _numbers_string)
        {
            Console.WriteLine("\n\n");
            while (true)
            {
                Console.WriteLine("Welcome to the game:\n" +
                    "1. Input a Series.\n" +
                    "2. Display the series in the order it was entered.\n" +
                    "3. Display the series in the reversed order it was entered.\n" +
                    "4. Display the series in sorted order (from low to high).\n" +
                    "5. Display the Max value of the series.\n" +
                    "6. Display the Min value of the series.\n" +
                    "7. Display the Average of the series.\n" +
                    "8. Display the Number of elements in the series.\n" +
                    "9. Display the Sum of the series.\n" +
                    "10. Exit");
                string input = Console.ReadLine();


                switch (input)
                {
                    case "1":
                        request_input(_list_numbers, _numbers_string);
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        break;
                    case "7":
                        break;
                    case "8":
                        break;
                    case "9":
                        break;
                    case "10":
                        break;
                    default:
                        Console.WriteLine("Try again!");
                        continue;
                }



            }
        }

        static void Main(string[] args)
        {
            run();
        }










    }
}
