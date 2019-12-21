using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace libRPG.Debug
{
    public enum LogLevel
    {
        PRINTING_NOTHING,
        PRINTING_ERRORS,
        PRINTING_DEBUG,
        PRINTING_VERBOSE,
        PRINTING_ALL
    }

    public static class DebugManager
    {
        public static List<ILogger> Loggers = new List<ILogger>();

        public static void Print(string message)
        {
            foreach (ILogger logger in Loggers)
            {
                logger.Print(message);
            }
        }

        /// <summary>
        /// This function will print a debug message to display some information about the game process.
        /// Use this function mostly to plan fixes for bugs that aren't a priority.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="message"></param>
        public static void PrintDebug(object sender, string message)
        {
            foreach (ILogger logger in Loggers)
            {
                logger.PrintDebug(sender, message);
            }
        }

        /// <summary>
        /// This function will print an error
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="message"></param>
        public static void PrintError(object sender, string message)
        {
            foreach (ILogger logger in Loggers)
            {
                logger.PrintError(sender, message);
            }
        }

        /// <summary>
        /// This function will print an error then force close the program.
        /// </summary>
        /// <param name="sender">The sender of the function, just use this in most cases.</param>
        /// <param name="message">Your error message, it will be printed to the console.</param>
        public static void FatalError(object sender, string message)
        {
            foreach (var logger in Loggers)
            {
                logger.PrintError(sender, message);
                logger.Print("This error is a fatal error, the game will now close");
            }
            GameSystem.Exit();
        }

    }
}