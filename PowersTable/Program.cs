using System;

namespace PowersTable
{
    class Program
    {
        static void Main(string[] args)

        {
            string ContinuePrompt = "y";
            while (ContinuePrompt == "y" || ContinuePrompt == "y")
            {
                Console.WriteLine("Learn your squares and cubes!");
                
                int i, num;
                Console.Write("\n\n");
                Console.Write("Display the cube & square of the number:\n");
                Console.Write("==============================");
                Console.Write("\n\n");

                Console.Write("Please enter an integer: ");
                Console.Write("\n\n");
                num = Convert.ToInt32(Console.ReadLine());
                for (i = 1; i <= num; i++)
                {
                    Console.Write("Your number is: {0} and cube of the {1} is :{2} \n", i, i, (i * i * i));
                    Console.Write("Your number is: {0} and square of the {1} is :{2} \n", i, i, (i * i ));
                    Console.Write("\n\n");
                    Console.Write("==============================");
                    Console.Write("\n\n");
                }
                Console.WriteLine("Thank you so much! Would you like to continue? y/n ");
                string input2 = Console.ReadLine();
                string ContinueProm = input2.ToLower();
            }
        }
    }

}
