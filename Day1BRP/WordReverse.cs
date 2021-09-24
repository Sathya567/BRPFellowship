using System;

namespace Day1BRP
{
    class WordReverse
    {
        static void Main(string[] args)
        //    {
        //        Console.ForegroundColor = ConsoleColor.White;
        //        Console.WriteLine("Eneter the String:");
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        string s = Console.ReadLine();
        //        string[] a = s.Split(' ');
        //        Array.Reverse(a);
        //        Console.ForegroundColor = ConsoleColor.Red;

        //        Console.WriteLine("Reverse String is:");
        //        for (int i = 0; i <= a.Length - 1; i++)
        //        {
        //            Console.ForegroundColor = ConsoleColor.White;
        //            Console.Write(a[i] + "" + ' ');
        //        }

        //        Console.ReadKey(); 
        //    }
        //}
        {
            public static void Main()
            {
                string line = "Alice Bob Carol";
                Console.WriteLine("\nOriginal String: " + line);
                string result = "";
                List<string> wordsList = new List<string>();
                string[] words = line.Split(new[] { " " }, StringSplitOptions.None);
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    result += words[i] + " ";
                }
                wordsList.Add(result);
                foreach (String s in wordsList)
                {

                    Console.WriteLine("\nReverse String: Hi " + s);
                }
            }
        }
    }
}

