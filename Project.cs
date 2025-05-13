using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Project
    {

        static void run(string[] _args)
        {
            Dictionary<int, object> dict = new Dictionary<int, object>();
            List<int> numbers = new List<int>();
            dict.Add(0, "string numbers");

            dict.Add(1, _args);
            dict.Add(2, true);

            dict.Add(3, numbers);

            request_user_input(dict);


            while (dict[2])
            {
                menu(dict);

                if (dict[2] == "false")
                {
                    infinity = false;
                }
            }


        }


        static void request_user_input(Dictionary<int, object> _dict)
        {
           string numbers;
            while (true)
            {
                numbers = Console.ReadLine();
                _dict[3].Clear();
                _dict[0] = numbers;
                string indication = validation_number(_dict);
                if (indication == "excellent")
                {
                    return;
                }
                Console.WriteLine(indication);
            }

        }
        static string validation_number(Dictionary<int, object> _dict)
        {
            convert_to_list(_dict);
            List<int> numbers = (List<int>)_dict[3];
            
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
                _dict[3] = numbers;
            }


        }

        static void menu(Dictionary<int, object> _dict)
        {
            Console.WriteLine("\n\n");
            bool infinity = true;
            while (infinity)
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
                        request_user_input(_dict);
                        infinity = false;
                        break;
                    case "2":
                        print_in_order(_dict);
                        infinity = false;
                        break;
                    case "3":
                        print_reversed(_dict);
                        infinity = false;
                        break;
                    case "4":
                        print_sorted(_dict);
                        infinity = false;
                        break;
                    case "5":
                        max(_dict);
                        infinity = false;
                        break;
                    case "6":
                        min(_dict);
                        infinity = false;
                        break;
                    case "7":
                        avaerge(_dict);
                        infinity = false;
                        break;
                    case "8":
                        count(_dict);
                        infinity = false;
                        break;
                    case "9":
                        sum(_dict);
                        infinity = false;
                        break;
                    case "10":
                        _dict[2] = "false";
                        infinity = false;
                        break;
                    default:
                        Console.WriteLine("Try again!");
                        continue;
                }



            }
        }


        static void print_in_order(List<int> _list_numbers)
        {
            foreach(int num in _list_numbers)
            {
                Console.WriteLine(num);
            }
        }

        static void print_reversed(List<int> _list_numbers)
        {
            for (int i = 0; i < _list_numbers.Count(); i++)
            {
                Console.WriteLine(_list_numbers.Count()-i);
            }
        }

        static void print_sorted(List<int> _list_numbers)
        {
            List<int> neww = _list_numbers;
            neww.Sort();
            foreach(int num in neww)
            {
                Console.WriteLine(num);
            }
        }

        static void max(List<int> _list_numbers)
        {
            int max = -1;
            foreach (int num in _list_numbers)
            {
                max = Math.Max(max, num);
            }
            Console.WriteLine(max);
        }

        static void min(List<int> _list_numbers)
        {
            int min = 214748367;
            foreach (int num in _list_numbers)
            {
                min = Math.Min(min, num);
            }
            Console.WriteLine(min);
        }

        static void avaerge(List<int> _list_numbers)
        {
            int sum = 0;
            foreach (int num in _list_numbers)
            {
                sum += num;
            }
            Console.WriteLine(sum/_list_numbers.Count());
        }

        static void count(List<int> _list_numbers)
        {
            int sum = 0;
            foreach (int num in _list_numbers)
            {
                sum += 1;
            }
            Console.WriteLine(sum);
        }

        static void sum(List<int> _list_numbers)
        {
            int sum = 0;
            foreach (int num in _list_numbers)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }


        static void Main(string[] args)
        {
            run(args);
        }










    }
}
