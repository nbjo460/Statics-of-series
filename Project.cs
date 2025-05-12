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

            dict.Add(0, dict);
            dict.Add(1, numbers);



        }








        static void Main(string[] args)
        {
            run();
        }










    }
}
