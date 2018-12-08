using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuisine
{
    class Program
    {
        static void Main(string[] args)
        {
            Machines test = new Machines("test", 35);
            test.start(0);
            Console.WriteLine(test.isRunning());
            Console.ReadLine();
        }
    }
}
