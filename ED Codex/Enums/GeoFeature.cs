using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ED_Codex.Enums
{
    public enum GeoFeature
    {
        [Description("Ammonia Ice Fumarole")]
        AmmoniaIceFumarole = 300,

        [Description("Ammonia Ice Geyser")]
        AmmoniaIceGeyser,

        [Description("Iron Magma Lava Spout")]
        IronMagmaLavaSpout,

        [Description("Methane Ice Fumarole")]
        MethaneIceFumarole,

        [Description("Methane Ice Geyser")]
        MethaneIceGeyser,

        [Description("Nitrogen Ice Fumarole")]
        NitrogenIceFumarole,

        [Description("Nitrogen Ice Geyser")]
        NitrogenIceGeyser,

        [Description("Carbon Dioxide Fumarole")]
        CarbonDioxideFumarole,

        [Description("Carbon Dioxide Gas Vent")]
        CarbonDioxideGasVent,

        [Description("Carbon Dioxide Geyser")]
        CarbonDioxideGeyser,

        [Description("Carbon Dioxide Ice Fumarole")]
        CarbonDioxideIceFumarole,

        [Description("Carbon Dioxide Ice Geyser")]
        CarbonDioxideIceGeyser,

        [Description("Silicate Magma Lava Spout")]
        SilicateMagmaLavaSpout,

        [Description("Silicate Vapour Fumarole")]
        SilicateVapourFumarole,

        [Description("Silicate Vapour Gas Vent")]
        SilicateVapourGasVent,

        [Description("Silicate Vapour Ice Fumarole")]
        SilicateVapourIceFumarole,

        [Description("Sulfur Dioxide Gas Vent")]
        SulfurDioxideGasVent,

        [Description("Sulfur Dioxide Fumarole")]
        SulfurDioxideFumarole,

        [Description("Sulfur Dioxide Ice Fumarole")]
        SulfurDioxideIceFumarole,

        [Description("Water Fumarole")]
        WaterFumarole,

        [Description("Water Geyser")]
        WaterGeyser,

        [Description("Water Gas Vent")]
        WaterGasVent,

        [Description("Water Ice Fumarole")]
        WaterIceFumarole,

        [Description("Water Ice Geyser")]
        WaterIceGeyser,
    }
}
