using System;
using System.Linq;
using ED_Codex.Enums;

namespace ED_Codex
{
    public class MainMenu : IMenu
    {
        private static Codex Codex => DbAccessor.Codex;

        public bool ShowAndRun()
        {
            Console.Clear();
            Console.WriteLine($"Current region: {Codex.CurrentRegion.GetDescription()} ({(int)Codex.CurrentRegion})");
            Console.WriteLine("Select an option:");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Change current region");
            Console.WriteLine("2 - Show now found features");

            switch (Console.ReadLine())
            {
                case "0": // Exit
                    return false;

                case "1":
                    ChangeCurrentRegionCommand();
                    return true;

                case "2":
                    ShowNotFoudFeaturesCommand();
                    return true;

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

        private static void ChangeCurrentRegionCommand()
        {
            EnumHelper.ShowEnumOptions<GalacticRegion>(3, 35);
            Console.Write("Select region: ");
            var input = EnumHelper.GetEnumValueFromInput<GalacticRegion>();
            ChangeCurrentRegion(input);
        }

        private static void ChangeCurrentRegion(GalacticRegion newRegion)
        {
            Codex.CurrentRegion = newRegion;
            DbAccessor.SaveCodex();
        }

        private static void ShowNotFoudFeaturesCommand()
        {
            var subMenu = new ShowNotFoudFeaturesMenu();
            Runner.RunMenu(subMenu);
        }

        #endregion
    }
}
