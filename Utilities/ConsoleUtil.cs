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
        static public void ColoredBGWrite(string s, ConsoleColor bgColor)
        {
            ConsoleColor prevBackgroundColor = Console.BackgroundColor;
            Console.BackgroundColor = bgColor;
            Console.Write(s);
            Console.BackgroundColor = prevBackgroundColor;
        }
        static public void ColoredBGWrite(string s, ConsoleColor fgColor, ConsoleColor bgColor)
        {
            ConsoleColor prevForegroundColor = Console.ForegroundColor;
            ConsoleColor prevBackgroundColor = Console.BackgroundColor;
            Console.ForegroundColor = fgColor;
            Console.BackgroundColor = bgColor;
            Console.Write(s);
            Console.ForegroundColor = prevForegroundColor;
            Console.BackgroundColor = prevBackgroundColor;
        }

        static public void WaitKeyExit()
        {
            Console.WriteLine();
            Console.WriteLine("Enter any key to exit...");
            Console.ReadKey();
        }
    }
}
