using EDCodex.Data.Enums;

namespace EDCodex.Data.Models;

public class CodexEntry<T> : ICodexEntry
    where T : Enum
{
    // Codex entries with additional requirements should be initialized as Undefined
    protected virtual CodexEntryStatus DefaultEntryStatus => CodexEntryStatus.Undefined;
    
    public CodexEntry(CodexEntryType type)
    {
        Type = type;
        ////InitializeStatusByGalacticRegion();
    }

    public CodexEntry(T feature)
    {
        Feature = feature;
        InitializeStatusByGalacticRegion();
    }

    public CodexEntry(CodexEntryType type, T feature)
    {
        Feature = feature;
        Type = type;
        InitializeStatusByGalacticRegion();
    }

    public string Description => Feature.GetDescription();

    public CodexEntryType Type { get; set; }

    public T Feature { get; set; }

    public Requirements Requirements { get; set; } 

    public Dictionary<GalacticRegion, CodexEntryStatus> StatusByGalacticRegion { get; set; } = new Dictionary<GalacticRegion, CodexEntryStatus>();

    public void MarkAsFound(GalacticRegion galacticRegion)
    {
        StatusByGalacticRegion[galacticRegion] = CodexEntryStatus.Found;
    }

    public void MarkAsNotExists(GalacticRegion galacticRegion)
    {
        StatusByGalacticRegion[galacticRegion] = CodexEntryStatus.NotExists;
    }

    public void MarkAsExists(GalacticRegion galacticRegion)
    {
        StatusByGalacticRegion[galacticRegion] = CodexEntryStatus.Exists;
    }

    public void InitializeStatusByGalacticRegion()
    {
        foreach (GalacticRegion galacticRegion in Enum.GetValues(typeof(GalacticRegion)))
        {
            StatusByGalacticRegion.Add(galacticRegion, DefaultEntryStatus);
        }
    }
}
