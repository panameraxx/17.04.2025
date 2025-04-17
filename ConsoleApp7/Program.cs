using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Talk1 talk1 = new Talk1();
            Talk2 talk2 = new Talk2();
            talk1.Think1();
            talk2.Think2();
            talk1.Think2();
            Console.ReadKey();

        }
    }
}
