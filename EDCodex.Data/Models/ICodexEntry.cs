using EDCodex.Data.Enums;
using System.Collections.Generic;

namespace EDCodex.Data.Models
{
    public interface ICodexEntry
    {
        public string Description { get; }

        public CodexEntryType Type { get; set; }
        
        public Dictionary<GalacticRegion, CodexEntryStatus> StatusByGalacticRegion { get; set; }
    }
}