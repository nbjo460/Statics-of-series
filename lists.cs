//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tutorial
//{
//    internal class lists
//    {

//        static void name(string _name)
//        {
//            Console.WriteLine(_name);
//        } 

//        static int rnd()
//        {
//            Random r = new Random();
//            int rt = r.Next();
//            return rt;
//        }

//        static int age(string _date)
//        {

//            DateTime dt = DateTime.Parse(_date);
//            DateTime now = DateTime.Now;

//            TimeSpan span = now - dt;
//            return (int)span.TotalDays / 365;
//        }

//        static void entaranced(Dictionary<string, bool> names ,string _name, bool inside ,bool entry)
//        {
//            //want to entry
//            if (entry)
//            {
//                //an exisy guy want to get in
//                if (names.ContainsKey(_name))
//                {
//                    //his card registered as inside
//                    if (!names[_name]) 
//                    {
//                        Console.WriteLine("YOURS CARD INSIDE. TOU CANT GET IN AGAIN");
//                    }
//                    //his card registered as outside
//                    else
//                    {
//                        Console.WriteLine("WELCOME!");
//                        names[_name] = true;
//                    }
//                }
//                //an unexist guy want to get in
//                else
//                {
//                    Console.WriteLine("not have an access");
//                }
//            }
//            //want to exit
//            else
//            {
//                //if his name in access list
//                if (names.ContainsKey(_name))
//                {
//                    // if he need to be inside
//                    if (names[_name])
//                    {
//                        Console.WriteLine("GOODBYE");
//                        names[_name] = false;
//                    }
//                    // must be outsisde
//                    else
//                    {
//                        Console.WriteLine("Errorr. must be outside!");
//                    }
//                }
//                //his name not in access list
//                else
//                {
//                    Console.WriteLine("ERRORRRRRRRRRRRR!!!!");
//                }
//            }
//        }

//        static void manage_passing(bool _trying_entry, Dictionary<string, Dictionary<string, bool>> _acc, string _name)
//        {

//            Dictionary <string, bool> user = get_user(_acc, _name);

//            if (_trying_entry)
//            {
//                get_in(user);
//            }
//            else
//            {
//                get_out(user);
//            }

//        }

//        static Dictionary<string, bool> get_user(Dictionary<string, Dictionary<string, bool>> _acc, string _name)
//        {
//            try
//            {
//                return _acc[_name];
//            }
//            catch(Exception)
//            {
//                throw new Exception ("There is no user ike that.");
//            }
//        }

//        static void get_in(Dictionary<string, bool> _user)
//        {
//            if (_user["is inside"])
//            {
//                throw new Exception("You are already inside the building. Security!!!"); 
//            }
//            else
//            {
//                Console.WriteLine("Welcome");
//                _user["is inside"] = true;
//            }
//        }
//        static void get_out(Dictionary<string, bool> _user)
//        {
//            if (_user["is inside"])
//            {
//                _user["is inside"] = true;
//                Console.WriteLine("GoodBye");
//            }
//            else
//            {
//                throw new Exception("You are should be outside. Security!!!!");
//            }
//        }

//        static Dictionary<string, bool> new_user()
//        {
//            Dictionary<string, bool> newItem= new Dictionary<string, bool> ();
//            newItem.Add ( "is inside", false );
//            return newItem;
//        }

        

//        static void Main(string[] args)
//        {
//            //1 pptx

//            //string[] weapons = { "rocket", "drone", "tank" };

//            //int num_houses = new Random().Next(0, 100);
//            //List<string> houses = new List<string>();


//            //    for (int i = 0; i < num_houses; i++)
//            //    {
//            //        houses.Add("house num: " + (i+1));
//            //    }
//            //while (houses.Count() > 0)
//            //{
//            //    Console.WriteLine($"you have {houses.Count()} hamas houses. how may to destroy?");
//            //    int destroy = Convert.ToInt32(Console.ReadLine());
//            //    if (destroy > num_houses)
//            //    {
//            //        Console.WriteLine("ERROR, YOU DON'T HAVE AENOUGH HOUSES");
//            //    }
//            //    else
//            //    {
//            //        Random rnd = new Random();


