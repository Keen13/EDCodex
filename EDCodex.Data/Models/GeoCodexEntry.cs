using EDCodex.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDCodex.Data.Models
{
    public class GeoCodexEntry : CodexEntry<GeoFeature>
    {
        public GeoCodexEntry() : base(CodexEntryType.Geo)
        {
        }

        public GeoCodexEntry(GeoFeature feature) : base(CodexEntryType.Geo, feature)
        {
        }
    }
}
