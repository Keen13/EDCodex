using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDCodex.Data.Enums;

namespace EDCodex.Data.Models
{
    public class Codex
    {
        public string Version { get; set; } = "1";

        public bool SortByName { get; set; } = true;
        
        public GalacticRegion CurrentRegion { get; set; } = GalacticRegion.InnerOrionSpur;

        public List<StarCodexEntry> Stars { get; set; } = new List<StarCodexEntry>();

        public List<GasGiantPlanetCodexEntry> GasGiantPlanets { get; set; } = new List<GasGiantPlanetCodexEntry>();

        public List<TerrestrialPlanetCodexEntry> TerrestrialPlanets { get; set; } = new List<TerrestrialPlanetCodexEntry>();

        public List<GeoCodexEntry> GeoFeatures { get; set; } = new List<GeoCodexEntry>();

        public List<BioCodexEntry> BioFeatures { get; set; } = new List<BioCodexEntry>();

        public List<SpaceCodexEntry> SpaceFeatures { get; set; } = new List<SpaceCodexEntry>();

        public List<SpaceBioCodexEntry> SpaceBioFeatures { get; set; } = new List<SpaceBioCodexEntry>();

        public List<ThargiodCodexEntry> ThargoidObjects { get; set; } = new List<ThargiodCodexEntry>();
        
        public List<GuardianCodexEntry> GuardianObjects { get; set; } = new List<GuardianCodexEntry>();
        
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
}
