using System;
using System.Collections.Generic;
using System.Linq;
using ED_Codex.Data;
using ED_Codex.Enums;

namespace ED_Codex.Menu
{
    public class ShowNotFoundFeaturesMenu : MenuBase, IMenu
    {
        protected override void InitializeOptions()
        {
            Options = new List<MenuOption>
            {
                new MenuOption("1 - By Codex entry type", SelectCodexEntryTypeCommand),
                new MenuOption("2 - By (not implemented)", NotImplementedCommand),
            };
        }
        
        #region Commands 

        private static void SelectCodexEntryTypeCommand()
        {
            EnumHelper.ShowEnumOptions<CodexEntryType>(3, 25);
            var input = EnumHelper.GetEnumValueFromInput<CodexEntryType>("Select Codex entry type");
            ShowNotFoundEntries(input);
        }

        private static void ShowNotFoundEntries(CodexEntryType codexEntryType)
        {
            switch (codexEntryType)
            {
                case CodexEntryType.Star:
                    ShowNotFoundEntriesAsMenu<StarClass>(5, 20);
                    break;
                case CodexEntryType.GasGiantPlanet:
                    ShowNotFoundEntriesAsMenu<GasGiantPlanetType>(5, 20);
                    break;
                case CodexEntryType.TerrestrialPlanet:
                    ShowNotFoundEntriesAsMenu<TerrestrialPlanetType>(5, 20);
                    break;
                case CodexEntryType.Geo:
                    ShowNotFoundEntriesAsMenu<GeoFeature>(2, 50);
                    break;
                case CodexEntryType.Space:
                    ShowNotFoundEntriesAsMenu<SpaceFeature>(2, 50);
                    break;
                case CodexEntryType.Bio:
                    ShowNotFoundEntriesAsMenu<BioFeature>(2, 50);
                    break;
                case CodexEntryType.SpaceBio:
                    ShowNotFoundEntriesAsMenu<SpaceBioFeature>(2, 50);
                    break;
                case CodexEntryType.Thargiod:
                    ShowNotFoundEntriesAsMenu<ThargoidObject>(2, 50);
                    break;
                case CodexEntryType.Guardian:
                    ShowNotFoundEntriesAsMenu<GuardianObject>(2, 50);
                    break;
            }

            DbAccessor.SaveCodex();
        }
        
        private static void ShowNotFoundEntriesAsMenu<TCodexEntryType>(int numberOfColumns, int columnWidth) 
            where TCodexEntryType: Enum
        {
            var selectCodexEntryMenu = new SelectCodexEntryMenu<TCodexEntryType>(numberOfColumns, columnWidth);
            MenuRunner.RunMenu(selectCodexEntryMenu);
        }
        
        #endregion
    }
}
