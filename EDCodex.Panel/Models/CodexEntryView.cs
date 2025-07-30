using EDCodex.Data;
using EDCodex.Data.Enums;
using EDCodex.Data.Models;
using EDCodex.Panel.Extentions;

namespace EDCodex.Panel.Models
{
    public class CodexEntryView
    {
        private ICodexEntry _codexEntry;
        private readonly Codex _codex;

        public CodexEntryView(ICodexEntry codexEntry, Codex codex)
        {
            _codexEntry = codexEntry ?? throw new System.ArgumentNullException(nameof(codexEntry));
            _codex = codex ?? throw new System.ArgumentNullException(nameof(codex));
        }

        public string Description
        {
            get => _codexEntry.Description;
        }

        public CodexEntryStatus Status
        {
            get => _codexEntry.GetStatusForRegion(_codex.CurrentRegion);
            set
            {
                _codexEntry.StatusByGalacticRegion[_codex.CurrentRegion] = value;
                DbAccessor.SaveCodex(); // TODO: Ask is it SRP violation?..
            }
        }
    }
}
