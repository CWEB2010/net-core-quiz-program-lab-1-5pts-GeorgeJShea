
using System;
/*
_________________________________________________

George Shea ßeta Product
Created 22/1/2020
Version 4.3
Version Date: 27/1/2020

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
			string open = "Y";
			while (repeat == "Y")
			{
				// clear screen on restart
				// dont have test confirm once you go through again. 
				// intro screen teels you what the quiz is about
				Console.Clear();
				if (open == "Y")
				{
					Console.WriteLine("Programming Fundementals Test");
					Console.WriteLine("_________________________________________________");
					Console.WriteLine("This test will quiz you on");
					Console.WriteLine("on your knowledge of .net");
					Console.WriteLine("please answer in A,B,C or D");
					Console.WriteLine("if you fail to do so it is your own fault");
					Console.WriteLine("__________________________________________________");
					Console.WriteLine("Do You Wish To Begin y/n");
					begin = Console.ReadLine();
					open = "No More";
				}
				else
				{
					begin = "yes";
				}
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
						"Question 1: When was the .NET work originaly realesed? ", "A || 2002 ", "B || 2003 ", "C || 2004 ", "D || 2005",
						"Question 2: When  was the last update of .Net released? ", "A || 2014 ", "B || 2017 ", "C || 2020 ", "D || 2019",
						"Question 3: What update was this update? ", "A || 3.0 ", "B || 3.1 ", "C || 4.8 ", "D || 5.6 ",
						"Question 4: Which of the following launages is .NET compatable? ", "A || C# ", "B || Python ", "C || Gem ", "D || Cobol",
						"Question 5: Which Lauange used the .NETWORK first? ", "A || Gem ", "B || C++ ", "C || C# ", "D || F# ",
						"Question 6: Which one is a none .NET launage? ", "A || Gem ", "B || C# ", "C || F# ", "D || C++ ",
						"Question 7: What does CTS stand for? ", "A || Common Type System ", "B || C Type System ", "C || Common Law Systems ", "D || Cap Limit Systems",
						"Question 8: Correct syntax for writing to console ", "A || Print() ", "B || Writeline() ", "C || Writeline(); ", "D || Write(); ",
						"Question 9: What Does .NET do? ", "A || Translate ", "B || Compress ", "C || Magic ", "D || Compile ",
						"Question 10: We are being taught this launage ", "A || C# ", "B || Gem ", "C || Python ", "D || C++ ",
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

						int wrong = 0;
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
					// will show you what questiosn you got wrong more clearly
					Console.Clear();
					qLoop = 0;
					QCount = 0;
					while (qLoop < 10)

					{
						// this simply loops through in sets of 4 10 times 
						// this will display everything 

						// Green is correct
						// Red is incorrect guess
						// White is nuetural no guess no right
						//A

						// this is the exact same for A,B,C and D just with the letter switched
						// this prints out quistion x[1=10] depending on qloop
						Console.WriteLine(testQuestions[QCount], Console.ForegroundColor);
						// this makes sure that the right answer is always green
						if (testAswers[qLoop] == "A")
						{
							Console.ForegroundColor = ConsoleColor.Green;
						}
						// this is for when you are wrong! and makes it red
						else if (testGuess[qLoop] == "A")
						{
							Console.ForegroundColor = ConsoleColor.Red;
						}
						// this is if some one fails to follow instructions ie does nto type in A B C or D
						else if (testGuess[qLoop] != "A" && testGuess[qLoop] != "B" && testGuess[qLoop] != "C" && testGuess[qLoop] != "D")
						{
							Console.ForegroundColor = ConsoleColor.Red;
						}
						// this is simply white answers neither correct or incorrect
						else
						{
							Console.ForegroundColor = ConsoleColor.White;
						}

						//B
						QCount = QCount + 1;
						Console.WriteLine(testQuestions[QCount], Console.ForegroundColor);
						if (testAswers[qLoop] == "B")
						{
							Console.ForegroundColor = ConsoleColor.Green;
						}
						else if (testGuess[qLoop] == "B")
						{
							Console.ForegroundColor = ConsoleColor.Red;
						}
						else if (testGuess[qLoop] != "A" && testGuess[qLoop] != "B" && testGuess[qLoop] != "C" && testGuess[qLoop] != "D")
						{
							Console.ForegroundColor = ConsoleColor.Red;
						}
						else
						{
							Console.ForegroundColor = ConsoleColor.White;
						}

						//C
						QCount = QCount + 1;
						Console.WriteLine(testQuestions[QCount], Console.ForegroundColor);
						if (testAswers[qLoop] == "C")
						{
							Console.ForegroundColor = ConsoleColor.Green;
						}
						else if (testGuess[qLoop] == "C")
						{
							Console.ForegroundColor = ConsoleColor.Red;
						}
						else if (testGuess[qLoop] != "A" && testGuess[qLoop] != "B" && testGuess[qLoop] != "C" && testGuess[qLoop] != "D")
						{
							Console.ForegroundColor = ConsoleColor.Red;
						}
						else
						{
							Console.ForegroundColor = ConsoleColor.White;
						}

						//D
						QCount = QCount + 1;
						Console.WriteLine(testQuestions[QCount], Console.ForegroundColor);
						if (testAswers[qLoop] == "D")
						{
							Console.ForegroundColor = ConsoleColor.Green;
						}
						else if (testGuess[qLoop] == "D")
						{
							Console.ForegroundColor = ConsoleColor.Red;
						}
						else if (testGuess[qLoop] != "A" && testGuess[qLoop] != "B" && testGuess[qLoop] != "C" && testGuess[qLoop] != "D")
						{
							Console.ForegroundColor = ConsoleColor.Red;
						}
						else
						{
							Console.ForegroundColor = ConsoleColor.White;
						}
						QCount = QCount + 1;
						Console.WriteLine(testQuestions[QCount], Console.ForegroundColor);
						Console.ForegroundColor = ConsoleColor.White;
						QCount = QCount + 1;


						qLoop = qLoop + 1;
					}
					Console.WriteLine();
					Console.WriteLine("Test Completed");
					Console.WriteLine();
					Console.WriteLine();
					Console.WriteLine("__________________________________________________________");
					// used to go through the array
					int count = 0;
					// prints out acutal answers to test


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
						Console.WriteLine("The Required Score To Pass Is 7");
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

