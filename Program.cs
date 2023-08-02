using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assign21
{
    class Program
    {


        static void DisplayDays(List<string> days)
        {
            Console.WriteLine("\"----Days of the Week----\"");
            Thread.Sleep(500);
            foreach (var day in days)
            {
                Console.WriteLine(day);
                Thread.Sleep(2000); 
            }
            Console.WriteLine();
        }

        static void DisplayMonths(List<string> months)
        {
            Console.WriteLine("\"----Months of the Year----\"");
            Thread.Sleep(500);
            foreach (var month in months)
            {
                Console.WriteLine(month);
                Thread.Sleep(2000);
            }
            Console.WriteLine();
        }

        static void DisplayFruits(List<string> fruits)
        {
            Thread.Sleep(1000);
            Console.WriteLine("\"----Fruits----\"");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine();
        }

        static void DisplayWords(Dictionary<string, string> wordsDictionary)
        {
            Thread.Sleep(2000);
            Console.WriteLine("\"----Words and Meanings----\"");

            foreach (var word in wordsDictionary)
            {
                Console.WriteLine($"Word: {word.Key},\n Meaning: {word.Value}");
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Console.WriteLine("\"---------------Welcome to Learning-----------\"");
            Thread.Sleep(500);

            
            List<string> days = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            List<string> months = new List<string> { " ", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            List<string> fruits = new List<string> { "Apple", "Banana", "Orange", "Grapes", "Mango", "Watermelon", "Strawberry", "Pineapple", "Cherry", "Peach" };
            Dictionary<string, string> wordsDictionary = new Dictionary<string, string>
            {
                {"Baka","This word refers to the English word “stupid” or “idiot”." },
                { "Accentuate ", "make more noticeable or prominent" },
                { "Otaku", "A person who is obsessed with anime, manga, and Japanese pop culture." },
                { "Defer ", "postpone" },

            };

            
            Thread daysThread = new Thread(() => DisplayDays(days));
            Thread monthsThread = new Thread(() => DisplayMonths(months));
            Thread fruitsThread = new Thread(() => DisplayFruits(fruits));
            Thread wordsThread = new Thread(() => DisplayWords(wordsDictionary));

            daysThread.Start();
            Thread.Sleep(14000); 
            monthsThread.Start();
            Thread.Sleep(24000);
            fruitsThread.Start();
            wordsThread.Start();
            daysThread.Join();
            monthsThread.Join();
            fruitsThread.Join();
            wordsThread.Join();

            Console.WriteLine("\"---------------Learning Completed-----------\"");
            Console.ReadKey();
        }
    }
}