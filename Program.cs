using System;
using System.ComponentModel.Design;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            
            Random generator = new Random();
            int randNumb;

//            randNumb = generator.Next(10);

//            Console.WriteLine("My random number is " + randNumb);
//            Console.WriteLine("Here are some numbers from 0 to 4!");
//            Console.Write(generator.Next(5) + " ");
//            Console.Write(generator.Next(5) + " ");
//            Console.Write(generator.Next(5) + " ");
//            Console.Write(generator.Next(5) + " ");
//            Console.Write(genera  Console.ReadLine(); // Keeps the program from quitting
//                                                     
//            Console.WriteLine(generator.Next(5) + " ");
//            Console.WriteLine();
//            Console.WriteLine("Here are some numbers from 0 to 99!");
//            Console.Write(generator.Next(100) + " ");
//            Console.Write(generator.Next(100) + " ");
//            Console.Write(generator.Next(100) + " ");
//            Console.Write(generator.Next(100) + " ");
//            Console.Write(generator.Next(100) + " ");
//            Console.WriteLine(generator.Next(100) + " ");
//            Console.WriteLine();
//            int num1 = generator.Next(10);
//            int num2 = generator.Next(10);
//            if (num1 == num2)
//            {
//                Console.WriteLine("The random numbers were the same! Weird.");
//            }
//            if (num1 != num2)
//            {
//                Console.WriteLine("The random numbers were different! Not weird. ");
//            }
          





            int guess, secertNumber;
            secertNumber = generator.Next(1, 11);
            Console.WriteLine("Welcom to the new guessing game called the Better worst geussing game!");
            Console.WriteLine(" please give me a number from 1-10");
            int.TryParse(Console.ReadLine(), out guess);
            if (guess == secertNumber)
            {
                Console.WriteLine("Great job your are right");
            }
            else
            {
                Console.WriteLine("your are incorect");
            }
            Console.ReadLine();
        }
    }
}
