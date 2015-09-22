using System;

namespace Utilities
{
    static public class ConsoleUtil
    {
        static public void ColoredWrite(string s, ConsoleColor color)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(s);
            Console.ForegroundColor = prevColor;
        }
        static public void ColoredWriteLine(string s, ConsoleColor color)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ForegroundColor = prevColor;
        }
    }
}
