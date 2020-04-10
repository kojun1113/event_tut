using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ConsoleApp2_debugg
{

    class Debugg {

        public string name;
        public Debugg(string s) {
            name = s;
        }
        public Debugg() { name = "default name"; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Debugg d = new Debugg() ;
            Console.WriteLine(d.name);
            

        }
    }


}
