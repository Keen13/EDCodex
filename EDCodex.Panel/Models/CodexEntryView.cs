using EDCodex.Data.Enums;
using EDCodex.Data.Models;
using EDCodex.Panel.Extentions;

namespace EDCodex.Panel.Models
{
    /// <summary>
    /// View model wrapper for a codex entry used for data binding in the UI layer.
    /// </summary>
    public class CodexEntryView
    {
        private ICodexEntry _codexEntry;
        private readonly Codex _codex;

        /// <summary>
        /// Creates a view model wrapper for a codex entry used in UI data binding.
        /// Provides region-specific status access and editing.
        /// </summary>
        /// <param name="codexEntry">The codex entry to wrap.</param>
        /// <param name="codex">The codex context.</param>
        public CodexEntryView(ICodexEntry codexEntry, Codex codex)
        {
            _codexEntry = codexEntry ?? throw new System.ArgumentNullException(nameof(codexEntry));
            _codex = codex ?? throw new System.ArgumentNullException(nameof(codex));
        }

        /// <summary>
        /// Gets the description of the codex entry.
        /// </summary>
        public string Description
        {
            get => _codexEntry.Description;
        }

        /// <summary>
        /// Gets or sets the codex entry's status for the current galactic region.
        /// </summary>
        public CodexEntryStatus Status
        {
            get => _codexEntry.GetStatusForRegion(_codex.CurrentRegion);
            set
            {
                _codexEntry.StatusByGalacticRegion[_codex.CurrentRegion] = value;
            }
        }
    }
}
