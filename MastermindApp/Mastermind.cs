using System;

namespace MastermindApp
{
    public class Mastermind
    {
        public static int NumberOfAttempts { get; set; } = 10;

        public static void Main()
        {

            int numberOfAttempts = NumberOfAttempts;

            while (numberOfAttempts <= 10 && numberOfAttempts > 0)
            {
                
               string randomNumber = GenerateRandomNumber();
               numberOfAttempts--;
                // this line was used to test the program and compare the userInput to the generated randomNumber
               //Console.WriteLine("Your starting number is: " + randomNumber);
               Console.WriteLine("Please guess a 4 digit number. Note: You can only use digits between 1-6.");
               string userInput = Console.ReadLine();
                if (userInput.Length == 4) 
                {
                    CheckNumber(randomNumber, userInput);
                    Console.WriteLine("Number of attempts remaining: " + numberOfAttempts);
                }
                else
                {
                    Console.WriteLine("To play, the entered value must be 4 digits in length.");
                }
               
                
              
            }
                // if userInput is entered 10 times, console spits out message saying user has 0 attempts left
                Console.WriteLine("Sorry, you have exhausted your 10 attempts.");
            
        }

        // Generates a random 4 digit number
        public static string GenerateRandomNumber()
        {
            string randomNumber = "";
            

            Random numberGenerator = new Random();

            for (int i = 1; i <= 4; i++)
            {
                randomNumber = (numberGenerator.Next(1, 7).ToString() + randomNumber);
                
            }

            return randomNumber;

            

        }

        public static void CheckNumber(string randomNumber, string userInput)
        {
            int correctDigit = 0;
            int correctPosition = 0;
            bool isFound = false;

            for (int i = 0; i < userInput.Length; i++)
            {
                isFound = false;

                for (int j = 0; j < randomNumber.Length; j++)
                {
                    
                    if (isFound == false)
                    {
                        // compares the values
                        if ((userInput[i] == randomNumber[j]) && (userInput[i] != 0))
                        {
                            isFound = true;
                            // checks to see if values are in the same position
                            if (i == j)
                            {
                                correctPosition++;

                            }
                            else
                            {
                                correctDigit++;

                            }
                           
                        }
                        
                   
                    }
                   

                }
               


            }
            


            Console.WriteLine("Numbers in the correct position: " + correctPosition + " Correct digits but in wrong position: " + correctDigit);

            // string to hold '+' and '-' 
            string result = "";

            // loop through correctPosition to find '+'
            for (int i = 0; i < correctPosition; i++)
            {
                result = result + "+";
            }

            // loop through correctdigits to find '-'
            for (int i = 0; i < correctDigit; i++)
            {
                if (correctDigit != correctPosition) 
                {
                    result = result + "-";
                }
            }


            if (result != "")
            {
                Console.WriteLine(result);
            }


            // if user wins, display the following message

            if (isFound)
            {
                if (result == "++++") 
                {
                    Console.WriteLine("You won!");
                }
                
            }



        }







    }
}
