using EDCodex.Data.Enums;

namespace EDCodex.Data.Models;

public class Codex
{
    public string Version { get; set; } = "1";

    public bool SortByName { get; set; } = true;
    
    public GalacticRegion CurrentRegion { get; set; } = GalacticRegion.InnerOrionSpur;

    public List<StarCodexEntry> Stars { get; set; } = [];

    public List<GasGiantPlanetCodexEntry> GasGiantPlanets { get; set; } = [];

    public List<TerrestrialPlanetCodexEntry> TerrestrialPlanets { get; set; } = [];

    public List<GeoCodexEntry> GeoFeatures { get; set; } = [];

    public List<BioCodexEntry> BioFeatures { get; set; } = [];

    public List<SpaceCodexEntry> SpaceFeatures { get; set; } = [];

    public List<SpaceBioCodexEntry> SpaceBioFeatures { get; set; } = [];

    public List<ThargiodCodexEntry> ThargoidObjects { get; set; } = [];
    
    public List<GuardianCodexEntry> GuardianObjects { get; set; } = [];
    
    public List<CodexEntry<T>> GetCodexEntries<T>()
        where T : Enum
    {
        if (typeof(T) == typeof(StarClass))
        {
            return Stars.Cast<CodexEntry<T>>().ToList();
        }

        if (typeof(T) == typeof(GasGiantPlanetType))
        {
            return GasGiantPlanets.Cast<CodexEntry<T>>().ToList();
        }

        if (typeof(T) == typeof(TerrestrialPlanetType))
        {
            return TerrestrialPlanets.Cast<CodexEntry<T>>().ToList();
        }

        if (typeof(T) == typeof(GeoFeature))
        {
            return GeoFeatures.Cast<CodexEntry<T>>().ToList();
        }

        if (typeof(T) == typeof(BioFeature))
        {
            return BioFeatures.Cast<CodexEntry<T>>().ToList();
        }

        if (typeof(T) == typeof(SpaceFeature))
        {
            return SpaceFeatures.Cast<CodexEntry<T>>().ToList();
        }

        if (typeof(T) == typeof(SpaceBioFeature))
        {
            return SpaceBioFeatures.Cast<CodexEntry<T>>().ToList();
        }

        if (typeof(T) == typeof(ThargoidObject))
        {
            return ThargoidObjects.Cast<CodexEntry<T>>().ToList();
        }

        if (typeof(T) == typeof(GuardianObject))
        {
            return GuardianObjects.Cast<CodexEntry<T>>().ToList();
        }

        return null;
    }
}
