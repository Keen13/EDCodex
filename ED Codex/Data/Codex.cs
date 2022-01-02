using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ED_Codex.Enums;

namespace ED_Codex.Data
{
    public class Codex
    {
        public string Version { get; set; } = "1";

        public GalacticRegion CurrentRegion { get; set; } = GalacticRegion.InnerOrionSpur;

        public List<GeoFeatureCodexEntry> GeoFeatures { get; set; } = new List<GeoFeatureCodexEntry>();
    }
}
