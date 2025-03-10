using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 综合学习
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstFriend = "Maria";
            string secondFriend = "Tom";
            Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
            Console.WriteLine("My friends are {0} and {1}", firstFriend, secondFriend);
            Console.WriteLine("The name {0} has {1} letters in it.", firstFriend, firstFriend.Length);
            Console.ReadKey();
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]"); // [      Hello World!       ]
            string trimmedGreeting = greeting.TrimStart(); // [Hello World!       ]
            Console.WriteLine($"[{trimmedGreeting}]"); // [Hello World!       ]
            trimmedGreeting = greeting.TrimEnd();       // [      Hello World!]
            Console.WriteLine($"[{trimmedGreeting}]");   // [      Hello World!]
            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");// [Hello World!]
            Console.ReadKey();
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings"); // Greetings World!
            Console.WriteLine(sayHello);
            Console.WriteLine(sayHello.ToUpper()); // GREETINGS WORLD! 全部大写
            Console.WriteLine(sayHello.ToLower()); // greetings world! 全部小写
            Console.ReadKey();
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye")); // True
            Console.WriteLine(songLyrics.Contains("greetings")); // False
            Console.ReadKey();
            string songLyrics2 = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics2.StartsWith("You")); // True
            Console.WriteLine(songLyrics2.StartsWith("goodbye")); // False
            Console.WriteLine(songLyrics2.EndsWith("hello")); // True
            Console.ReadKey();
        }
    }
}
