using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonWpfConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Class1 c1 = new Class1();
            c1.Att1 = "coucou";
            c1.Att2 = 10;

            Class2 c2 = new Class2();
            c2.Att1 = "hey";
            (c2 as Class1).Att1 = "toto";
            c2.Att2 = 15;

            Console.WriteLine(c2.Att1);
            Console.WriteLine((c2 as Class1).Att1);

            c2.DoSomething();
            (c2 as Class1).DoSomething();

            Console.ReadLine();
        }
    }
}
