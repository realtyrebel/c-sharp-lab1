using System;// allows the use of Console

namespace Lab1
{
    //class FirstProgram
    //
    public class FirstProgram
    {
        //static void Main(string[] args)
        public static void Main()
        {
            // Create a string variable and initialize it to an empty string
            // Note: this is NOT a space
            // - it is two double quotes right next to each other
            //string name = "";// initialize a string variable
            int name;// initialize an integer variable

            // Display a prompt to the user
            Console.Write("What is your name?");
            Console.Beep();

            // Capture the user's response
            // name = Console.ReadLine();
            name = int.Parse(Console.ReadLine());

            // Display a string literal combined with the value of the string variable
            // What does the "\n" do?
            Console.Write("Hello " + name + "\n");

            // Waits for the user to press a key
            // Allows us to read what was displayed
            // Otherwise the program would close without this line
            Console.Read();
        }
    }
}
