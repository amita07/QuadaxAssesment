using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int RandomGenAns = 3;
            int[] randomGenAnsArr = new int[RandomGenAns];          
            int[] inputNumbers = null;
            int[] codeBreaker = new int[4];
            int numberOfGuess = 9;
            List<int> inputList = new List<int>();
            string[] ArthSign = new string[4];
            int[] CodeMaker = new int[4] { 2, 2, 4, 6 };
           
            for (int n = 0; n < numberOfGuess; n++)
            {
                Console.WriteLine("Enter 4 digit number with space between 1 to 6");
                string CodeBreakerS = Console.ReadLine();
                if (CodeBreakerS != null)
                {
                    string[] inputCodeBreakerList = CodeBreakerS.Split(' ');
                    inputNumbers = new int[inputCodeBreakerList.Length];
                    if (inputNumbers.Length <= 4)
                    {
                        for (int m = 0; m < inputNumbers.Length; m++)
                        {
                            string myString = inputCodeBreakerList[m].Trim();
                            if (myString == "0" || myString == "7")
                            {
                                Console.WriteLine("Please Enter number between 1 to 6");

                            }
                            else
                            {
                                inputNumbers[m] += int.Parse(myString);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter digit should not be more than 4");
                    }
                }
                else
                {
                    Console.WriteLine("Enter 4 digit number with space between 1 to 6");
                }
                for (int i = 0; i < CodeMaker.Length; i++)
                {
                    for (int j = 0; j < inputNumbers.Length; j++)
                    {
                        if (CodeMaker[i] == inputNumbers[j] && i == j)
                        {
                            ArthSign[i] += "+";
                            i = i + 1;
                        }
                        else if (CodeMaker[i] == inputNumbers[j] && i != j)
                        {
                            ArthSign[i] += "-";

                        }
                    }

                }
                foreach (var item in ArthSign)
                {
                    Console.Write(item + " ");

                }
                if (ArthSign.Length >= 4)
                {
                    if (CodeMaker.SequenceEqual(inputNumbers))
                    {
                        Console.WriteLine("Congratulations you won the game");
                        Array.Clear(ArthSign, 0, ArthSign.Length);

                    }
                    else
                    {
                        Array.Clear(ArthSign, 0, ArthSign.Length);
                        Console.WriteLine("Oops Wrong attempt!");
                    }



                }
                else
                {
                    Array.Clear(ArthSign, 0, ArthSign.Length);


                }

            }
            
          
            Console.ReadLine();



        }
        

        }
    
    }

