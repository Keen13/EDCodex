using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ED_Codex.Enums;

namespace ED_Codex
{
    public static class EnumHelper
    {
        public static void ShowEnumOptions<T>(int maxOptionsInLine = 1, int padWidth = 40) where T: Enum
        {
            var optionsInLine = 0;
            foreach (var region in Enum.GetValues(typeof(T)))
            {
                Console.Write($"{((T)region).GetDescription()} - {(int)region};".PadRight(padWidth));
                optionsInLine++;

                if (optionsInLine == maxOptionsInLine)
                {
                    Console.WriteLine();
                    optionsInLine = 0;
                }
            }

            if (optionsInLine != maxOptionsInLine)
            {
                Console.WriteLine();
            }
        }
        public static T GetEnumValueFromInput<T>() where T : Enum
        {
            int input;
            var enumValues = Enum.GetValues(typeof(T)).Cast<int>();
            while (!int.TryParse(Console.ReadLine(), out input) || input < enumValues.First() || input > enumValues.Last())
            {
                Console.Write("Try again: ");
            }

            return (T)Enum.Parse(typeof(T), input.ToString());
        }
    }
}
