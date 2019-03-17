
using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
 
            int[] codeBreaker = new int[4];
            string[] Arthplus = new string[4];
            string[] Arthminus = new string[4];
            int[] CodeMaker = new int[4];
            Random random = new Random();        
            for (int k = 0; k < 4; k++)
            {
                CodeMaker[k]+= random.Next(1, 7);
            }        
            for (int numberOfGuess=9; numberOfGuess>=0; numberOfGuess--)
            {
                Console.WriteLine("Enter 4 digit number with space between 1 to 6");
                string CodeBreakerInput = Console.ReadLine();
                if (CodeBreakerInput != null)
                {
                    string[] inputCodeBreakerList = CodeBreakerInput.Split(' ');
                    codeBreaker = new int[inputCodeBreakerList.Length];
                    if (codeBreaker.Length== 4)
                    {
                        for (int m = 0; m < codeBreaker.Length; m++)
                        {
                            string myString = inputCodeBreakerList[m].Trim();
                            if (myString=="0" || myString=="7")
                            {
                                Console.WriteLine("Please Enter number between 1 to 6");
                            }
                            else if (int.TryParse(myString,out int result))
                            {

                                codeBreaker[m] += int.Parse(myString);                    

                            }
                            else
                            {
                               Console.WriteLine("Please enter numbers only");
                            }
                        }
                    }
                    else
                    {
                       Console.WriteLine("Enter digit should not be more than 4 or less than 4");
                    }
                }
                else
                {
                   Console.WriteLine("Please Enter 4 digit number with space between 1 to 6");
                }
                for (int i = 0; i < CodeMaker.Length; i++)
                {
                    for (int j = 0; j < codeBreaker.Length; j++)
                    {
                        if (CodeMaker[i] == codeBreaker[j] && i == j)
                        {
                            Arthplus[i] += "+";
                            i = i + 1;
                        }
                        else if (CodeMaker[i] == codeBreaker[j] && i != j)
                        {
                            Arthminus[i] += "-";
                          
                        }

                    }
                }
                Array.ForEach(Arthplus, x => Console.Write(" "+x));
                Array.ForEach(Arthminus, x => Console.Write(" "+x));
                if (CodeMaker.SequenceEqual(codeBreaker))
                    {
                        Console.WriteLine("Congratulations you won the game");                       
                        Array.Clear(Arthplus, 0, Arthplus.Length);
                        Array.Clear(Arthminus, 0, Arthminus.Length);
                        numberOfGuess = 0;
                    }
                    else
                    {
                        Console.WriteLine("Oops Wrong attempt try again!!");
                        Array.Clear(Arthplus, 0, Arthplus.Length);
                        Array.Clear(Arthminus, 0, Arthminus.Length);
                        if (numberOfGuess == 0)
                        {
                            Console.WriteLine("Game over you lost the game!!");
                        }

                    }
                
              

            }
            Console.ReadLine();
        }

    }

}



