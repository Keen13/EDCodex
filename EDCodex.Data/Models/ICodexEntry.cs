using EDCodex.Data.Enums;

namespace EDCodex.Data.Models;

public interface ICodexEntry
{
    public string Description { get; }

    public CodexEntryType Type { get; set; }
    
    public Dictionary<GalacticRegion, CodexEntryStatus> StatusByGalacticRegion { get; set; }
}