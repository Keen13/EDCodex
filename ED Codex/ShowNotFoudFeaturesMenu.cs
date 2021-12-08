using System;
using System.Linq;
using ED_Codex.Enums;

namespace ED_Codex
{
    public class ShowNotFoudFeaturesMenu : IMenu
    {
        private static Codex Codex => DbAccessor.Codex;

        public bool ShowAndRun()
        {
            Console.Clear();
            Console.WriteLine($"Current region: {Codex.CurrentRegion.GetDescription()} ({(int)Codex.CurrentRegion})");
            Console.WriteLine("Select an option:");
            Console.WriteLine("0 - Return to previous menu");
            Console.WriteLine("1 - Select Codex entry type");

            switch (Console.ReadLine())
            {
                case "0": // Exit
                    return false;

                case "1":
                    SelectCodexEntryTypeCommand();
                    return true;

                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                default:
                    return true;
            }
        }

        #region Commands 

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
                    Console.WriteLine("Not implemented");
                    break;
                case CodexEntryType.GasGiantPlanet:
                    Console.WriteLine("Not implemented");
                    break;
                case CodexEntryType.TerrestrialPlanet:
                    Console.WriteLine("Not implemented");
                    break;
                case CodexEntryType.Geo:
                    var records = Codex.GeoFeatures
                        .Where(record => record.StatusByGalacticRegion[Codex.CurrentRegion] == CodexEntryStatus.Exists)
                        .Select(record => record.Descripion);
                    foreach (var record in records)
                    {
                        Console.WriteLine($"\t{record}");
                    }

                    Console.WriteLine();
                    break;
                case CodexEntryType.SpaceAnomaly:
                    Console.WriteLine("Not implemented");
                    break;
                case CodexEntryType.Bio:
                    Console.WriteLine("Not implemented");
                    break;
                case CodexEntryType.BioSpace:
                    Console.WriteLine("Not implemented");
                    break;
                case CodexEntryType.Thargiod:
                    Console.WriteLine("Not implemented");
                    break;
                case CodexEntryType.Guardian:
                    Console.WriteLine("Not implemented");
                    break;
            }

            Console.WriteLine("Press Enter to return to menu");
            Console.ReadLine();
        }

        #endregion
    }
}
