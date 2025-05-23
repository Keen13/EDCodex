using System;
using System.Collections.Generic;
using System.Linq;
using EDCodex.Data.Models;
using EDCodex.Data.Enums;
using ED_Codex.Load;
using EDCodex.Data;

namespace ED_Codex.Menu
{
    public class SelectCodexEntryMenu<TCodexEntryType> : MenuBase, IMenu
        where TCodexEntryType : Enum
    {
        private IEnumerable<CodexEntry<TCodexEntryType>> _notFoundEntries;
        
        public SelectCodexEntryMenu(int numberOfColumns, int columnWidth)
        {
            _numberOfColumns = numberOfColumns;
            _columnWidth = columnWidth;

            InitializeOptionsCustom();
        }

        protected override void InitializeOptions()
        {
            // Do nothing. _notFoundEntries must be initialized first;
        }
        
        private void InitializeOptionsCustom()
        {
            CheckAndFillEntriesForCurrentRegion();
            
            _notFoundEntries = Codex.GetCodexEntries<TCodexEntryType>()
                .Where(entry => entry.StatusByGalacticRegion[CurrentRegion] == CodexEntryStatus.Exists);

            var index = 0;
            foreach (var entryToUpdate in _notFoundEntries.OrderBy(entry => entry.Feature))
            {
                var key = (index++).ToString();
                var description = entryToUpdate.Feature.GetDescription();
                
                void Action()
                {
                    UpdateCodexEntryCommand(entryToUpdate);
                }

                AddOption(key, description, Action);
            }
        }

        private void CheckAndFillEntriesForCurrentRegion()
        {
            var entriesWereUprated = false;
            var entries = Codex.GetCodexEntries<TCodexEntryType>();
            foreach (var entry in entries)
            {
                if (!entry.StatusByGalacticRegion.ContainsKey(CurrentRegion))
                {
                    entriesWereUprated = true;
                    entry.StatusByGalacticRegion.Add(CurrentRegion, CodexEntryStatus.Exists);
                }
            }

            if (entriesWereUprated)
            {
                DbAccessor.SaveCodex();
            }
        }

        public override bool ShowAndRun(string autoRunOptionKey = null)
        {
            Options.Clear();
            AddCommonOptions();
            InitializeOptionsCustom();
            return base.ShowAndRun(autoRunOptionKey);
        }
        
        #region Commands 

        private static void UpdateCodexEntryCommand(CodexEntry<TCodexEntryType> entryToUpdate)
        {
            var updateCodexEntryMenu = new UpdateCodexEntryMenu<TCodexEntryType>(entryToUpdate);
            MenuRunner.RunMenu(updateCodexEntryMenu);
        }
        
        #endregion
    }
}
