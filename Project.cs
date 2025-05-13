using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tutorial
{
    internal class Project
    {

        static void Run(string[] _args)
        {
            /*
            dict[0] = user input
            dict[1] = string arguments
            dict[2] = boolean of menu
            dict[3] = list of numbers
             */
            Dictionary<int, object> store = new Dictionary<int, object>
            {

            };
            List<float> numbers = new List<float>();

            store.Add(0, "");
            store.Add(1, _args);
            store.Add(2, true);
            store.Add(3, numbers);

            RefactorString(store);



            while ((bool)store[2])
            {
                Menu(store);
            }


        }

        static void RefactorString(Dictionary <int, object> _dict)
        {
            bool need_user;
            need_user = ExistArgs(_dict);
            RequestUser_input(_dict, need_user ? false : true);
        }

        static bool ExistArgs(Dictionary<int, object> _dict)
        {
            string[] arguments = (string[])_dict[1];
            if (arguments.Length > 2)
            {
                string joinedArguments = String.Join(" ", arguments);
                _dict[0] = joinedArguments;
                return true;
            }
            return false;
        }
        static void RequestUser_input(Dictionary<int, object> _dict, bool asking_user)
        {
            string input_user = "";
            while (true)
            {
                if (asking_user)
                {
                    Console.WriteLine("\n\nPlease enter a series of numbers. The series must contain at least 3 numbers (those will be seperated by space.)\n" +
                        "The Program will ignore letters, therefore, 'e4r5' will calculate as '45'. Each num should be positive.\n\n");
                    input_user = Console.ReadLine();
                    _dict[3] = new List<float>();
                    _dict[0] = input_user;
                }
                asking_user = true;
                string indication = ValidationNumber(_dict);
                if (indication == "excellent")
                {
                    return;
                }
                Console.WriteLine(indication);
            }

        }
        static string ValidationNumber(Dictionary<int, object> _dict)
        {
            ConvertToList(_dict);
            List<float> numbers = (List<float>)_dict[3];

            if (numbers.Count() == 0)
            {
                return "You didn't give me at all numbers!";
            }
            else if (numbers.Count() < 3) 
            {
                return "You gave less then 3 numbers.\nTry again.";
            }
            foreach (float num in numbers)
            {
                if (num < 0)
                {
                    return $"{num} is an negative number. Try again. ONLY POSITIVE NUMERS.";
                }
            }
            return "excellent";
        }
        static void ConvertToList(Dictionary<int, object> _dict)
        {
            List<float> numbers = (List<float>)_dict[3];
            string str_num = (string) _dict[0];
            string[] arr_nums = str_num.Split(" ");

            foreach (string num in arr_nums)
            {
                float num_int;
                try 
                {
                    num_int = (float)Convert.ToDouble(num);
                    numbers.Add(num_int);
                }
                catch //if contains leeters or special symbols
                {
                    string decompision_num = "";
                    bool possible_point = true;
                    foreach (char c in num) //ignore of non digits. but may be without digits.
                    {
                        if (Char.IsDigit(c))
                        {
                            decompision_num += c;
                        }
                        if (c=='.' && possible_point)
                        {
                            decompision_num += c;
                            possible_point = false;
                        }
                    }
                    if (decompision_num.Length > 0) //validate, that it's will include digits
                    {
                        num_int = (float)Convert.ToDouble(decompision_num);
                        numbers.Add(num_int);
                    }
                }
                _dict[3] = numbers;
            }


        }

        static void Menu(Dictionary<int, object> _dict)
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
                        RequestUser_input(_dict, true);
                        infinity = false;
                        break;
                    case "2":
                        Console.WriteLine("Challange except1");
                        PrintOrder(_dict);
                        infinity = false;
                        break;
                    case "3":
                        Console.WriteLine("Challange except1");
                        PrintReversed(_dict);
                        infinity = false;
                        break;
                    case "4":
                        Console.WriteLine("Challange except1");
                        PrintSorted(_dict);
                        infinity = false;
                        break;
                    case "5":
                        Console.WriteLine("Challange except1");
                        Max(_dict);
                        infinity = false;
                        break;
                    case "6":
                        Console.WriteLine("Challange except1");
                        Min(_dict);
                        infinity = false;
                        break;
                    case "7":
                        Console.WriteLine("Challange except1");
                        Avaerge(_dict);
                        infinity = false;
                        break;
                    case "8":
                        Console.WriteLine("Challange except1");
                        Count(_dict);
                        infinity = false;
                        break;
                    case "9":
                        Console.WriteLine("Challange except1");
                        Sum(_dict);
                        infinity = false;
                        break;
                    case "10":
                        Console.WriteLine("GOOD BYE!");
                        _dict[2] = false;
                        infinity = false;
                        break;
                    default:
                        Console.WriteLine("Try again!!");
                        continue;
                }
            }
        }


        static void PrintOrder(Dictionary <int, object> _list_numbers)
        {
            foreach(float num in (List<float>)_list_numbers[3])
            {
                Console.WriteLine(num);
            }
        }

        static void PrintReversed(Dictionary<int, object> _dict)
        {
            List<float> _list_numbers = (List<float>)_dict[3];

            for (int i = 0; i < _list_numbers.Count(); i++)
            {
                Console.WriteLine(_list_numbers[_list_numbers.Count()-i-1]);
            }
        }

        static void PrintSorted(Dictionary<int, object> _dict)
        {
            List<float> neww = (List<float>)_dict[3];
            neww.Sort();
            foreach(float num in neww)
            {
                Console.WriteLine(num);
            }
        }

        static void Max(Dictionary<int, object> _dict)
        {
            List<float> _list_numbers = (List<float>)_dict[3];
            float max = -1;
            foreach (float num in _list_numbers)
            {
                if (max < num)
                {
                    max = num;
                }

            }
            Console.WriteLine(max);
        }

        static void Min(Dictionary<int, object> _dict)
        {
            List<float> _list_numbers = (List<float>)_dict[3];
            float min = 214748367;
            foreach (float num in _list_numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            Console.WriteLine(min);
        }

        static void Avaerge(Dictionary<int, object> _dict)
        {
            List<float> _list_numbers = (List<float>)_dict[3];
            int sum = 0;
            foreach (int num in _list_numbers)
            {
                sum += num;
            }
            Console.WriteLine(sum/_list_numbers.Count());
        }

        static void Count(Dictionary<int, object> _dict)
        {
            List<float> _list_numbers = (List<float>)_dict[3];
            int sum = 0;
            foreach (int num in _list_numbers)
            {
                sum += 1;
            }
            Console.WriteLine(sum);
        }

        static void Sum(Dictionary<int, object> _dict)
        {
            List<float> _list_numbers = (List<float>)_dict[3];
            int sum = 0;
            foreach (int num in _list_numbers)
            {
                sum += num;
            }
            Console.WriteLine(sum);
        }


        static void Main(string[] args)
        {
            Run(args);
        }
    }
}
