using System;
/*
_________________________________________________
George Shea                          ßeta Product
Created 22/1/2020
Version 1.0
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
                // this will see if the student is ready to test
                // just a nice little intro screen
                Console.WriteLine("Programming Fundementals Test");
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("This test will quiz you on");
                Console.WriteLine("on your knowledge of c#");
                Console.WriteLine("please answer lower case");
                Console.WriteLine("__________________________________________________");
                Console.WriteLine("do you wish to begin y/n");
                begin = Console.ReadLine();

                if (begin == "n")
                {
                    // finishs code and concludes with a goodbye
                    Console.WriteLine("Have a lovely day remember this quiz must be completed");
                }
                else
                {

                    string[] testAswers = { "A", "B", "C", "A", "D",
                        "A", "A", "C", "D", "A" };
                    string[] testQuess = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };

                    int score = 0;
                    // score is responsible for quiz grade
                    // this will be quizes 

                    //____________________________________________________________________________

                    // takes user input and sees if it matches test answer
                    // A correct answer

                    string answerOne;

                    Console.WriteLine("Question 1");
                    Console.WriteLine(" A|| words");
                    Console.WriteLine(" B|| words");
                    Console.WriteLine(" C|| words");
                    Console.WriteLine(" D|| words");
                    answerOne = Console.ReadLine();
                    answerOne = answerOne.ToUpper();
                    if (answerOne == testAswers[0])
                    {
                        score = score + 1;
                        testQuess[0] = answerOne;

                    }
                    else
                    {
                        testQuess[0] = answerOne;
                    }
                    Console.WriteLine();
                    //_____________________________________________________________________________________
                    // question 2
                    string answerTwo;

                    Console.WriteLine("Question 2");
                    Console.WriteLine(" A|| words");
                    Console.WriteLine(" B|| words");
                    Console.WriteLine(" C|| words");
                    Console.WriteLine(" D|| words");
                    answerTwo = Console.ReadLine();
                    answerTwo = answerTwo.ToUpper();
                    if (answerTwo == testAswers[1])
                    {
                        score = score + 1;
                        testQuess[1] = answerTwo;

                    }
                    else
                    {
                        testQuess[1] = answerTwo;
                    }
                    Console.WriteLine();
                    //_____________________________________________________________________________________
                    // question 3
                    string answerThree;

                    Console.WriteLine("Question 3");
                    Console.WriteLine(" A|| words");
                    Console.WriteLine(" B|| words");
                    Console.WriteLine(" C|| words");
                    Console.WriteLine(" D|| words");
                    answerThree = Console.ReadLine();
                    answerThree = answerThree.ToUpper();
                    if (answerThree == testAswers[2])
                    {
                        score = score + 1;
                        testQuess[2] = answerThree;

                    }
                    else
                    {
                        testQuess[2] = answerThree;
                    }
                    Console.WriteLine();
                    //_______________________________________________________________________________________
                    // question 4
                    string answerFour;

                    Console.WriteLine("Question 4");
                    Console.WriteLine(" A|| words");
                    Console.WriteLine(" B|| words");
                    Console.WriteLine(" C|| words");
                    Console.WriteLine(" D|| words");
                    answerFour = Console.ReadLine();
                    answerFour = answerFour.ToUpper();
                    if (answerFour == testAswers[3])
                    {
                        score = score + 1;
                        testQuess[3] = answerFour;

                    }
                    else
                    {
                        testQuess[3] = answerFour;
                    }
                    Console.WriteLine();
                    //_______________________________________________________________________________________
                    // question 5
                    string answerFive;

                    Console.WriteLine("Question 5");
                    Console.WriteLine(" A|| words");
                    Console.WriteLine(" B|| words");
                    Console.WriteLine(" C|| words");
                    Console.WriteLine(" D|| words");
                    answerFive = Console.ReadLine();
                    answerFive = answerFive.ToUpper();
                    if (answerFive == testAswers[4])
                    {
                        score = score + 1;
                        testQuess[4] = answerFive;

                    }
                    else
                    {
                        testQuess[4] = answerFive;
                    }
                    Console.WriteLine();
                    //_______________________________________________________________________________________
                    // question 6
                    string answerSix;

                    Console.WriteLine("Question 6");
                    Console.WriteLine(" A|| words");
                    Console.WriteLine(" B|| words");
                    Console.WriteLine(" C|| words");
                    Console.WriteLine(" D|| words");
                    answerSix = Console.ReadLine();
                    answerSix = answerSix.ToUpper();
                    if (answerSix == testAswers[5])
                    {
                        score = score + 1;
                        testQuess[5] = answerSix;

                    }
                    else
                    {
                        testQuess[5] = answerSix;
                    }
                    Console.WriteLine();
                    //_______________________________________________________________________________________
                    // question 7
                    string answerSeven;

                    Console.WriteLine("Question 7");
                    Console.WriteLine(" A|| words");
                    Console.WriteLine(" B|| words");
                    Console.WriteLine(" C|| words");
                    Console.WriteLine(" D|| words");
                    answerSeven = Console.ReadLine();
                    answerSeven = answerSeven.ToUpper();
                    if (answerSeven == testAswers[6])
                    {
                        score = score + 1;
                        testQuess[6] = answerSeven;

                    }
                    else
                    {
                        testQuess[6] = answerSeven;
                    }
                    Console.WriteLine();
                    //_______________________________________________________________________________________
                    // question 8
                    string answerEight;

                    Console.WriteLine("Question 8");
                    Console.WriteLine(" A|| words");
                    Console.WriteLine(" B|| words");
                    Console.WriteLine(" C|| words");
                    Console.WriteLine(" D|| words");
                    answerEight = Console.ReadLine();
                    answerEight = answerEight.ToUpper();
                    if (answerEight == testAswers[7])
                    {
                        score = score + 1;
                        testQuess[7] = answerEight;

                    }
                    else
                    {
                        testQuess[7] = answerEight;
                    }
                    Console.WriteLine();
                    //_______________________________________________________________________________________
                    // question 9
                    string answerNine;

                    Console.WriteLine("Question 9");
                    Console.WriteLine(" A|| words");
                    Console.WriteLine(" B|| words");
                    Console.WriteLine(" C|| words");
                    Console.WriteLine(" D|| words");
                    answerNine = Console.ReadLine();
                    answerNine = answerNine.ToUpper();
                    if (answerNine == testAswers[8])
                    {
                        score = score + 1;
                        testQuess[8] = answerNine;

                    }
                    else
                    {
                        testQuess[8] = answerNine;
                    }
                    Console.WriteLine();
                    //_______________________________________________________________________________________
                    // question 10 yea
                    string answerTen;

                    Console.WriteLine("Question 10");
                    Console.WriteLine(" A|| words");
                    Console.WriteLine(" B|| words");
                    Console.WriteLine(" C|| words");
                    Console.WriteLine(" D|| words");
                    answerTen = Console.ReadLine();
                    answerTen = answerTen.ToUpper();
                    if (answerTen == testAswers[9])
                    {
                        score = score + 1;
                        testQuess[9] = answerTen;

                    }
                    else
                    {
                        testQuess[9] = answerTen;
                    }
                    Console.WriteLine();
                    //____________________________________________________
                    // score screen
                    Console.WriteLine();
                    Console.WriteLine("Test Completed");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("__________________________________________________________");
                    int count = 0;
                    Console.WriteLine("Correct Answers: ");
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
                    count = 0;
                    Console.WriteLine();
                    Console.WriteLine("Your Answers:");
                    foreach (string name in testQuess)
                    {
                        if (count == 0)
                        {
                            Console.Write(" " + testQuess[count]);
                            count = count + 1;
                        }
                        else
                        {
                            Console.Write(", " + testQuess[count]);
                            count = count + 1;
                        }
                    }
                    count = 0;
                    Console.WriteLine();
                    Console.WriteLine();

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
                    Console.WriteLine("Press Y To Do The Test Again N to stop");
                    repeat = Console.ReadLine();
                    repeat = repeat.ToUpper();

                    Console.WriteLine("__________________________________________________________");

                }


            }
        }
    }
}
