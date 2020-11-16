/*########################################################################################################
 Name: Abigail Herron
 ID: S00200536
 Year: 2
 Date: 16/11/20

 Description: Testing out an 'Extension' method that counts all words in a sentence
 Parameters: UserInput
 ########################################################################################################*/
using System;

namespace Extension
{
    class ExtensionProgram
    {
        static void Main(string[] args)
        {
            string userInput = "";
            Console.Write("Type something please: ");
            userInput = Console.ReadLine();

            Console.WriteLine($"\nThe number of words you typed is: {Extension(userInput)}");
        }// end Main()




        /*METHODS----------------------------------------------------------------------------------------*/
        /*Method: Extension()
                  1) Takes in a string variable
                  2) Loops through the string and counts how many words there are in it
                  3) Outputs the number of words in the string (int value) */
        public static int Extension(string input)
        {
            int words = 0;
            input = input.Trim(); // taking off any unecessary white spaces

            // Itterating through the string
            for(int i = 0; i < (input.Length - 1); i++)
            {
                // checking if the char at index i is equal to a space, line brake or tab
                if(input[i] == ' ' || input[i] == '\n' || input[i] == '\t')
                {
                    words++;
                }
            }// end for block


            // checking for one word inputs (I could have done this before the loop, but then I'd mess up the index)
            if (input.Length != 0)
            {
                words++;
            }// end if block


            return words;
        }// end Extension()

    }// end Class
}// end Namespace
