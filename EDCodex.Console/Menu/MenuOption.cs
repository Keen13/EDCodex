using System;
using System.Text.RegularExpressions;

namespace ED_Codex.Menu
{
    public class MenuOption
    {
        public MenuOption()
        { }

        public MenuOption(string input)
        {
            var regex = new Regex(@"(\d+) *- *([\w\s\d]+)");
            if (!regex.IsMatch(input))
            {
                throw new ArgumentException($"Invalid input string for MenuOption: {input}");
            }

            var match = regex.Match(input);
            Key = match.Groups[1].Value;
            DisplayKey = Key;
            Description = match.Groups[2].Value;
        }

        public MenuOption(string input, Func<bool> action)
            : this(input)
        {
            Action = action;
        }

        public MenuOption(string input, Action action)
            : this(input)
        {
            Action = () =>
            {
                action();
                return true;
            };
        }

        public string Key { get; set; }

        public string DisplayKey { get; set; }
        
        public string Description { get; set; }
        
        public Func<bool> Action { get; set; }
    }
}