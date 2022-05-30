using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_MaisQuiMarche
{
    public class NormalMain
    {
        public void Exo1_1()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("Multiplication Table of the number " + i + " :");
                for (int j = 1; j < 11; j++)
                {
                    Console.WriteLine(i * j);
                }
                Console.WriteLine("\n");
            }
        }
        public void Exo1_2()
        {
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("The odd numbers of the multiplication table of the number " + i + " :");
                    for (int j = 1; j < 11; j++)
                    {
                        if (i * j % 2 != 0)
                        {
                            Console.WriteLine(i * j);
                        }
                    }
                    Console.WriteLine("\n");
                }
            }
        }
        public void Exo1_3()
        {
            Console.WriteLine("Please write a number and press enter :");
            int.TryParse(Console.ReadLine(), out var result);
            Console.WriteLine("\n");
            Console.WriteLine("Here's the multiplication table of the number " + result + " : ");

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(i * result);
            }
        }


        // ############################################################################################

        // Exercice 2

        public void Prime()
        {

            // This list will register all prime numbers between 2 and 1000
            List<int> primeNumbers = new List<int>();

            // I had to put 2 in the list myself so I can use it later
            primeNumbers.Add(2);

            // I go through all numbers up to 1000
            for (int i = 3; i < 1001; i++)
            {
                // I will only have to divide with the sqrt of the current i number
                int max = (int)Math.Ceiling(Math.Sqrt(i));

                // Next we will check if max is a prime number, if yes we will add it to our primeNumbers list
                int check_max = 0;

                for (int p=0; p<primeNumbers.Count; p++)
                {
                    if (max % primeNumbers[p] == 0)
                    {
                        check_max++;
                    }             
                }
                
                if ((check_max == 0) & (primeNumbers.Contains(max) == false))
                {
                    primeNumbers.Add(max);
                }

                // Now I divide every i by the prime numbers I found so far, if the rest is not 0 at any point, this number is prime

                int check = 0;

                for (int j=0; j<primeNumbers.Count; j++)
                {
                    if (i % primeNumbers[j] == 0)
                    {
                        check++;
                    }
                }
                
                if (check == 0)
                {
                    primeNumbers.Add(i);
                }
            }
            
            Console.WriteLine("Here are all the prime numbers up to 1000 :");

            for (int i = 0; i < primeNumbers.Count; i++)
            {
                Console.WriteLine(primeNumbers[i]);
            }
        }


        // Exercice 3 

        public void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a number between -3 and 3 :");

                var num = int.Parse(Console.ReadLine());

                Console.WriteLine((float)((float)10 / (Math.Pow(num, 2) - 4)));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Attempted divide by zero. {0}", ex.Message);
            }
        }
        public void Square_1()
        {
            Console.WriteLine("Please enter N, it should within the 1 to 1000 included range : ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter M, it should within the 1 to 1000 included range : ");
            int M = int.Parse(Console.ReadLine());

            // There should be another code section verifying if what the user inserted is really what the program for

            string vertical_line = "|";

            if ((N == 1) & (M == 1))
            {
                Console.WriteLine("0");
            }
            else if ((N == 1) & (M != 1)){
                Console.WriteLine("0");
                for (int i = 0; i < M - 2; i++)
                {
                    Console.WriteLine(vertical_line);
                }
                Console.WriteLine("0");
            }
            else if ((N != 1) & (M == 1))
            {
                string lines_1 = new string('-', N - 2);
                Console.WriteLine("0" + lines_1 + "0");
            }
            else
            {
                string lines_1 = new string('-', N - 2);
                string spaces = new string(' ', N - 2);

                Console.WriteLine("0" + lines_1 + "0");
                for (int i = 0; i < M - 2; i++)
                {
                    Console.WriteLine(vertical_line + spaces + vertical_line);
                }
                Console.WriteLine("0" + lines_1 + "0");
            } 
        }
    }
}


