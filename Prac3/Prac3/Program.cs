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
            SpellCheck(); //checks for unidentified words
            Console.Read();
            
           
        }

        public static void SpellCheck()
        {
            GenericSet<string> Dictionary = new GenericSet<string>();

            Dictionary_maker(Dictionary);
            //Console.Write(Dictionary.ToString());

            GenericSet<string> User_defined_words = new GenericSet<string>();
            user_defined_words_maker(User_defined_words);
            //Console.Write(User_defined_words.ToString());

            //Adding the words in User_defined_words to Dictionary so I can just compare against one dictionary
            int i = 0;
            while (i < User_defined_words.Length())
            {
                Dictionary.Add(User_defined_words.Get(i));
                i++;
            }
            

            GenericSet<string> Unidentified_words = new GenericSet<string>();
            TextReader file = File.OpenText("..\\..\\..\\PrideAndPrejudice.txt");
            string[] delimiters = { ",", ".", "!", "?", ";", ":",
                        " ", "\"", "'", "_", "(", ")",
                        "[", "]", "{", "}", "*", "#",
                        "&", "`", "-" };
            while (true)
            {
                string line = file.ReadLine();
                if (line == null) // End of file 
                    break;
                string[] words = line.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                //checks words in the line against the dictionary list
                foreach(string word in words)
                {
                    bool s = Dictionary.check(word);
                    if (s == false)
                    {
                        Unidentified_words.Add(word);
                    }
                }
                
            }
            file.Close();

            Console.WriteLine("The amount of Unidentified words are: " + Unidentified_words.Length());
            Console.WriteLine();
            Console.Write(Unidentified_words.ToString());
        }

        
        public static void user_defined_words_maker(GenericSet<string> x)
        {
            //makes a generic list of words I have defined
            TextWriter file01 = File.CreateText("..\\..\\..\\userlist");

            file01.WriteLine("Georgina");
            file01.WriteLine("Fiorentinos");
            file01.WriteLine("googilygoo");

            file01.Close();

            string[] delimiters1 = { ",", ".", "!", "?", ";", ":",
                        " ", "\"", "'", "_", "(", ")",
                        "[", "]", "{", "}", "*", "#",
                        "&", "`", "-" };

            TextReader file1 = File.OpenText("..\\..\\..\\userlist");

            while (true)
            {
                string line = file1.ReadLine();
                if (line == null) // End of file 
                    break;
                string[] words = line.Split(delimiters1, StringSplitOptions.RemoveEmptyEntries);
                x.Add(words[0]);
                //  Process words...

            }

            file1.Close();
        }

        public static void Dictionary_maker(GenericSet<string> x)
        {
            //makes a generic list of dictionary words
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
                x.Add(words[0]);
            //  Process words...

            }
            file.Close();

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
