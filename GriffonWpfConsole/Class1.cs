using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GriffonWpfConsole
{
    public class Class1
    {
        private String att1;
        private int att2;

        public string Att1 { get => att1; set => att1 = value; }
        public int Att2 { get => att2; set => att2 = value; }

        public virtual void DoSomething()
        {
            Console.WriteLine("coucou");
        }
    }
}
