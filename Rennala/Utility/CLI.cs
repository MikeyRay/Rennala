﻿namespace Rennala.Utility
{
    internal static class CLI
    {
        /// <summary>
        /// Prints coloured text to the console
        /// </summary>
        /// <param name="colour"> Colour of choice </param>
        /// <param name="message"> What message to print </param>
        private static void ColouredPrint(ConsoleColor colour, string message)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void NeutralMessage(string message)   => ColouredPrint(ConsoleColor.Gray, message);
        public static void ErrorMessage(string message)     => ColouredPrint(ConsoleColor.Red, message);
        public static void SuccessMessage(string message)   => ColouredPrint(ConsoleColor.Green, message);
        public static void WaitMessage(string message)      => ColouredPrint(ConsoleColor.Blue, message);
        public static void NoticeMessage(string message)    => ColouredPrint(ConsoleColor.Yellow, message);

        /// <summary>
        /// Waits for the user to input a key to exit the program
        /// </summary>
        public static void WaitForUserConfirmation()
        {
            NeutralMessage("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
