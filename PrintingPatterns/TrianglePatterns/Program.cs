using System;

namespace TrianglePatterns
{
    class Program
    {
       
        

        //  private int userInput;
        static void Main(string[] args)
        {

            DisplayPatternA();
            DisplayPatternB();
            DisplayPatternC();
            DisplayPatternD();
            DisplayPatternE();
            DisplayPatternF();
            DisplayPatternG();
            DisplayPatternH();
            Console.ReadLine();
        }

        
        static void DisplayPatternA()
        {
            // your implementation here

            int rowNum;
            int i;
            int userInput = 10;

            System.Console.WriteLine("Patern A");
            System.Console.WriteLine(" ");
            for (rowNum = 1; rowNum <= userInput; rowNum++)
            {
                for (i = rowNum; i > 0; i--)
                {
                    System.Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        static void DisplayPatternB()
        {
            // your implementation here
            
            int rowNum;
            int i;
            int userInput = 10;


            System.Console.WriteLine("Patern B");
            System.Console.WriteLine(" ");

            for (rowNum = 0; rowNum < userInput; rowNum++)
            {

                for (i = userInput-rowNum; i > 0; i--)
                {
                    System.Console.Write('*');
                }
                Console.WriteLine();
      
            }

        }

        static void DisplayPatternC()
        {
            // your implementation here
            int rowNum;
            int i, j;
            int userInput = 10;

            System.Console.WriteLine("Patern C");
            System.Console.WriteLine(" ");

            for (rowNum = 0; rowNum < userInput; rowNum++)
            {
                for (i = rowNum; i > 0; i--)
                {
                    System.Console.Write(' ');
                }
                for (j = userInput - rowNum; j > 0; j--)
                {
                    System.Console.Write('*');
                }
                Console.WriteLine();
            }
        }

        static void DisplayPatternD()
        {
            // your implementation here
            int rowNum;
            int i, j;
            int userInput = 10;

            System.Console.WriteLine("Patern D");
            System.Console.WriteLine(" ");

            for (rowNum = 1; rowNum < userInput; rowNum++)
            {
                for (i = userInput - rowNum; i > 0; i--)
                {
                    System.Console.Write(" ");
                }
                for (j = rowNum; j > 0; j--)
                {
                    System.Console.Write("*");
                }

                Console.WriteLine();
            }
        }


        static void DisplayPatternE()
        {
            // your implementation here
            int rowNum;
            int i, j;

            int userInput = 10;

            System.Console.WriteLine("Pattern E");
            System.Console.WriteLine(" ");

            for (rowNum = 0; rowNum < userInput; rowNum++)
            {

                for (i = userInput - rowNum - 1; i > 0; i--)
                {
                    Console.Write(" ");
                }
                for (j = rowNum * 2 + 1; j > 0; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }


        static void DisplayPatternF()
        {
            // your implementation here
            int rowNum;
            int i, j;
            int userInput = 10;

            System.Console.WriteLine("Pattern F");
            System.Console.WriteLine(" ");

            for (rowNum = 0; rowNum < userInput; rowNum++)
            {
                for (i = userInput - rowNum; i > 0; i--)
                {
                    Console.Write(" ");
                }
                for (j = rowNum; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            for (rowNum = 0; rowNum < userInput; rowNum++)
            {
                for (i = rowNum; i > 0; i--)
                {
                    Console.Write(" ");
                }
                for (j = userInput - rowNum; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

        static void DisplayPatternG()
        {
            // your implementation here
            int rowNum;
            int i, j;

            int userInput = 10;

            System.Console.WriteLine("Pattern E");
            System.Console.WriteLine(" ");

            for (rowNum = 0; rowNum < userInput; rowNum++)
            {

                for (i = userInput - rowNum - 1; i > 0; i--)
                {
                    Console.Write("*");
                }
                for (j = rowNum * 2 + 1; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (i = userInput - rowNum - 1; i > 0; i--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }

        static void DisplayPatternH()
        {
            // your implementation here
            int rowNum;
            int i, j;

            int userInput = 10;

            System.Console.WriteLine("Pattern E");
            System.Console.WriteLine(" ");

            for (rowNum = 0; rowNum < userInput; rowNum++)
            {


                for (i = rowNum ; i > 0; i--)
                {
                    Console.Write("*");
                }
                for (j = (userInput*2)-1-(rowNum*2); j > 0; j--)
                {
                    Console.Write(" ");
                }

                for (j = rowNum; j > 0; j--)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

        }

    }
}
