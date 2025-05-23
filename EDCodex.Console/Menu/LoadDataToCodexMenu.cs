using System;
using System.Collections.Generic;
using System.Linq;
using EDCodex.Data.Models;
using EDCodex.Data.Enums;
using ED_Codex.Load;
using EDCodex.Data;

namespace ED_Codex.Menu
{
    public class LoadDataToCodexMenu : MenuBase, IMenu
    {
        protected override void InitializeOptions()
        {
            Options = new List<MenuOption>
            {
                new MenuOption("91 - Clear Codex", DbAccessor.ClearCodex),
                new MenuOption("92 - Initialize Codex", CodexUploader.InitCodex),
                new MenuOption("0 - Load all data for the current region", LoadAllDataForCurrentRegion),
                new MenuOption("1 - Load Star data", LoadStarData),
                new MenuOption("2 - Load Gas Giant data", LoadGasGiantData),
                new MenuOption("3 - Load Terrestrial data", LoadTerrestrialData),
                new MenuOption("4 - Load Geo data", LoadGeoData),
                new MenuOption("5 - Load Bio data", LoadBioData),
                new MenuOption("6 - Load Space data", LoadSpaceData),
                new MenuOption("7 - Load Space Bio data", LoadSpaceBioData),
                new MenuOption("8 - Load Thargoid data", LoadThargoidData),
                new MenuOption("9 - Load Guardian data", LoadGuardianData),
            };
        }

        # region Commands
        private static void LoadGuardianData()
        {
            var galacticRegion = EnumHelper.SelectGalacticRegionFromInput();
            CodexUploader.LoadGuardianDataForRegion(galacticRegion);
        }

        private static void LoadThargoidData()
        {
            var galacticRegion = EnumHelper.SelectGalacticRegionFromInput();
            CodexUploader.LoadThargoidDataForRegion(galacticRegion);
        }

        private static void LoadSpaceBioData()
        {
            var galacticRegion = EnumHelper.SelectGalacticRegionFromInput();
            CodexUploader.LoadSpaceBioDataForRegion(galacticRegion);
        }

        private static void LoadSpaceData()
        {
            var galacticRegion = EnumHelper.SelectGalacticRegionFromInput();
            CodexUploader.LoadSpaceDataForRegion(galacticRegion);
        }

        private static void LoadBioData()
        {
            var galacticRegion = EnumHelper.SelectGalacticRegionFromInput();
            CodexUploader.LoadBioDataForRegion(galacticRegion);
        }

        private static void LoadGeoData()
        {
            var galacticRegion = EnumHelper.SelectGalacticRegionFromInput();
            CodexUploader.LoadGeoDataForRegion(galacticRegion);
        }

        private static void LoadTerrestrialData()
        {
            var galacticRegion = EnumHelper.SelectGalacticRegionFromInput();
            CodexUploader.LoadTerrestrialDataForRegion(galacticRegion);
        }

        private static void LoadGasGiantData()
        {
            var galacticRegion = EnumHelper.SelectGalacticRegionFromInput();
            CodexUploader.LoadGasGiantDataForRegion(galacticRegion);
        }

        private static void LoadStarData()
        {
            var galacticRegion = EnumHelper.SelectGalacticRegionFromInput();
            CodexUploader.LoadStarDataForRegion(galacticRegion);
        }

        private static void LoadAllDataForCurrentRegion()
        {
            CodexUploader.LoadStarDataForRegion(CurrentRegion);
            CodexUploader.LoadGasGiantDataForRegion(CurrentRegion);
            CodexUploader.LoadTerrestrialDataForRegion(CurrentRegion);
            CodexUploader.LoadGeoDataForRegion(CurrentRegion);
            CodexUploader.LoadBioDataForRegion(CurrentRegion);
            CodexUploader.LoadSpaceDataForRegion(CurrentRegion);
            CodexUploader.LoadSpaceBioDataForRegion(CurrentRegion);
            CodexUploader.LoadThargoidDataForRegion(CurrentRegion);
            CodexUploader.LoadGuardianDataForRegion(CurrentRegion);
            
            Console.WriteLine("Done");
            Console.ReadLine();
        }

        private static void SelectCodexEntryTypeCommand()
        {
            EnumHelper.ShowEnumOptions<CodexEntryType>(2, 35);
            Console.Write("Select Codex entry type: ");
            var input = EnumHelper.GetEnumValueFromInput<CodexEntryType>();
            ShowNotFoundEntries(input);
        }

        private static void ShowNotFoundEntries(CodexEntryType codexEntryType)
        {
            switch (codexEntryType)
            {
                case CodexEntryType.Star:
                    ShowNotFoundEntries(Codex.Stars);
                    break;
                case CodexEntryType.GasGiantPlanet:
                    ShowNotFoundEntries(Codex.GasGiantPlanets);
                    break;
                case CodexEntryType.TerrestrialPlanet:
                    ShowNotFoundEntries(Codex.TerrestrialPlanets);
                    break;
                case CodexEntryType.Geo:
                    ShowNotFoundEntries(Codex.GeoFeatures);
                    break;
                case CodexEntryType.Space:
                    ShowNotFoundEntries(Codex.SpaceFeatures);
                    break;
                case CodexEntryType.Bio:
                    ShowNotFoundEntries(Codex.BioFeatures);
                    break;
                case CodexEntryType.SpaceBio:
                    ShowNotFoundEntries(Codex.SpaceBioFeatures);
                    break;
                case CodexEntryType.Thargiod:
                    ShowNotFoundEntries(Codex.ThargoidObjects);
                    break;
                case CodexEntryType.Guardian:
                    ShowNotFoundEntries(Codex.GuardianObjects);
                    break;
            }

            Console.WriteLine("Press Enter to return to menu");
            Console.ReadLine();
        }

        private static List<string> GetNotFoundEntriesDescriptions<TCodexEntry>(List<TCodexEntry> fullList) 
            where  TCodexEntry : ICodexEntry
        {
            return fullList
                .Where(record => record.StatusByGalacticRegion[CurrentRegion] == CodexEntryStatus.Exists) 
                .Select(record => record.Description)
                .ToList();
        }

        private static void ShowNotFoundEntries<TCodexEntry>(List<TCodexEntry> fullList)
            where TCodexEntry : ICodexEntry
        {
            foreach (var description in GetNotFoundEntriesDescriptions(fullList))
            {
                Console.WriteLine($"\t{description}");
            }

            Console.WriteLine();
        }
        
        #endregion
    }
}
