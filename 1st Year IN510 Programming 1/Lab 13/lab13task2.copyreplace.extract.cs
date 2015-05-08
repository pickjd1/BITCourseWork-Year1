using System;

namespace ConsoleApplication42
{
    class Program
    {
        static void Main()
        {
            string sentence, hairy = "hairy ", chicken = "chicken ";
            sentence = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(sentence);

            string copySentence = string.Copy(sentence);

            Console.WriteLine(copySentence);

            Console.WriteLine(copySentence.Insert(10, hairy));
            Console.WriteLine(copySentence.Replace("dog", chicken));


            Console.Read();


        }
    }
}
