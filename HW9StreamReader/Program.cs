using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HW9StreamReader
{
    class Program
    {
        static void Main(string[] args)
        {
            //Use for all parts
            StreamReader shakespeare = new StreamReader("..\\..\\..\\shakespeare.txt");
            string line = shakespeare.ReadLine();


            //PART 1
            //Read and print the first line from the file only.

            Console.WriteLine(line);


            //PART 2
            //Read and print the entire text file.

            //while (line != null)
            //{
            //    Console.WriteLine(line);
            //    line = shakespeare.ReadLine();
            //}


            //PART 3
            //Read and print the entire text file and capitalize all lowercase vowels.
            //Pick if-else-if or switch-case conditional statement.

            //while (line != null)
            //{
            //    char[] array = line.ToCharArray();
            //    line = shakespeare.ReadLine();

            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        char lowerVowel = array[i];

            //BEGIN if-else -if
            //if (lowerVowel == 'a')
            //   {
            //       array[i] = 'A';
            //   }
            //   else if (lowerVowel == 'e')
            //   {
            //       array[i] = 'E';
            //   }
            //   else if (lowerVowel == 'i')
            //   {
            //       array[i] = 'I';
            //   }
            //   else if (lowerVowel == 'o')
            //   {
            //       array[i] = 'O';
            //   }
            //   else if (lowerVowel == 'u')
            //   {
            //       array[i] = 'U';
            //   }
            //END if-else-if

            //BEGIN switch-case
            //switch (array[i])
            //{
            //    case 'a':
            //        array[i] = 'A';
            //        break;
            //    case 'e':
            //        array[i] = 'E';
            //        break;
            //    case 'i':
            //        array[i] = 'I';
            //        break;
            //    case 'o':
            //        array[i] = 'O';
            //        break;
            //    case 'u':
            //        array[i] = 'U';
            //        break;
            //    default:
            //        break;
            //}
            //END switch-case
            //    }

            //    string result = new string(array);

            //    Console.WriteLine(result);
            //}


            //Use for all parts
            shakespeare.Close();
        }
    }
}
