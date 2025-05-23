using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDCodex.Data.Enums
{
    public enum GeoFeature
    {
        // Fumarole
        [Description("Sulfur Dioxide Fumarole")]
        SulfurDioxideFumarole,

        [Description("Silicate Vapour Fumarole")]
        SilicateVapourFumarole,

        [Description("Water Fumarole")]
        WaterFumarole,

        [Description("Carbon Dioxide Fumarole")]
        CarbonDioxideFumarole,

        // Ice Fumarole
        [Description("Sulfur Dioxide Ice Fumarole")]
        SulfurDioxideIceFumarole,

        [Description("Water Ice Fumarole")]
        WaterIceFumarole,

        [Description("Carbon Dioxide Ice Fumarole")]
        CarbonDioxideIceFumarole,

        [Description("Ammonia Ice Fumarole")]
        AmmoniaIceFumarole,

        [Description("Methane Ice Fumarole")]
        MethaneIceFumarole,
        
        [Description("Nitrogen Ice Fumarole")]
        NitrogenIceFumarole,
        
        [Description("Silicate Vapour Ice Fumarole")]
        SilicateVapourIceFumarole,

        // Geyser
        [Description("Water Geyser")]
        WaterGeyser,

        [Description("Carbon Dioxide Geyser")]
        CarbonDioxideGeyser,

        // Ice Geyser
        [Description("Water Ice Geyser")]
        WaterIceGeyser,

        [Description("Carbon Dioxide Ice Geyser")]
        CarbonDioxideIceGeyser,

        [Description("Ammonia Ice Geyser")]
        AmmoniaIceGeyser,

        [Description("Methane Ice Geyser")]
        MethaneIceGeyser,

        [Description("Nitrogen Ice Geyser")]
        NitrogenIceGeyser,

        // Lava Spout
        [Description("Silicate Magma Lava Spout")]
        SilicateMagmaLavaSpout,

        [Description("Iron Magma Lava Spout")]
        IronMagmaLavaSpout,

        // Gas Vent
        [Description("Sulfur Dioxide Gas Vent")]
        SulfurDioxideGasVent,

        [Description("Water Gas Vent")]
        WaterGasVent,

        [Description("Carbon Dioxide Gas Vent")]
        CarbonDioxideGasVent,

        [Description("Silicate Vapour Gas Vent")]
        SilicateVapourGasVent,
    }
}
