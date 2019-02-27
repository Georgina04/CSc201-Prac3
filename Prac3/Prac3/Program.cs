using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericSet<string> s = new GenericSet<string>();

            s.Add("cat");
            s.Add("dog");
            Console.WriteLine(s);
            s.Add("cat");
            Console.WriteLine(s);
            s.Remove(1);
            Console.WriteLine(s);
            Console.WriteLine(s.Length());
            Console.Read();
           
        }
    }
}
