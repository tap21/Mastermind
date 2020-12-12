using System;

namespace MastermindApp
{
    public class Mastermind
    {
        public static int NumberOfAttempts { get; set; } = 10;

        public static void Main()
        {
            Mastermind mastermind = new Mastermind();

            int numberOfAttempts = NumberOfAttempts;

            string randomNumber = GenerateRandomNumber();

            while (numberOfAttempts <= 10 && numberOfAttempts > 0)
            {
               numberOfAttempts--;
                // this line was used to test the program and compare the userInput to the generated randomNumber
               //Console.WriteLine("Your starting number is: " + randomNumber);

               Console.WriteLine("Please guess a 4 digit number. Note: You can only use digits between 1-6.");
               string userInput = Console.ReadLine();
               
              string result = mastermind.PrintChecksAndMinuses(randomNumber, userInput);
              Console.WriteLine("Number of attempts remaining: " + numberOfAttempts);

              Console.WriteLine($"{result}");
                
            
            }
            
                // if userInput is entered 10 times, game is over and randomNumber is disclosed to user
                Console.WriteLine($"Sorry, you have exhausted your 10 attempts. Your number was {randomNumber}.");
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


        // Checks to make sure the userInput is 4 in length with values between 1-6
        public bool IsUserInputValid(string userInput)
        {
           if(userInput.Length != 4)
           {
               return false;

           }
            foreach (char c in userInput)
            {
                if(!(c >= '0' && c <= '6'))
                {
                    return false;
                }
            }
                
            return true;
        }


        // Adds all '+' scenarios
        public string CheckForCorrectPositionCorrectValue(string randomNumber, string userInput)
        {
            string correctPositionCorrectValue = "";

            for (int i = 0; i < 4; i++)
            {
                if (randomNumber[i] == userInput[i])
                {
                    correctPositionCorrectValue += "+";
                }
            }
            return correctPositionCorrectValue;
        }

        // Adds all '-' scenarios
        public string CheckForCorrectValueIncorrectPosition(string randomNumber, string userInput)
        {
            string correctValueIncorrectPosition = "";

            for (int i = 0; i < 4; i++)
            {
                if (randomNumber.Contains(userInput[i]) && randomNumber[i] != userInput[i])
                {
                    correctValueIncorrectPosition += "-";
                }
            }
            return correctValueIncorrectPosition;

        }
       
        // Combines both '+' and '-' scenarios together
        public string PrintChecksAndMinuses(string randomNumber, string userInput)
        {

            if (IsUserInputValid(userInput) == true)
            {
                string plusSigns = CheckForCorrectPositionCorrectValue(randomNumber, userInput);
                string minusSigns = CheckForCorrectValueIncorrectPosition(randomNumber, userInput);
                string combinedPlusAndMinuses = plusSigns + minusSigns;
                return combinedPlusAndMinuses;
            }
            else
            {
                return "You have entered an incorrect value.";
            }
       
        }




        //public static void CheckNumber(string randomNumber, string userInput)
        //{
        //    int correctDigit = 0;
        //    int correctPosition = 0;
        //    bool isFound = false;

        //    for (int i = 0; i < userInput.Length; i++)
        //    {
        //        isFound = false;

        //        if (userInput[i] == randomNumber[i])
        //        {
        //            correctPosition++;
        //        }
        //        else
        //        {
        //            for (int j = 0; j < randomNumber.Length; j++)
        //            {
        //                if (userInput[i] == userInput[j])
        //                {
        //                    correctDigit++;
        //                }
        //               /* if (isFound == false)
        //                {
        //                    // compares the values

        //                    if ((userInput[i] == randomNumber[j]) && (userInput[i] != 0))
        //                    {
        //                        isFound = true;
        //                        // checks to see if values are in the same position
        //                        if (i == j)
        //                        {
        //                            correctPosition++;

        //                        }
        //                        else
        //                        {
        //                            correctDigit++;

        //                        }
        //                    }
        //                }*/
        //            }

        //        }
               


        //    }
            


        //    Console.WriteLine("Numbers in the correct position: " + correctPosition + " Correct digits but in wrong position: " + correctDigit);

        //    // string to hold '+' and '-' 
        //    string result = "";

        //    // loop through correctPosition to find '+'
        //    for (int i = 0; i < correctPosition; i++)
        //    {
        //        result = result + "+";
        //    }

        //    // loop through correctdigits to find '-'
        //    for (int i = 0; i < correctDigit; i++)
        //    {
        //        if (correctDigit != correctPosition) 
        //        {
        //            result = result + "-";
        //        }
        //    }


        //    if (result != "")
        //    {
        //        Console.WriteLine(result);
        //    }


        //    // if user wins, display the following message

        //    if (isFound)
        //    {
        //        if (result == "++++") 
        //        {
        //            Console.WriteLine("You won!");
        //        }
                
        //    }



        //}








    }
}
