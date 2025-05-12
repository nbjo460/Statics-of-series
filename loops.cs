//using System;

//class loops
//{

//    static void Main(string[] args)
//    {


//        ////1
//        //for (int i = 1; i <= 10; i++)
//        //{
//        //    Console.WriteLine(i);
//        //}

//        ////2
//        //for (int i = 1; i <=100; i++)
//        //{
//        //    if(i % 2 == 0)
//        //    {
//        //        Console.WriteLine(i);
//        //    }
//        //}

//        ////3
//        //string[] names = { "אברהם", "שמעון", "אפריים" };
//        //foreach(string name in names)
//        //{
//        //    if (name[0] == 'א')
//        //    {
//        //        Console.WriteLine(name);
//        //    }
//        //}



//        ////1
//        //for (int i = 1;i <=5; i++)
//        //{
//        //    Console.WriteLine(i);
//        //}

//        ////2
//        //bool ten = true;
//        //int i = 0;
//        //while (ten)
//        //{
//        //    i += 2;
//        //    Console.WriteLine(i);
//        //    if (i==10)
//        //    {
//        //        ten = false;
//        //    }
//        //}


//        ////3
//        //int i = Convert.ToInt32(Console.ReadLine());
//        //Console.WriteLine(i % 2 == 0 ? "eval" : "odd");

//        ////4
//        //bool end = true;
//        //while (end)
//        //{
//        //    string input = Console.ReadLine();
//        //    if (input == "סיום")
//        //    {
//        //        end = false;
//        //    }
//        //}

//        ////5
//        //string access = "allow";
//        //for (int i = 0; i < 10; i++)
//        //{
//        //    Console.WriteLine(i+1 +". " + access);
//        //}


//        ////6
//        //for (int i = 1; i<+20; i++)
//        //{
//        //    if(i%3 != 0)
//        //    {
//        //        Console.WriteLine(i);
//        //    }
//        //}

//        ////7
//        //int i = 5;
//        //while (i>0)
//        //{
//        //    Console.WriteLine(i);
//        //    i--;
//        //}



//        ////8
//        //for(int i = 1; i<=10; i++)
//        //{
//        //    if (i % 2 == 0)
//        //    {
//        //        Console.WriteLine("eval");
//        //    }
//        //    else
//        //    {
//        //        Console.WriteLine("odd");
//        //    }
//        //}



//        ////9
//        //int num = Convert.ToInt32(Console.ReadLine());
//        //if (num == 8200)
//        //{
//        //    Console.WriteLine("safe");
//        //}



//        ////10
//        //string admin = "admin";
//        //bool run = true;
//        //while (run)
//        //{
//        //    string input = Console.ReadLine();
//        //    if (admin == input)
//        //    {
//        //        run = false;
//        //    }
//        //}


//        ////11
//        //int num = 0;
//        //for(int i = 1; i<=100; i++)
//        //{
//        //    if (i % 7 == 0)
//        //    {
//        //        num++;
//        //    }
//        //}
//        //Console.WriteLine(num);

//        ////12
//        //string password = Console.ReadLine();
//        //if (password.Length == 8)
//        //{
//        //    Console.WriteLine("yes");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("no");
//        //}


//        ////13
//        //string str = Console.ReadLine();
//        //foreach (char s in str)
//        //{
//        //    if (char.IsLetter(s))
//        //    {
//        //        Console.Write(s);
//        //    }
//        //}



//        ////14
//        //bool strong = true;
//        //while (strong)
//        //{
//        //    string a = Console.ReadLine();
//        //    if(a.Length >= 8)
//        //    {
//        //        strong = false;
//        //    }
//        //}

//        ////15
//        //for (int i = 1; i <= 100; i++)
//        //{
//        //    for (int j = 2; j<i; j++)
//        //    {
//        //        if (i % j == 0)
//        //        {
//        //            Console.WriteLine(i + " is NOT PRIME"+j);
//        //            break;
//        //        }
//        //        else
//        //        {
//        //            if (i == j+1)
//        //            {
//        //                Console.WriteLine(i + "PRIME");
//        //            }
//        //        }
//        //    }
//        //}


//        ////16
//        //string pass = "123wer";
//        //for (int i =0; i<=2; i++)
//        //{
//        //    string str = Console.ReadLine();
//        //    if (str != pass)
//        //    {
//        //        if (i == 2)
//        //        {
//        //            Console.WriteLine("AccessDenied");
//        //        }
//        //    }
//        //}

//        ////17
//        //string  str = Console.ReadLine();
//        //int sum = 0;
//        //foreach (char c in str)
//        //{
//        //    if (char.IsDigit(c))
//        //    {
//        //        sum += 1;
//        //    }
//        //}
//        //Console.WriteLine(sum);



//        ////18
//        //for (int i = 1; i <= 50; i++)
//        //{
//        //    if (i % 10 == 0)
//        //    {
//        //        Console.WriteLine(i);
//        //    }
//        //}



//        ////19
//        //int sum = 0;
//        //bool negative = true;
//        //while (negative)
//        //{
//        //    int i = Convert.ToInt32(Console.ReadLine());
//        //if (i < 0 )
//        //    {
//        //        negative = false;
//        //    }
//        //    else
//        //    {
//        //        sum += i;
//        //    }
//        //}
//        //Console.WriteLine(sum);





//        ////20
//        //string str = Console.ReadLine();
//        //int len = str.Length;
//        //string newpass = "";
//        //for (int i =0; i < len; i++)
//        //{
//        //    newpass += '*';
//        //}
//        //Console.WriteLine(newpass);


