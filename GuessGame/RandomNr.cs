using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    class RandomNr
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secret_number = random.Next(100);
            int your_number;
            do
            {
                Console.Write("Type a nummber between 0 and 100: ");
                your_number = int.Parse(Console.ReadLine());
                if (your_number == secret_number)
                {
                    Console.WriteLine("Congratulation! You guess the number!");
                }
                else if (your_number < secret_number)
                {
                    Console.WriteLine("The number is not greater than my number");
                    Console.WriteLine("You can try again");
                }
                else if (your_number > secret_number)
                {
                    Console.WriteLine("The number is greater than my number");
                    Console.WriteLine("You can try again");
                }
                else if (your_number > 100)
                {
                    Console.WriteLine("The number is out of range!");
                    Console.WriteLine("You can try again");
                }
            }
            while (your_number != secret_number);
            Console.ReadKey();

        }
    }
}
    