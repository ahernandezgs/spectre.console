using System;

namespace Spectre.Console
{
    /// <summary>
    /// A console capable of writing ANSI escape sequences.
    /// </summary>
    public static partial class AnsiConsole
    {
        /// <summary>
        /// Writes the specified markup to the console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write.</param>
        public static void Markup([MarkupText] string format, params object[] args)
        {
            Console.Markup(format, args);
        }

        /// <summary>
        /// Writes the specified markup to the console.
        /// </summary>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write.</param>
        public static void Markup(IFormatProvider provider, [MarkupText] string format, params object[] args)
        {
            Console.Markup(provider, format, args);
        }

        /// <summary>
        /// Writes the specified markup, followed by the current line terminator, to the console.
        /// </summary>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write.</param>
        public static void MarkupLine([MarkupText] string format, params object[] args)
        {
            Console.MarkupLine(format, args);
        }

        /// <summary>
        /// Writes the specified markup, followed by the current line terminator, to the console.
        /// </summary>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <param name="format">A composite format string.</param>
        /// <param name="args">An array of objects to write.</param>
        public static void MarkupLine(IFormatProvider provider, [MarkupText] string format, params object[] args)
        {
            Console.MarkupLine(provider, format, args);
        }
    }
}