//            //        for (int i=0; i < destroy; i++)
//            //        {
//            //            int weapon = rnd.Next(0, 3);
//            //            int atck = rnd.Next(houses.Count());
//            //            string attack = $"{houses[atck]} was attacked by {weapons[weapon]}";
//            //            Console.WriteLine(attack);
//            //            houses.RemoveAt(atck);
//            //        }
//            //    }
//            //} 


//            ////1 WORK
//            //List<string> names = new List<string>() {"Dnaiel", "Moshe", "Yossi", "Dan", "Efraim" };
//            //names.Add("Menachem");
//            //names.Add("Yagel");
//            //names.Remove("Moshe");
//            //foreach (string name in names)
//            //{
//            //    Console.WriteLine(name);
//            //}


//            ////2
//            //Dictionary<string, int> store = new Dictionary<string, int>();
//            //store.Add("Milk", 6);
//            //store.Add("Bread", 7);
//            //store.Add("Chocko", 3);
//            //store["Chocko"] = 10;
//            //foreach (KeyValuePair<string, int> item in store)
//            //{
//            //    Console.WriteLine($"{item.Key} has {item.Value} quantities");
//            //}



//            ////3
//            //List<Dictionary<string, string>> user = new List<Dictionary<string, string>>();

//            //user.Add(new Dictionary<string, string>{ 
//            //    { "name", "" }, 
//            //    {"email", "nbjo2460@gmail.com" }, 
//            //    {"status", ""} 
//            //});

//            //user.Add(new Dictionary<string, string>
//            //{
//            //    {"name", "" },
//            //    {"email", "nbjo460@gmail.com" },
//            //    {"status", "" }
//            //});



//            //foreach (Dictionary <string, string> username in user)
//            //{
//            //    Console.WriteLine(username["email"]);
//            //}


//            ////4
//            //List<string> users = new List<string>();
//            //users.Add("gs");
//            //users.Add("gadsas");
//            //users.Add("g    323s");
//            //users.Add("g2s");
//            //string get = Console.ReadLine();

//            //int index = -1;
//            //bool exist = false;
//            //foreach(string user in users)
//            //{
//            //    index++;
//            //    if (user == get)
//            //    {
//            //        exist = true;
//            //        break;
//            //    }
//            //}
//            //if (exist)
//            //{
//            //    Console.WriteLine(get + index);
//            //}
//            //else
//            //{
//            //    Console.WriteLine("no");
//            //}




//            ////5
//            //Dictionary<string, Dictionary<string, bool>> students = new Dictionary<string, Dictionary<string, bool>>();

//            //Dictionary<string, bool> new_items()
//            //{
//            //    return new Dictionary<string, bool>
//            //{
//            //    {"recorder", false},
//            //    {"map", false},
//            //    {"notebook", false}
//            //};
//            //}
//            //students.Add("Avi", new_items());
//            //students.Add("Moshe", new_items());
//            //students.Add("Notebook", new_items());

//            //students["Avi"]["recorder"] = true;
//            //students["Avi"]["map"] = true;
//            //students["Avi"]["notebook"] = true;

//            //foreach (var student in students)
//            //{
//            //    if (student.Value["recorder"] && student.Value["map"] && student.Value["notebook"])
//            //    {
//            //        Console.WriteLine($"{student.Key}");

//            //    }
//            //}



//            //Console.WriteLine(age("12/15/2000"));
//            //name("Menachem");
//            //Console.WriteLine(rnd());



//            Dictionary<string, Dictionary<string, bool>> acc = new Dictionary<string, Dictionary<string, bool>>();


//            acc.Add("Menachem",new_user());
//            acc.Add("Daniel", new_user());
//            acc.Add("Rafi", new_user());
//            acc.Add("Yossi", new_user());

//            manage_passing(true ,acc, "Menachem");
//            manage_passing(false, acc, "Daniel");
//            manage_passing(true, acc, "Rafi");
//            manage_passing(true, acc, "Yossi");







//        }
//    }
//}
