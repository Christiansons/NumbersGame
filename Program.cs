using System.ComponentModel;

namespace GuessingGame_v2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Create a random number from 1-20
			Random myRandom = new Random();
			int myNumber = myRandom.Next(1, 21);
			//Counter that limits guesses
			int counter = 5;

			Console.WriteLine("Gissa tal mellan 1-20, du har fem försök!");

			//Collect the users guess
			double guess = int.Parse(Console.ReadLine());

			//If statements that checks if the guess is higher or lower
			if (guess < myNumber)
			{
				Console.WriteLine("Numret är högre");
			}
			else if (guess > myNumber)
			{
				Console.WriteLine("lägre");
			}
			//Reduce the counter by 1
			counter--;

			//Loop that keeps the game going until the counter runs out
			while (counter > 0)
			{
				//Variable that stores the previous guess
				double previousGuess = guess;
				//Gets next guess from user
				guess = int.Parse(Console.ReadLine());

				//If-statement if the guess is correct
				if (myNumber == guess)
				{
					//Reduce the counter by 1 and lets the user know how many guesses they got it in
					counter--;
					Console.WriteLine($"Grattis! du klarade det med {counter} försök kvar");
					break;
				}
				//If-statement that checks if the guess is closer to the previous guess
				else if (difference(guess, myNumber) < difference(previousGuess, myNumber))
				{
					Console.WriteLine("Varmare");
				}
				//If-statement that checks if the guess is further from the previous guess
				else if (difference(guess, myNumber) > difference(previousGuess, myNumber))
				{
					Console.WriteLine("Kallare");
				}
				//Else statement that executes if the guess is as close as the previous guess
				else
				{
					Console.WriteLine("Samma temperatur!");
				}
				counter--;
			}
			//If-statement if the number wasent guessed in 5 guesses
			if (guess != myNumber)
				Console.WriteLine($"Slut på försök, numret var {myNumber}!");
		}

		//Method that checks the difference between the guess and the random number
		static double difference(double guess, int myNumber)
		{
			//calculate the difference
			double difference = guess - myNumber;

			//Convert a negative difference to positive
			if (difference < 0)
			{
				difference = difference *-1;
			}
			return difference;
		}
	}
}

