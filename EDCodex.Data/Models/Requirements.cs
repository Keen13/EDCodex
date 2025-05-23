using EDCodex.Data.Enums;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace EDCodex.Data.Models
{
    public class Requirements
    {
        public List<StarClass> FoundAtStars { get; set; } = new List<StarClass>(); // TODO  into Requirements

        public List<TerrestrialPlanetType> FoundOnPlanets { get; set; } = new List<TerrestrialPlanetType>(); // TODO  into Requirements

        public List<GasGiantPlanetType> FoundOnGasGiants { get; set; } = new List<GasGiantPlanetType>(); // TODO  into Requirements

        public List<Volcanism> FoundWithVolcanism { get; set; } = new List<Volcanism>(); // TODO  into Requirements

        public List<TerrestrialPlanetType> PlanetsInSystem { get; set; } = new List<TerrestrialPlanetType>(); // TODO  into Requirements

        public List<GasGiantPlanetType> GasGiantsInSystem { get; set; } = new List<GasGiantPlanetType>(); // TODO  into Requirements

        public string TemperatureRange { get; set; }

        public string Location { get; set; }

        public bool AnyVolcanism { get; set; }


        public override string ToString()
        {
            var sb = new StringBuilder();

            if (FoundAtStars.Any())
            {
                sb.AppendLine($"FoundAtStars: {string.Join(", ", FoundAtStars)}");
            }
            
            if (FoundOnPlanets.Any())
            {
                sb.AppendLine($"FoundOnPlanets: {string.Join(", ", FoundOnPlanets)}");
            }
            
            if (FoundOnGasGiants.Any())
            {
                sb.AppendLine($"FoundOnGasGiants: {string.Join(", ", FoundOnGasGiants)}");
            }
            
            if (FoundWithVolcanism.Any())
            {
                sb.AppendLine($"FoundWithVolcanism: {string.Join(", ", FoundWithVolcanism)}");
            }
            
            if (PlanetsInSystem.Any())
            {
                sb.AppendLine($"PlanetsInSystem: {string.Join(", ", PlanetsInSystem)}");
            }
            
            if (GasGiantsInSystem.Any())
            {
                sb.AppendLine($"GasGiantsInSystem: {string.Join(", ", GasGiantsInSystem)}");
            }
            
            if (!string.IsNullOrEmpty(TemperatureRange))
            {
                sb.AppendLine($"TemperatureRange: {TemperatureRange}");
            }
            
            if (!string.IsNullOrEmpty(Location))
            {
                sb.AppendLine($"Location: {Location}");
            }
            
            if (AnyVolcanism)
            {
                sb.AppendLine("AnyVolcanism");
            }

            return sb.ToString();
        }
    }
}