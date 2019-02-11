using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "Boat", "house", "cat", "river", "cupboard" };
            var i = 0;
            Console.WriteLine("The plural of all word in the array is :");

            for(i=0;i<words.Length;i++)
            {
                Console.WriteLine(words[i]+'s'+'\n');
            }

            words[1] = "home";
            Console.WriteLine("The words after the replacement" );
            for(i=0;i<words.Length;i++)
            {
                Console.WriteLine(words[i]+'\n');
            }
            Array.Resize(ref words, 6);
            words[5] = "Bottle";
            Console.WriteLine("The new length of the array after addition of element is :"+words.Length);
            

            for(i=0;i<words.Length;i++)
            {
                if(words[i].Length==7)
                {
                    Console.WriteLine(words[i]);
                }
            }
            Console.WriteLine("The word At 3rd position is:" +words[2]);
            string[] words2 = new string[6];
            Array.Copy(words, words2, 6);

            Array.Sort(words);
            Console.WriteLine("The array in ascending order");
            for(i=0;i<words.Length;i++)
            {
                Console.WriteLine(words[i]+'\n');
            }
            Array.Copy(words2, words, 6);
            Array.Reverse(words);
            Console.WriteLine("The array in reverse order");
            for(i=0;i<words.Length;i++)
            {
                Console.WriteLine(words[i]+'\n');
            }
            
            Array.I
            
        }
    }
}
