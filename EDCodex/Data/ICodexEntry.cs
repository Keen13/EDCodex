using System.Collections.Generic;
using ED_Codex.Enums;

namespace ED_Codex.Data
{
    public interface ICodexEntry
    {
        public string Description { get; }

        public CodexEntryType Type { get; set; }
        
        public Dictionary<GalacticRegion, CodexEntryStatus> StatusByGalacticRegion { get; set; }
    }
}