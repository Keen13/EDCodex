using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ED_Codex.Data;
using ED_Codex.Enums;

namespace ED_Codex
{
    public class InitialLoadout
    {
        public static List<GeoFeatureCodexEntry> InitGeoFeatureCodexEntries()
        {
            var list = new List<GeoFeatureCodexEntry>();
            foreach (GeoFeature geoFeature in Enum.GetValues(typeof(GeoFeature)))
            {
                var geoFeatureCodexEntry = new GeoFeatureCodexEntry(geoFeature);
                list.Add(geoFeatureCodexEntry);
            }

            return list;
        }

    }
}
