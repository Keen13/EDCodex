using System;
using System.Collections.Generic;
using System.Linq;
using ED_Codex.Data;
using ED_Codex.Enums;
using ED_Codex.Load;

namespace ED_Codex.Menu
{
    public class UpdateCodexEntryMenu<TCodexEntryType> : MenuBase, IMenu
        where TCodexEntryType : Enum
    {
        private readonly CodexEntry<TCodexEntryType> _entryToUpdate;
        
        public UpdateCodexEntryMenu(CodexEntry<TCodexEntryType> entryToUpdate)
        {
            _entryToUpdate = entryToUpdate;
        }
        
        protected override void InitializeOptions()
        {
            AddOption("1", "Mark as Found", MarkAsFoundCommand);
            AddOption("2", "Mark as NotExists", MarkAsNotExistsCommand);
            AddOption("3", "Show Requirements", ShowRequirementsCommand);
        }

        protected override void ShowMenu()
        {
            base.ShowMenu();
            Console.WriteLine($"Selected entry: {_entryToUpdate.Description}");
        }
        
        #region Commands 

        private bool MarkAsFoundCommand()
        {
            _entryToUpdate.MarkAsFound(CurrentRegion);
            DbAccessor.SaveCodex();
            Console.WriteLine($"{_entryToUpdate.Description} is Found now");
            Console.ReadLine();
            return false; // Automatically returns from this menu to the previous one
        }
        
        private bool MarkAsNotExistsCommand()
        {
            _entryToUpdate.MarkAsNotExists(CurrentRegion);
            DbAccessor.SaveCodex();
            Console.WriteLine($"{_entryToUpdate.Description} is NotExists now");
            Console.ReadLine();
            return false; // Automatically returns from this menu to the previous one
        }

        private bool ShowRequirementsCommand()
        {
            Console.WriteLine(_entryToUpdate.Requirements?.ToString());
            Console.ReadLine();
            return false; // Automatically returns from this menu to the previous one
        }
        
        #endregion
    }
}
