using System;
/*
_________________________________________________
George Shea                          ßeta Product
Created 22/1/2020
Version 2.0
Version Date: 22/1/2020

small test that will test students on their knowledge
.net core 
_________________________________________________
*/


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string begin;
            string repeat = "Y";
            while (repeat == "Y")
            {
                // intro screen teels you what the quiz is about
                Console.WriteLine("Programming Fundementals Test");
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("This test will quiz you on");
                Console.WriteLine("on your knowledge of .net");
                Console.WriteLine("please answer in A,B,C or D");
                Console.WriteLine("__________________________________________________");
                Console.WriteLine("Do You Wish To Begin y/n");
                begin = Console.ReadLine();

                if (begin == "n")
                {
                    // finishs code and concludes with a goodbye
                    Console.WriteLine("Have a lovely day remember this quiz must be completed");
                }
                else
                {
                    // the great many of arrays needed to get this working
                    // this stores what the correct answers to the quiz are
                    string[] testAswers = { "A", "B", "C", "A", "D",
                        "A", "A", "C", "D", "A" };
                    // this array will store the users gueses at the quiz it has 10 slots open
                    // for the 10 questiosn that will be asked
                    string[] testGuess = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
                    // this is just a personal touch
                    //this is used to store all the questions to be printed out in a loop
                    string[] testQuestions = {
                        "Question 1 ", "A || ", "B || ", "C || ", "D || ",
                        "Question 2 ", "A || ", "B || ", "C || ", "D || ",
                        "Question 3 ", "A || ", "B || ", "C || ", "D || ",
                        "Question 4 ", "A || ", "B || ", "C || ", "D || ",
                        "Question 5 ", "A || ", "B || ", "C || ", "D || ",
                        "Question 6 ", "A || ", "B || ", "C || ", "D || ",
                        "Question 7 ", "A || ", "B || ", "C || ", "D || ",
                        "Question 8 ", "A || ", "B || ", "C || ", "D || ",
                        "Question 9 ", "A || ", "B || ", "C || ", "D || ",
                        "Question 10 ", "A || ", "B || ", "C || ", "D || ",
                    };
                    //__________________________________________________________________________
                    // this is used to pass/fail the person
                    int score = 0;
                    // Qcount is responsible for going through the array and printing out the
                    // correct words to make up the quiz
                    int QCount = 0;
                    // answers store the uses guesses temporality then puts it into the array
                    string answers;
                    // this moves the guesses into the correct questions
                    int guessPositCount = 0;
                    // just used to avoid having to loop through and make sure that it
                    // does not get outside of its array 
                    int qLoop = 10;

                    // begin loop will loop 10 full times
                    while (qLoop > 0)
                    {
                        // prints out in groups of 5 1 Question 4 Solutions
                        qLoop = qLoop - 1;
                        Console.WriteLine(testQuestions[QCount]);
                        QCount = QCount + 1;
                        Console.WriteLine(testQuestions[QCount]);
                        QCount = QCount + 1;
                        Console.WriteLine(testQuestions[QCount]);
                        QCount = QCount + 1;
                        Console.WriteLine(testQuestions[QCount]);
                        QCount = QCount + 1;
                        Console.WriteLine(testQuestions[QCount]);
                        QCount = QCount + 1;


                        // gets user input and raies it to upper case
                        // to avoid case senesitivity
                        answers = Console.ReadLine();
                        answers = answers.ToUpper();
                        // if correct get a point and the guess is saved
                        if (answers == testAswers[guessPositCount])
                        {
                            score = score + 1;
                            testGuess[guessPositCount] = answers;
                            guessPositCount = guessPositCount + 1;

                        }
                        // get it wrong and it still saves the guess
                        else
                        {
                            testGuess[guessPositCount] = answers;
                            guessPositCount = guessPositCount + 1;
                        }
                        // to keep test clean looking
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("Test Completed");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("__________________________________________________________");
                    // used to go through the array
                    int count = 0;
                    Console.WriteLine("Correct Answers: ");
                    // prints out acutal answers to test
                    foreach (string name in testAswers)
                    {
                        if (count == 0)
                        {
                            Console.Write(" " + testAswers[count]);
                            count = count + 1;
                        }
                        else
                        {
                            Console.Write(", " + testAswers[count]);
                            count = count + 1;
                        }
                    }
                    //-------------------------------------------
                    count = 0;
                    Console.WriteLine();
                    Console.WriteLine("Your Answers:");
                    // prints out what the users guessed
                    foreach (string name in testGuess)
                    {
                        if (count == 0)
                        {
                            Console.Write(" " + testGuess[count]);
                            count = count + 1;
                        }
                        else
                        {
                            Console.Write(", " + testGuess[count]);
                            count = count + 1;
                        }
                    }
                    count = 0;
                    Console.WriteLine();
                    Console.WriteLine();

                    // just checks if you passed or failed
                    Console.WriteLine("Your Finale Score is " + score);
                    if (score >= 7)
                    {
                        Console.WriteLine("You Passed Congratulations");
                        Console.WriteLine();
                    }

                    else
                    {
                        Console.WriteLine("Sorry You Failed Free To Try Again");
                        Console.WriteLine();
                    }
                    // will loop again so you can attempt the test again
                    Console.WriteLine("Press Y To Do The Test Again N to stop");
                    repeat = Console.ReadLine();
                    repeat = repeat.ToUpper();

                    Console.WriteLine("__________________________________________________________");

                }


            }
        }
    }
}