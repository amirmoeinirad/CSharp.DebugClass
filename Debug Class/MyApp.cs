
// Amir Moeini Rad
// April 29, 2025

// Main Concept: Debug Class
// The 'Debug' class is used to write information to the debug output window in Visual Studio or Rider.
// Additional Concepts: String Manipulation, DateTime Struct

using System;
using System.Diagnostics;

namespace DebugClass
{
    internal abstract class MyApp
    {
        public static void Main()
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("Debug Class in C#.NET.");
            Console.WriteLine("----------------------\n");


            Console.WriteLine("Run the program in the Debug Mode: Press F5 in Visual Studio.");
            Console.WriteLine("Then, look at the Output pane in Visual Studio.");

            const int firstValue = 4;
            const int secondValue = 5;

            // Will be written in the output window in Visual Studio/Rider in the debug mode.
            Debug.WriteLine(firstValue + secondValue);

            // -------------------------------------

            string fullName = "William Wallace";
            string firstName, lastName;

            int index = fullName.IndexOf(" ");
            firstName = fullName.Substring(0,index);
            lastName = fullName.Substring(index+1);

            Debug.WriteLine(firstName);
            Debug.WriteLine(lastName);

            // -------------------------------------

            // Other String Methods:
            // String.Trim()
            // String.TrimEnd()
            // String.TrimStart()
            // String.Remove()
            // String.Replace(findText,replaceText)

            // -------------------------------------

            // Define a specific date and time.
            DateTime myDateTime = new DateTime(2012, 10, 14, 14, 23, 58);
            Debug.WriteLine(myDateTime);

            DateTime mySystemDate = DateTime.Now;
            Debug.WriteLine(mySystemDate);

            
            Console.WriteLine("\nDone.");
        }  
    }
}
