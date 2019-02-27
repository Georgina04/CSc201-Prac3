using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac3
{
    class Program
    {
        static void Main(string[] args)
        {
            //tester();   //tester for new class
            SpellCheck();
            Console.Read();
            
           
        }

        public static void SpellCheck()
        {
            GenericSet<string> Dictionary = new GenericSet<string>();

            string[] delimiters = { ",", ".", "!", "?", ";", ":",
                        " ", "\"", "'", "_", "(", ")",
                        "[", "]", "{", "}", "*", "#",
                        "&", "`", "-" };

            TextReader file = File.OpenText("..\\..\\..\\wordlist");
            while (true)
            {
                string line = file.ReadLine();
                if (line == null) // End of file 
                    break;
                string[] words = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
                //  Process words...
            }
            file.Close();

            GenericSet<string> User_defined_words = new GenericSet<string>();
            GenericSet<string> Unidentified_words = new GenericSet<string>();

        }

        public static void tester()
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
