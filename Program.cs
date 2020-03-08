using System;

namespace Homework_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Exercise 01
            //Declare two string variables
            //Initialize them and concatenate them in a new variable
            //Declare two string variables
            //Initialize them with the number 9 and 3
            //Concatenate them in a new variable
            //Print the results in the console
            #region exercise1
            var stringOne = "Word ";
            var stringTwo = "Up";
            var result = stringOne + stringTwo;

            Console.WriteLine($"Cameo: {result}");
            Console.ReadLine();
            #endregion


            // concat strings to get result
            //var numOne = "9";
            //var numTwo = "3";
            // var result3 = numOne + numTwo;

            //Console.WriteLine($"The Result is: {result3}");
            //Console.ReadLine();

            // Converted to get sum result
            var numberOne = "9";
            var numberTwo = "3";
            int convertedNumberOne = Convert.ToInt32(numberOne);
            int convertedNumberTwo = Convert.ToInt32(numberTwo);

            var result2 = convertedNumberOne + convertedNumberTwo;
           

            Console.WriteLine($"The Result is: {result2}");
            Console.ReadLine();

            #region exercise2

            //            Exercise 02
            //Declare an integer and a string variable
            //Initialize them and concatenate them in a new variable
            //Print the result in the console

            int numeroUno = 550;
            string someWords = " NZXT";
            var exerciseTwoResult = numeroUno + someWords;
        
            Console.WriteLine(exerciseTwoResult);
            Console.ReadLine();

            #endregion

            #region exercise3
            //            Exercise 03
            //You have n credits on your mobile bill. One SMS costs m credits.How many SMS messages you can send?

            //n = 102
            //m = 5
            //Result = ?

            double n = 102;
            double m = 5;
            var  resultSmsCost = n / m;
            Console.WriteLine($"One SMS costs {m} credits. You can send  {resultSmsCost} SMS messages");
            Console.ReadLine();
            #endregion

            #region exercise4(bonus)
            //    Exercise 04(*BONUS)
            //Set variable from input
            //TRY to convert it to int
            //if its converted successfully print in the console if number is odd or even
            //else if its not converted, print in the console that user inserted invalid input
            //Hint: if number / 2 has remainder 0 its even, else its odd

            Console.WriteLine("Just Type Something!");
            var userInput = Console.ReadLine();
            int inputNumber;
            bool parsedNumber = int.TryParse(userInput, out inputNumber);
            
            if (parsedNumber) {
                var evenOrOdd = inputNumber % 2 == 0 ? "even" : "odd";
                Console.WriteLine(evenOrOdd );
            }
            else
            {
                Console.WriteLine("Invalid Input. Please Try Again!");
            }
            Console.ReadLine();
           
            #endregion
        }
    }
}
