//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Tutorial
//{
//    internal class Magic
//    {
//        static void Main(string[] args)
//        {
//            ////1
//            //int temperature = 78;
//            //int toxicity = 40;
//            //int colorCode = 5;
//            //int glowLevel = 6;

//            //double baseScore = (double)(100 - toxicity) + glowLevel * 3 - Math.Abs(colorCode - 7) * 2;

//            //bool great = baseScore > 80;
//            //bool dangerouse = temperature > 90 || toxicity > 70;
//            //bool rare = colorCode == 7 && glowLevel > 7;

//            //bool safe = great && !dangerouse;
//            //bool extra = false;

//            //if (rare && safe)
//            //{
//            //    baseScore += 10;
//            //}
//            //if (temperature - toxicity > 50 || toxicity - temperature > 50)
//            //{
//            //    baseScore -= 5;
//            //}
//            //if (glowLevel == colorCode)
//            //{
//            //    baseScore += 7;
//            //}
//            //if (temperature > 100)
//            //{
//            //    baseScore -= 15;
//            //}

//            //if (toxicity > 30 && glowLevel >= 8 && (temperature > 65 && temperature <= 85))
//            //{
//            //    baseScore += 12;
//            //    extra = true;
//            //}

//            //Console.WriteLine($"Score is: {baseScore} \n." +
//            //    $"extra {extra}\n" +
//            //    $"great {great}\n" +
//            //    $"dangerouse {dangerouse}\n" +
//            //    $"rare  {rare}\n" +
//            //    $"safe {safe}");


//            ////2
//            //Random rnd = new Random();
//            //int stealth = rnd.Next(0, 100);
//            //int health = rnd.Next(0, 100);
//            //int dangerLevel = rnd.Next(0, 100);
//            //int tools = rnd.Next(0, 5);

//            //double score = (double)stealth + tools * 5 - dangerLevel / 2;

//            //if(health < 50)
//            //{
//            //    score -= 10;
//            //}
//            //if (health >90 && dangerLevel < 30)
//            //{
//            //    score += 15;
//            //}
//            //if (stealth > 80&& tools>= 2)
//            //{
//            //    score += 8;
//            //}
//            //if (dangerLevel > 80)
//            //{
//            //    score -= 12;
//            //}
//            //if(tools == 0)
//            //{
//            //    score -= 5;
//            //}
//            //if(dangerLevel > 80& stealth > 85)
//            //{
//            //    score += 5;
//            //}

//            //string escapeStatus;
//            //if (score <0 || score > 100)
//            //{
//            //    Console.WriteLine("score is out of range");
//            //}
//            //else
//            //{
//            //    Console.WriteLine(score>90? "perfect survive": score <= 90 && score >70 ? "survived": score <=7 && score >50? "injured": "caught");
//            //}

//        }
//    }
//}
