using System;
using System.Collections.Generic;
using System.Linq;
using EDCodex.Data.Models;
using EDCodex.Data.Enums;
using EDCodex.Data;

namespace ED_Codex.Menu;

public abstract class MenuBase
{
    private bool _shouldAutoRunOption = true;
    
    protected int _numberOfColumns = 1;
    protected int _columnWidth = 40;

    protected static Codex Codex => DbAccessor.Codex;

    protected static GalacticRegion CurrentRegion => DbAccessor.Codex.CurrentRegion;

    protected List<MenuOption> Options { get; set; } = new List<MenuOption>();

    protected MenuBase()
    {
        InitializeOptions();
        AddCommonOptions();
    }

    protected abstract void InitializeOptions();
    
    protected void AddCommonOptions()
    {
        var returnOption = new MenuOption
        {
            Key = string.Empty,
            DisplayKey = "\u23ce",
            Description = "Return to previous menu or Exit",
            Action = () => false
        };
        
        Options.Insert(0, returnOption);
    }

    protected void AddOption(string key, string description, Func<bool> action)
    {
        var option = new MenuOption
        {
            Key = key,
            DisplayKey = key,
            Description = description,
            Action = action
        };
        
        Options.Add(option);
    }

    protected void AddOption(string key, string description, Action action)
    {
        Func<bool> actionThatStaysInMenu = () =>
        {
            action();
            return true;
        };

        AddOption(key, description, actionThatStaysInMenu);
    }

    public virtual bool ShowAndRun(string autoRunOptionKey = null)
    {
        ShowMenu();
        return RunMenu(autoRunOptionKey);
    }

    protected virtual void ShowMenu()
    {
        Console.Clear();
        Console.WriteLine($"Current region: {CurrentRegion.GetDescription()} ({(int)CurrentRegion})");
        Console.WriteLine("Select an option:");

        Console.WriteLine(FormatOptionDescription(Options[0]));
        var optionsDescriptions = new List<string>();
        for (var i = 1; i < Options.Count; i++)
        {
            optionsDescriptions.Add(FormatOptionDescription(Options[i]));
        }
        
        EnumHelper.ShowStringsInColumns(optionsDescriptions, _numberOfColumns, _columnWidth);

        string FormatOptionDescription(MenuOption option)
        {
            return $"{option.DisplayKey.PadRight(2)} - {option.Description}";
        }
    }

    protected bool RunMenu(string autoRunOptionKey = null)
    {
        var selectedOption = _shouldAutoRunOption 
            ? autoRunOptionKey ?? Console.ReadLine()
            : Console.ReadLine();
        _shouldAutoRunOption = false;
        var option = Options.SingleOrDefault(opt => opt.Key == selectedOption);
        return option?.Action() ?? true;
    }
    
    protected void NotImplementedCommand()
    {
        Console.WriteLine("Not Implemented");
    }
}
