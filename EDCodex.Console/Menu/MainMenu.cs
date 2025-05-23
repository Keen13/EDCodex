using System;
using System.Collections.Generic;
using System.Linq;
using EDCodex.Data.Models;
using EDCodex.Data.Enums;
using ED_Codex.Load;
using EDCodex.Data;

namespace ED_Codex.Menu;

public class MainMenu : MenuBase, IMenu
{
    protected override void InitializeOptions()
    {
        Options = new List<MenuOption>
        {
            new MenuOption("1 - Change current region", ChangeCurrentRegionCommand),
            new MenuOption("2 - Show now found features", ShowNotFoundFeaturesCommand),
            new MenuOption("9 - Update Codex (debug)", UpdateCodexCommand), 
        };
    }
    
    #region Commands 

    private static void ChangeCurrentRegionCommand()
    {
        var input = EnumHelper.SelectGalacticRegionFromInput();
        Codex.CurrentRegion = input;
        DbAccessor.SaveCodex();
    }

    private static void ShowNotFoundFeaturesCommand()
    {
        var subMenu = new ShowNotFoundFeaturesMenu();
        MenuRunner.RunMenu(subMenu, "1");
    }       
    
    private static void UpdateCodexCommand()
    {
        var subMenu = new UpdateCodexMenu();
        MenuRunner.RunMenu(subMenu);
    }       
    
    #endregion
}
