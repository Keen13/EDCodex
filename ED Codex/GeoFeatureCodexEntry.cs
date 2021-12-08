using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ED_Codex.Enums;

namespace ED_Codex
{
    public class GeoFeatureCodexEntry : CodexEntry<GeoFeature>
    {
        public GeoFeatureCodexEntry(GeoFeature feature) : base (CodexEntryType.Geo, feature)
        {
            Feature = feature;
        }
    }
}
