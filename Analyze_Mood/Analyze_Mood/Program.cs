using System;

namespace Analyze_Mood
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood analyzer System");
            Analysis analysis = new Analysis("I am  Mood");
            Console.ReadKey();
        }
    }
}
