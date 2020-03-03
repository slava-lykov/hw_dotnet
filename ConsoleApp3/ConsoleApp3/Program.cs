using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            StreamReader textReader = new StreamReader(@"C:\image.txt", true);

            string textReaderResult = textReader.ReadToEnd();

            textReader.Dispose();
                        
            string[] arrayOfTextResult = textReaderResult.Split(' ');

            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)

                {

                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);

                byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
                
                imageBytes[i] = binary;

                File.WriteAllBytes(@"\\SDV\DFS\MINBO\USERS\v.lykau\Desktop\autotests\image.png", imageBytes);

                };
                                 
                       
                              
        }
    }
}
