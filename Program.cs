
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
            string[] Arthplus = new string[4];
            string[] Arthminus = new string[4];
            int[] CodeMaker = new int[4];
            Random random = new Random();
            int randomnumber= random.Next(1, 6);
            for (int k = 0; k < 4; k++)
            {
                CodeMaker[k]+= random.Next(1, 6);
            }        
            for (int numberOfGuess=9; numberOfGuess>=0; numberOfGuess--)
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
                                if (myString != "")
                                {
                                    inputNumbers[m] += int.Parse(myString);
                                }
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
                            Arthplus[i] += "+";
                            i = i + 1;
                        }
                        else if (CodeMaker[i] == inputNumbers[j] && i != j)
                        {
                            Arthminus[i] += "-";
                          
                        }

                    }
                }
                foreach (var item in Arthplus)
                {
                    if (item != null)

                    {
                        if (item.Equals("+"))
                        {
                          Console.Write(item + " ");
                        }
                    }
                }
                foreach (var c in Arthminus)
                {
                    if (c != null)
                    {
                        if (c.Equals("-"))
                        {
                            Console.Write(c + " ");
                        }
                    }
                }
                if (Arthplus.Length >= 4 || Arthminus.Length >= 4)
                {
                    if (CodeMaker.SequenceEqual(inputNumbers))
                    {
                        Console.WriteLine("Congratulations you won the game");
                        numberOfGuess = 0;
                        Array.Clear(Arthplus, 0, Arthplus.Length);
                        Array.Clear(Arthminus, 0, Arthminus.Length);
                    }
                    else
                    {
                        Array.Clear(Arthplus, 0, Arthplus.Length);
                        Array.Clear(Arthminus, 0, Arthminus.Length);
                        Console.WriteLine("Oops Wrong attempt try again!!");
                        if (numberOfGuess == 0)
                        {
                            Console.WriteLine("Game over, you lost the game!!");
                        }

                    }
                }
                else
                {
                    Array.Clear(Arthplus, 0, Arthplus.Length);
                    Array.Clear(Arthminus, 0, Arthminus.Length);
                }

            }
            Console.ReadLine();
        }

    }

}



