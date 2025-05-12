//using System;

//namespace Tutorial
//{
//    class Condition
//    {
//        static void Main(string[] args)
//        {
            //1 מצגת

            //bool age = false;
            //bool color = false;
            //bool height = false;
            //bool job = false;



            //for (int i = 0; i < 3; i++)
            //{



            //    Console.WriteLine("enter an age");
            //    int ageClient = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("enter a height");
            //    int heightClient = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("enter a color");
            //    string colorClient = Console.ReadLine();


            //    Console.WriteLine("enter a job");
            //    string jobClient = Console.ReadLine();




            //    if (ageClient > 24 && ageClient < 51)
            //    {
            //        age = true;
            //    }
            //    if (heightClient > 169 && heightClient < 186)
            //    {
            //        height = true;
            //    }
            //    if (colorClient == "brown" || colorClient == "black")
            //    {
            //        color = true;
            //    }
            //    if (jobClient == "doctor" || jobClient == "hospital manager")
            //    {
            //        job = true;
            //    }


            //    if (job && color && height && age)
            //    {
            //        Console.WriteLine("Found an imposter!!");
            //        break;
            //    }
            //    job = false;
            //    color = false;
            //    height = false;
            //    age = false;

            //    Console.WriteLine($"not imposter. remained {2 - i} to checked");





            //דף עבודה
            ////1
            //Console.WriteLine("Enter num");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num > 0 ? "positive" : "negative");


            ////2
            //Console.WriteLine("Enter first num");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter first num");
            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"this is the largest{Math.Max(a, b)}");


            //3
            //Console.WriteLine("enter grade");
            //int grade = Convert.ToInt32(Console.ReadLine());

            //if (grade >= 90)
            //{
            //    Console.WriteLine("Great");
            //} else if(grade >= 75 && grade <= 89)
            //{
            //    Console.WriteLine("Very good");
            //}
            //else 
            //{
            //    Console.WriteLine("Need to Study");
            //}


            ////4
            //Console.WriteLine("entaer num of day");
            //int day = Convert.ToInt32(Console.ReadLine());
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("sunday");
            //        break;
            //    case 2:
            //        Console.WriteLine("Monday");
            //        break;
            //    case 3:
            //        Console.WriteLine("shlishi");
            //        break;
            //    case 4:
            //        Console.WriteLine("Wendsday");
            //        break;
            //    case 5:
            //        Console.WriteLine("Chamishi");
            //        break;
            //    case 6:
            //        Console.WriteLine("Friday");
            //        break;
            //    case 7:
            //        Console.WriteLine("Saturday");
            //        break;
            //    default:
            //        Console.WriteLine("WRONG");
            //        break;
            //}


            ////5
            //Console.WriteLine("rnter temperature");
            //int temp = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(temp > 30 ? "HOT" : temp >= 20 && temp <= 30 ? "NAIM" : "realy naim");


            ////6
            //Console.WriteLine("enter age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age < 17 ? "Cant't get license" : "allowed to drive");


            ////7
            //Console.WriteLine("give a number");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num %2==0? "eval" : "odd");

            ////8
            //Console.WriteLine("entar 1 char");
            //string a = Console.ReadLine();
            //char c = a[0];
            //Console.WriteLine(char.IsUpper(c) ? "low" : char.IsLower(c) ? "up" : "not a letter");

            ////9
            //Console.WriteLine("enter sum");
            //double r = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(r < 100 ? r : (r>100&&r<=500) ? r*0.95 : r> 500 ? r*0.9 : r);



            ////10
            //Console.WriteLine("choose: login, register, exit");
            //string str = Console.ReadLine();
            //switch (str)
            //{
            //    case "login":
            //        Console.WriteLine("1");
            //        break;
            //    case "register":
            //        Console.WriteLine("2");
            //        break;
            //    case "exit":
            //        Console.WriteLine("3");
            //        break;
            //    default:
            //        Console.WriteLine("4");
            //        break;
            //}



            ////11
            //Console.WriteLine("age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age < 13?"boy" : age<17&&age>=13? "naar" : age >=18 ? "adult" : "");

            ////12
            //Console.WriteLine("enter 3 numbers");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //int maxa;
            //int maxb;
            //int maxc;

            //if (a >= b)
            //{
            //    if(a >= c)
            //    {
            //        maxa = a;
            //    }
            //    else
            //    {
            //        maxa = c;
            //    }
            //}
            //else
            //{
            //    if (b >= c)
            //    {
            //        maxa = b;
            //    }
            //    else
            //    {
            //        maxa = c;
            //    }
            //}
            //Console.WriteLine(maxa);

            ////13
            //Console.WriteLine("enter num");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num % 3 ==0 && num %3 == 0)
            //{
            //    Console.WriteLine("FizzBuzz");
            //}
            //else if(num%5==0){
            //    Console.WriteLine("Buzz");
            //} else if (num%3==0) {
            //    Console.WriteLine("Fizz");
            //}
            //else
            //{
            //    Console.WriteLine(num);
            //}


            ////14
            //    Console.WriteLine("Enter a hour");
            //    int hour = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(hour >= 5 && hour <= 11 ? "good morning" : hour >= 12 && hour <= 17 ? "good miday" : hour >= 18 && hour <= 21 ? "good afternoon" : ((hour == 22 || hour == 23) || hour >= 0 && hour <= 5) ? "good night" : "error");

            ////15
            //Console.WriteLine("Enter NUMBER");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(num >= 50 && num <=100 ? "yes" : "no");



            //    //16
            //    Console.WriteLine("enter color");
            //    string color = Console.ReadLine();
            //    switch (color)
            //    {
            //        case "red":
            //            Console.WriteLine("red");
            //            break;
            //        case "green":
            //            Console.WriteLine("green");
            //            break;
            //        case "blue":
            //            Console.WriteLine("blue");
            //            break;
            //    }


            ////17
            //string user_name = "N1N1N1";
            //string password = "1111";

            //Console.WriteLine("ENTER USERNAME");
            //string username_input = Console.ReadLine();
            //Console.WriteLine("ENTER PASSWORD");
            //string password_input = Console.ReadLine();

            //if (username_input == user_name && password_input == password) {
            //    Console.WriteLine("SUCCSESFULL LOGIN");
            //}
            //else
            //{
            //    Console.WriteLine("Login Failed");
            //}

            ////18
            //Console.WriteLine("give a number");
            //string num = Console.ReadLine();

            //if(int.TryParse(num, out int number))
            //{
            //    Console.WriteLine(number >=0 ? "positive" : "negative");
            //}
            //else
            //{
            //    Console.WriteLine("is not");
            //}



            ////19
            //Console.WriteLine("enter word");
            //string word = Console.ReadLine();

            //if(word[0] == 'A'|| word[0] == 'a')
            //{
            //    Console.WriteLine("start with a/A");
            //}
            //else{
            //    Console.WriteLine("Not start with");
            //}

            ////20
            //Console.WriteLine("Give ma a score");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if ((score > 0) && ((score>=300)))
            //{
            //    Console.WriteLine("BEGGINER");
            //}
            //else if (score >=301 && score <=700)
            //{
            //    Console.WriteLine("Medium");
            //}
            //else if (score > 700)
            //{
            //    Console.WriteLine("Experiment");
            //}


//        }


//    }
//}
