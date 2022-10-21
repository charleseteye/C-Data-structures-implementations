using System;

namespace StringLearning
{
    class Program
    {
        static void Main(string[] args)
        {

           // //String.ToUpper()- ToUpper function converts string to upper case
           // string myName = "myName is Shreesh";
           // myName = myName.ToUpper();
           // Console.WriteLine(myName);


           // //String.ToLower()- ToUpper function converts string to upper case
           // string myNameLower = "myName is Shreesh";
           // myNameLower = myNameLower.ToLower();
           // Console.WriteLine(myNameLower);

           // //string.Trim() - Trim function removes extra spaces from the beginning and the ending of string.
           // string myNameTrim = "     myName is SHREESH       ";
           // myNameTrim = myNameTrim.Trim();
           // Console.WriteLine(myNameTrim);


           //// String.Contains() - Contains method return bool value, it checks whether specified string or character exist in string or not.
           // string myNameContains = "myName is SHREESH";
           // bool isContains = myNameContains.Contains("S");
           // Console.WriteLine(isContains);

           // //String.ToCharArray() - Convert a string to array of character.
           // string myString = "myName is SHREESH";
           // char[] charArray = myName.ToCharArray();
           // foreach (char c in charArray)
           // {
           //     Console.WriteLine(c);
           //    // Console.WriteLine(charArray);
           // }

           // //String.Substring() - substring method returns substring of a string.
           // string mySubtringCharacter = "myName is SHREESH";
           // mySubtringCharacter = mySubtringCharacter.Substring(0, 6);
           // Console.WriteLine(mySubtringCharacter);







           // Console.WriteLine("Hello World!");
            getOrgString("WelcomeToAndela");
        }


        //Given a string in camelCase format,the task is to convert the string into a readable form

        public static void getOrgString(string input) {

            //Console.Write(input[0]);

            //Taverse the rest of the characters one by one

            int i = 0;

            while(i < input.Length)
            {
                //if current character is uppercase
                //print space follwed by the 
                // current character in lowercase

                if (input[i] >= 'A' && input[i] <= 'Z')

                    Console.Write(" " + char.ToLower(input[i]));

                else
                    Console.Write(input[i]);

                i++;

            }

        }
    }
}
