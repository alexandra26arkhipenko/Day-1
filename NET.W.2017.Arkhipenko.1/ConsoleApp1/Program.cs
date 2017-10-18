using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University;

namespace ConsoleStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Students("Arkhipenko", "RFiCT");
            Console.WriteLine(student.ToString());
            Console.ReadKey();
        }
    }
}
