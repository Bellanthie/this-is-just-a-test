using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SUT25_Lektion_Petter_GitHubGruppArbete
{
    internal class Program
    {
        static int Main(string[] args)
        {
        }

        static void Calculate(string userInput)
        {
            char[] line = userInput.ToCharArray(); //Chops up the string so we can look at each character alone
            string number = ""; // Temp string to add chars (number) together to then convert to Int
            int i = 0; //Counter
            string matOperator = "";
            int userNumberOne = 0;
            int userNumberTwo = 0;

        
            int temp = 0; //Temp nummer

            while (int.TryParse(line[i].ToString(), out temp) == true) //Will add char to "number" untill it finds a non int convertable (not a number)
            {                
                number += line[i]; //Adds char to string
                i++; //Adds to counter
            }

            userNumberOne = int.Parse(number); //places the number i the int

            number = ""; //resets the temp string

            matOperator = line[i].ToString(); //now we have an operator
            i++;

            while (int.TryParse(line[i].ToString(), out temp) == true && i <= line.Length) 
            {
                number += line[i];
                i++; //Adds to counter
            }

            userNumberTwo = int.Parse(number);

            switch (matOperator)
            {
                case "*":
                    return Multiplication(userNumberOne, userNumberTwo);

                case "+":
                    return Addition(userNumberOne, userNumberTwo);
            }
        }

        static int Multiplication(int one, int two)
        {
            return one * two;
            //test
        }

        static int Addition(int one, int two)
        {
            return one + two;

        }
    }
}