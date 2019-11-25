using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonWpfConsole
{
    public class Class2 : Class1
    {
        private String att1;

        public new string Att1 { get => att1; set => att1 = value; }

        public override void DoSomething()
        {
            Console.WriteLine("hey");
        }
    }
}
