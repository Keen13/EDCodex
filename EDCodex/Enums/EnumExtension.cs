using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ED_Codex.Enums
{
    public static class EnumExtension
    {
        public static string GetDescription(this Enum value)
        {
            var shouldNotSplitByWords = value is StarClass ||
                value is GasGiantPlanetType ||
                value is TerrestrialPlanetType; 
            
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            if (name != null)
            {
                var fieldInfo = type.GetField(name);
                if (fieldInfo != null)
                {
                    var attribute = Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attribute != null && !string.IsNullOrEmpty(attribute.Description))
                    {
                        return attribute.Description;
                    }
                }
            }

            // No Description attribute or Description is empty  
            var rawValue = value.ToString();
            if (value is SpaceFeature && new Regex(@"\w\d\d").IsMatch(rawValue))
            {
                rawValue += "TypeAnomaly"; // quick fix for space anomalies description
            }
            return shouldNotSplitByWords ? rawValue : SplitByWords(rawValue);
        }

        private static string SplitByWords(string input)
        {
            var sb = new StringBuilder();
            foreach (var c in input)
            {
                if (char.IsUpper(c))
                {
                    sb.Append(' ');
                }
		
                sb.Append(c);
            }

            return sb.ToString().Trim();
        }
    }
}
