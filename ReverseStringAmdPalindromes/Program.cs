namespace ReverseStringAmdPalindromes
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //defining some introduction text
            string introduction = "Welcome to the reverse string tool.\n" +
                                  "To start enter a word the system will display it in reverse.\n" +
                                  "Additionaly it will check if the word is a palindrome :)\n" +
                                  "HAVE FUN !\n\n\n";
            //printing the introduction text
            Console.WriteLine(introduction);

            while (true)
            {
                //Ask end user to enter a word
                Console.WriteLine("Please enter a word: ");

                //read user input
                string userInput = Console.ReadLine();

                if (userInput != null)
                {
                    string reverseUserInput = String.Empty;
                    //reverse user input and store it into reverseUserInput string variable
                    foreach (var item in userInput.Reverse())
                    {
                        //concatenating all chars since Reverse seperate each char in a string and transforms them into CHAR[] arrays
                        reverseUserInput += item;
                    }

                    //Store the boolean value to in order to determine if the userInput is a palindrome
                    bool isPalindrome = reverseUserInput == userInput;

                    //Display the result to the console
                    Console.WriteLine($"\n\n\nYou've entered: {userInput}");
                    Console.WriteLine($"The word in reverse gives: {reverseUserInput}");

                    //check if the userinput is a palindrome
                    if (isPalindrome)
                    {
                        Console.WriteLine($"The word {userInput} is a palindrome");                   
                    }
                    else
                    {
                        Console.WriteLine($"The word {userInput} is not a palindrome");
                    }
                    Console.WriteLine("\n\n\npress any key to continue ...");
                    Console.ReadKey();
                    Console.Clear();
                    

                }

            }




        }
    }
}