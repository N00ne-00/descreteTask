using System;

namespace project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your number : ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Please enter your number : ");
            int num2 = int.Parse(Console.ReadLine());


            for (int input = num1; input <= num2; input++)
            {
                if (input <= 1)
                {

                    continue;
                }
                else
                {
                    int x = 0;
                    for (int i = 2; i < input; i++)
                    {
                        if (input % i == 0)
                        {
                            x = 1;
                            break;
                        }



                    }
                    if (x == 0)
                    {
                        Console.WriteLine(input + " is a prime number");
                    }


                }
            }

        }
    }
}

