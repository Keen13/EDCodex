using System;
using System.Collections.Generic;
using System.Linq;
using ED_Codex.Data;
using ED_Codex.Enums;
using ED_Codex.Load;

namespace ED_Codex.Menu
{
    public class UpdateCodexMenu : MenuBase, IMenu
    {
        protected override void InitializeOptions()
        {
            Options = new List<MenuOption>
            {
                new MenuOption("0 - Load full data from code", LoadFullDataFromCode),
                new MenuOption("1 - Update Codex record", UpdateCodexRecord),
            };
        }

        # region Commands
        
        private static void LoadFullDataFromCode()
        {
            var subMenu = new LoadDataToCodexMenu();
            subMenu.ShowAndRun();
        }
        
        private static void UpdateCodexRecord()
        {
            EnumHelper.ShowEnumOptions<CodexEntryType>(3, 25);
            var recordType = EnumHelper.GetEnumValueFromInput<CodexEntryType>("Select record type");

            switch (recordType)
            {
                case CodexEntryType.Star:
                    new LoadDataToCodexMenu().ShowAndRun();
                    break;
            }
        }
        
        #endregion
    }
}
