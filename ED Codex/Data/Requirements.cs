using ED_Codex.Enums;
using System.Collections.Generic;

namespace ED_Codex.Data
{
    public class Requirements
    {
        public List<StarClass> FoundAtStars { get; set; } = new List<StarClass>(); // TODO  into Requirements

        public List<PlanetType> FoundOnPlanets { get; set; } = new List<PlanetType>(); // TODO  into Requirements

        public List<Volcanism> FoundWithVolcanism { get; set; } = new List<Volcanism>(); // TODO  into Requirements

        public List<PlanetType> PlanetsInSystem { get; set; } = new List<PlanetType>(); // TODO  into Requirements

        public string TemperatureRange { get; set; }

        public string Location { get; set; }

        public string Volcanism { get; set; } // Yes/No

        public string xxxxx { get; set; }

        public string xxxxx { get; set; }

        public string xxxxx { get; set; }
    }
}