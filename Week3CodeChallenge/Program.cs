using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3CodeChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //Function call for FindPrimes 
            // with the parameter of 10,001
            FindPrimes(10001);
            //Adds a space between things being
            //printed to the console
            Console.WriteLine();
            //Function call for EvenFibonacciSequencer
            // with the parameter 1,000,000
            EvenFibonacciSequencer(1000000);
            //Adds a space between things being 
            // printed to the console
            Console.WriteLine();
            //Function call for LongestCollatzSequencer
            LongestCollatzSequence(837799);
            //Adds a space between things being 
            // printed to the console
            Console.WriteLine();
            //Keeps the console open
            Console.ReadKey();

        }
        //Function for FindPrimes - will be 
        // finding all prime numbers unitl it 
        // reaches our input value
        static void FindPrimes(int maxPrime)
        {
            //Making a list for prime numbers to 
            // be added to, starting with 2
            List<int> primeList = new List<int>(){2};
            //Setting up a loop to start with the 
            // next number after 2 and then 
            // test that number to see if it
            // is prime
            int test = 3;
            while (primeList.Count < maxPrime)
            {
                //While isPrime is true it will run
                // the for loop
                bool isPrime = true;
                for (int i = 2; i < test; i++) 
                {
                    //If the test number is divisible 
                    // by 2 
                    if (test % i == 0)
                    {
                        //Then isPrime is false and will 
                        // stop running and the loop will
                        // break at that point.
                        isPrime = false;
                        break;
                    }
                    
                }
                //If the number is prime
                if (isPrime == true)
                    {
                        //That number will get added
                        // to the list that was created
                        primeList.Add(test);
                    }
                //The test number will then go up by one
                test++;         
            }
            //Prints to the console what the 10,001st 
            // prime number is.
            Console.WriteLine("The 10,001st prime number is: " + primeList.Last());
        }
        //Function for EvenFibonacciSequencer 
        static void EvenFibonacciSequencer(int maxValue)
        {
            // Creating a list to hold the numbers
            // in our Fibonacci Sequence
            List<int> fibSeq = new List<int>{1,2};
            //Starting our sequence with the number 2
            int total = 2;
            //Creating the loop to run through the numbers
            // and add them to the previous number
            for (int i = 0; i < maxValue; i++)
            { 
                //Setting up the integers that needed to 
                // be added together to get added to 
                // our list.
                int first = fibSeq[i];
                int last = fibSeq[i + 1];
                int final = first + last;
                //Adding a number to our list
                fibSeq.Add(final);
                //If the final result of the two numbers
                // was even then it will get added with 
                // our total.
                if (final % 2 == 0)
                {
                    total += final;  
                }   
            }
            //Prints to the consol what our sequence is
            Console.WriteLine("Fibonacci Sequence: " + total);
        }
        //Function for LongestCollatzSequence - 
        // will be finding the longest chain of numbers 
        // that will eventually reduce down to 1 through 
        // a few equations being applied to the sequence 
        // depending on if the number is even or odd
        static void LongestCollatzSequence(long input)
        {
            long n = input;
            long loopCount = 0;
            //While n is greater than 1
            while (n > 1)
            {
                //If n is even by 2 then 
                // n will be divided by 2 and the 
                // loop count will increase by 1.
                if (n % 2 == 0)
                {
                    n = n / 2;
                    loopCount++;
                }
                //If n is odd then it will be multiplied 
                // by 3 and that result will then be added 
                // by 1. The loop count will then increase 
                // by 1. 
                else
                {
                    n = 3 * n + 1;
                    loopCount++;
                }
            }
            Console.WriteLine("Input: " + input);
            //Prints to the console what the loop count is for 
            // the number inputted.
            Console.WriteLine("The loop count was: " + (loopCount + 1));

        }
    }
}
