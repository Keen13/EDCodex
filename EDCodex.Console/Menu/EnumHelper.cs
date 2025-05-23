using EDCodex.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Codex.Menu;

public static class EnumHelper
{
    /// <summary>
    /// Shows all possible options provided by enum.
    /// Options are shown in columns.
    /// </summary>
    /// <param name="numberOfColumns">Number of columns</param>
    /// <param name="columnWidth">Column width</param>
    public static void ShowEnumOptions<T>(int numberOfColumns = 1, int columnWidth = 40) where T: Enum
    {
        var stringValues = Enum.GetValues(typeof(T))
            .Cast<object>()
            .Select(value => $"{(int) value} - {((T) value).GetDescription()};");
        ShowStringsInColumns(stringValues, numberOfColumns, columnWidth);                
    }

    // TODO VS should not be here
    public static void ShowStringsInColumns(IEnumerable<string> values, int numberOfColumns, int columnWidth)
    {
        values = RearrangeListForPrintingInColumns(values.ToList(), numberOfColumns); 
            
        var valuesInLine = 0;
        foreach (var value in values)
        {
            Console.Write(value.PadRight(columnWidth));
            valuesInLine++;

            if (valuesInLine == numberOfColumns)
            {
                Console.WriteLine();
                valuesInLine = 0;
            }
        }

        if (valuesInLine != numberOfColumns)
        {
            Console.WriteLine();
        }
    }

    private static List<string> RearrangeListForPrintingInColumns(List<string> input, int numberOfColumns)
    {
        var recordsInColumn = new int[numberOfColumns];
        var baseNumber = input.Count / numberOfColumns;
        var additionals = input.Count % numberOfColumns;
        for (var i = 0; i < recordsInColumn.Length; i++)
        {
            recordsInColumn[i] = baseNumber;
            if (i < additionals)
            {
                recordsInColumn[i]++;
            }		
        }
	
        var matrix = new string[recordsInColumn[0], numberOfColumns];

        var row = 0;
        var column = 0;
        foreach (var value in input)
        {
            matrix[row, column] = value;
            row++;
            if (row >= recordsInColumn[column])
            {
                row = 0;
                column++;
            }
        }

        return matrix.Cast<string>().Where(s => s != null).ToList();
    }
    
    public static T GetEnumValueFromInput<T>(string prompt = null) where T : Enum
    {
        if (!string.IsNullOrEmpty(prompt))
        {
            Console.Write($"{prompt}: ");
        }
        
        int input;
        var enumValues = Enum.GetValues(typeof(T)).Cast<int>();
        while (!int.TryParse(Console.ReadLine(), out input) || input < enumValues.First() || input > enumValues.Last())
        {
            Console.Write("Try again: ");
        }

        return (T)Enum.Parse(typeof(T), input.ToString());
    }

    public static TOut Convert<TIn, TOut>(this TIn inEnumValue)
        where TIn : Enum
        where TOut : Enum
    {
        return (TOut) Enum.Parse(typeof(TOut), inEnumValue.ToString());
    }

    public static GalacticRegion SelectGalacticRegionFromInput()
    {
        ShowEnumOptions<GalacticRegion>(3, 35);
        return GetEnumValueFromInput<GalacticRegion>("Select region");
    }
}