//        //        //21
//        //        string[] ranks = {
//        //    "1סגן משנה",
//        //    "סגן2",
//        //    "3סרן",
//        //    "4רב סרן",
//        //    "סגן אלוף5",
//        //    "יציאה6"
//        //};
//        //        bool run = true;
//        //        while (run)
//        //        {
//        //            foreach (string opt in ranks)
//        //            {
//        //                Console.WriteLine(opt);
//        //            }

//        //            int choice = Convert.ToInt32(Console.ReadLine());
//        //            switch (choice)
//        //            {
//        //                case 1:
//        //                    Console.WriteLine("1");
//        //                    continue;
//        //                case 2:
//        //                    Console.WriteLine("2");
//        //                    continue;
//        //                case 3:
//        //                    Console.WriteLine("3");
//        //                    continue;
//        //                case 4:
//        //                    Console.WriteLine("4");
//        //                    continue;
//        //                case 5:
//        //                    Console.WriteLine("5");
//        //                    continue;
//        //                case 6:
//        //                    Console.WriteLine("EXIT");
//        //                    run = false;
//        //                        break;
//        //                default:
//        //                    Console.WriteLine("no in list");
//        //                    continue;
//        //            }

//        //        }


//        ////22
//        //string usr = "user";
//        //string pas = "pass";
//        //string username = Console.ReadLine();
//        //string password = Console.ReadLine();
//        //if (usr == username && pas == password)
//        //{
//        //    Console.WriteLine("nicee");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("not nice");
//        //}


//        ////23
//        //Random rnd = new Random();
//        //string password = "";
//        //for (int i = 1; i <= 6; i++)
//        //{
//        //    int number = rnd.Next(0, 9);
//        //    password += number;
//        //}
//        //Console.WriteLine(password);



//        ////24
//        //bool letter = false;
//        //bool digit = false;
//        //string str = Console.ReadLine();
//        //foreach (char a in str)
//        //{
//        //    if (char.IsLetter(a))
//        //    {
//        //        letter = true;
//        //    }
//        //    if (char.IsDigit(a))
//        //    {
//        //        digit = true;
//        //    }
//        //}
//        //if (letter && digit)
//        //{
//        //    Console.WriteLine("SAFE");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("NOT SAFE");
//        //}


//        ////25
//        //string a = Console.ReadLine();
//        //int len = a.Length;
//        //string b = "";
//        //foreach (char c in a)
//        //{
//        //    if (char.IsDigit(c))
//        //    {
//        //        b += "digit";
//        //    }
//        //    else
//        //    {
//        //        b += c;
//        //    }
//        //}
//        //Console.WriteLine(b);



//        ////26
//        //string a = "8200";
//        //string b = Console.ReadLine();
//        //bool yes = false;
//        //foreach (char aa in a)
//        //{
//        //    foreach(char bb in b)
//        //    {
//        //        if (bb == aa)
//        //        {
//        //            yes = true;
//        //        }
//        //    }
//        //}
//        //if (yes)
//        //{
//        //    Console.WriteLine("YES");
//        //}

//        //else
//        //{
//        //    Console.WriteLine("NO");
//        //}





//        ////27
//        //string a = Console.ReadLine();
//        //int sum = 0;
//        //foreach(char c in a)
//        //{
//        //    if (c == 'a')
//        //    {
//        //        sum += 1;
//        //    }
//        //}
//        //Console.WriteLine(sum);




//        ////28
//        //bool run = true;

//        //while (run)
//        //{
//        //    string a = Console.ReadLine();

//        //    if (a[0] == '8'&&a.Length == 4)
//        //    {
//        //        run = false;
//        //    }
//        //}


//        ////29
//        //string a = Console.ReadLine();
//        //bool special = false;
//        //foreach (char c in a)
//        //{
//        //    if (char.IsSymbol(c) || char.IsPunctuation(c)) 
//        //    {
//        //        special = true;
//        //    }
//        //}
//        //if (special)
//        //{
//        //    Console.WriteLine("YES");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("NO");
//        //}


//        ////30
//        //string[] lista = new string [5];
//        //string[] listi = new string [5];

//        //for (int i = 0; i < 5; i++)
//        //{
//        //    lista[i] = Console.ReadLine();
//        //}
//        //for(int i = 0; i < 5; i++)
//        //{
//        //    string b = "";
//        //    for (int j = 0; j < lista[i].Length; j++)
//        //    {
//        //        b += "*";
//        //    }
//        //    listi[i] = b;
//        //}

//        //foreach(string a in listi)
//        //{
//        //    Console.WriteLine(a);
//        //}

//        ////31
//        //string password = Console.ReadLine();
//        //bool len = false;
//        //bool digits = false;
//        //bool letters = false; 
//        //bool special = false;

//        //foreach(char c in password)
//        //{
//        //    if (char.IsLetter(c))
//        //    {
//        //        letters = true;
//        //    }
//        //    if (char.IsDigit(c))
//        //    {
//        //        digits = true;
//        //    }
//        //    if (char.IsSymbol(c) || char.IsPunctuation(c))
//        //    {
//        //        special = true;
//        //    }

//        //}
//        //if (password.Length >= 8) 
//        //{
//        //    len = true;
//        //}

//        //if (len && special && letters && digits)
//        //{
//        //    Console.WriteLine("GOOD");
//        //}
//        //else
//        //{
//        //    Console.WriteLine("BAD");
//        //}





//    }
//}