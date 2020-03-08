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
            //var stringOne = "Word ";
            //var stringTwo = "Up";
            //var result = stringOne + stringTwo;

            //Console.WriteLine($"Cameo: {result}");
            //Console.ReadLine();
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
        }
    }
}
