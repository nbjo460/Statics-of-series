// 1
//Console.WriteLine("Please enter a string");
//string a = Console.ReadLine();
//Console.WriteLine(a.Length);

//if (a.Contains("admin"))
//{
//    Console.WriteLine("Contain");
//}
//else
//{ 
//    Console.WriteLine("not contain admin"); 
//}

//string b = "user";
//for (int i = 0; i < 4; i++)
//{
//    char c = b[i];
//    if (c != a[i])
//    {
//        Console.WriteLine("Not start with user");
//        break;
//    }
//    else
//    {
//        if (i == 3)
//        {
//            Console.WriteLine("start with user");
//        }
//    }
//}
//    Console.WriteLine(a.ToUpper());

////2
//Console.WriteLine("enae a number");
//int a = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("enae a number");
//int b = Convert.ToInt32(Console.ReadLine());

//double c = a / b;
//double d = a % b;
//double e = (double)a / b;
//Console.WriteLine($"{c}\n{d}\n{e}");

////3
//Console.WriteLine("enter a number");
//int a = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("enter a number");
//int b = Convert.ToInt32(Console.ReadLine());


//Console.WriteLine("enter a number");
//int c = Convert.ToInt32(Console.ReadLine());

//int maxA;
//int maxB;

//maxA = Math.Max(a, b);
//maxB = Math.Max(maxA, c);

//Console.WriteLine(maxB);


//int mina;
//int minb;

//mina = Math.Min(a, b);
//minb = Math.Min(mina, c);

//Console.WriteLine(a+b+c-maxB-minb);
//Console.WriteLine(minb);

////4
//Console.WriteLine("enter a word");
//string word = Console.ReadLine();
//int len = word.Length;
//if (len >= 4)
//{
//    Console.Write(word.Substring(0, 2));
//    Console.Write(word.Substring(len - 2, 2));
//}


////5
//Console.WriteLine("enter a NUMNER");
//int num = Convert.ToInt32(Console.ReadLine());
//if (num %2==0 || num % 10 == 7)
//{
//    Console.WriteLine("YES");
//}
//else
//{
//    Console.WriteLine("NO");
//}

//6
//Console.WriteLine("enter a calculation question");
//string calc = Console.ReadLine();
//string[] parts = calc.Split(' ');

//int a = int.Parse(parts[0]);
//int b = int.Parse(
//parts[2]);

//int sum = 0;
//switch (parts[1])
//{
//    case "+":
//        sum = a + b;
//        break;

//    case "-":
//        sum = a - b;
//        break;
//    case "*":
//        sum = a * b;
//        break;
//    case "/":
//        sum = a / b;
//        break;
//    case "%":
//        sum = a % b;
//        break;

//    default:
//        break;
//}

//Console.WriteLine(sum);

////7
//Console.WriteLine("Enter an UserName");
//string username = Console.ReadLine();
//string up = username.ToUpper();

//if ((username.Length > 5) && 
//    (up[0] == username[0]) &&
//    (!char.IsDigit(up[^1])))
//{
//    Console.WriteLine("valid username");
//}
//else
//{
//    Console.WriteLine("not valid");
//}

////8
//Console.WriteLine("enter heigt");
//int height = Convert.ToInt32(Console.ReadLine());
//int weight = Convert.ToInt32(Console.ReadLine());

//double bmi = (double)weight / Math.Pow(height, 2);

//if (bmi < 18.5)
//{
//    Console.WriteLine("LOW WEIGHT");
//}
//else if (bmi >= 18.5 && bmi <= 24.9)
//{
//    Console.WriteLine("good");
//}
//else if (bmi > 24.9)
//{
//    Console.WriteLine("much more weight");
//}

