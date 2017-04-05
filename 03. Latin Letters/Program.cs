using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "christian";
            char[] wordChar = word.ToCharArray();
            int n = wordChar.Length;
            var wrongWordStep = 0;

            char[] result = new string('_', n).ToCharArray();
            string letter = Console.ReadLine().ToLower();
            while (letter != "end")
            {
                for (int i = 0; i < n; i++)
                {
                    if (result[i] == '_')
                    {

                        if (wordChar[i] == Convert.ToChar(letter))
                        {
                            result[i] = Convert.ToChar(letter);
                        }
                        else
                        {
                            result[i] = '_';
                            wrongWordStep++;
                        }
                    }
                }
                string wordAll = new string(result);
                Console.WriteLine(wordAll);
                if (!result.Contains('_'))
                {
                    break;
                }
                letter = Console.ReadLine().ToLower();
            }

        }
    }
}
