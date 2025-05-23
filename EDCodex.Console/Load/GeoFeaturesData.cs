using System;
using System.Collections.Generic;
using EDCodex.Data.Models;
using EDCodex.Data.Enums;

namespace ED_Codex.Load
{
    public class GeoFeaturesData
    {
        public static List<GeoCodexEntry> GetData(GalacticRegion galacticRegion)
        {
            return 
                (int) galacticRegion switch
                {
                    // 1 => Data01,
                    // 2 => Data02,
                    // 3 => Data03,
                    // 4 => Data04,
                    // 5 => Data05,
                    // 6 => Data06,
                    // 7 => Data07,
                    // 8 => Data08,
                    // 9 => Data09,
                    // 10 => Data10,
                    // 11 => Data11,
                    // 12 => Data12,
                    // 13 => Data13,
                    // 14 => Data14,
                    // 15 => Data15,
                    // 16 => Data16,
                    // 17 => Data17,
                    18 => Data18,
                    // 19 => Data19,
                    // 20 => Data20,
                    // 21 => Data21,
                    // 22 => Data22,
                    // 23 => Data23,
                    // 24 => Data24,
                    // 25 => Data25,
                    // 26 => Data26,
                    // 27 => Data27,
                    // 28 => Data28,
                    // 29 => Data29,
                    // 30 => Data30,
                    // 31 => Data31,
                    // 32 => Data32,
                    // 33 => Data33,
                    // 34 => Data34,
                    // 35 => Data35,
                    // 36 => Data36,
                    // 37 => Data37,
                    // 38 => Data38,
                    // 39 => Data39,
                    // 40 => Data40,
                    // 41 => Data14,
                    // 42 => Data42,
                    _ => throw new ArgumentException()
                };
        }

        // List only existing Terrestrials types for a region. Other will be marked as NotExists by default
        // Use Data18 as template
        public static List<GeoCodexEntry> Data18 =>
            new List<GeoCodexEntry>
            {
                new GeoCodexEntry(GeoFeature.SulfurDioxideFumarole)
                {
                    Requirements = new Requirements
                    {
                        // SO2 magma
                    }
                },
                new GeoCodexEntry(GeoFeature.WaterFumarole)
                {
                    Requirements = new Requirements
                    {
                        // H2O geysers
                    }
                },
                new GeoCodexEntry(GeoFeature.SilicateVapourFumarole)
                {
                    Requirements = new Requirements
                    {
                        // SiO2 vap gey
                    }
                },
                new GeoCodexEntry(GeoFeature.SulfurDioxideIceFumarole)
                {
                    Requirements = new Requirements
                    {
                        // SO2 mgm
                    }
                },
                new GeoCodexEntry(GeoFeature.WaterIceFumarole)
                {
                    Requirements = new Requirements
                    {
                        // H2O gey
                    }
                },
                new GeoCodexEntry(GeoFeature.CarbonDioxideIceFumarole)
                {
                    Requirements = new Requirements
                    {
                        // CO2 gey
                    }
                },
                new GeoCodexEntry(GeoFeature.AmmoniaIceFumarole)
                {
                    Requirements = new Requirements
                    {
                        // NH3 gey
                    }
                },
                new GeoCodexEntry(GeoFeature.MethaneIceFumarole)
                {
                    Requirements = new Requirements
                    {
                        // CH4 gey
                    }
                },
                new GeoCodexEntry(GeoFeature.NitrogenIceFumarole)
                {
                    Requirements = new Requirements
                    {
                        // N2 gey
                    }
                },
                new GeoCodexEntry(GeoFeature.SilicateVapourIceFumarole)
                {
                    Requirements = new Requirements
                    {
                        // SiO2 vap gey
                    }
                },
                new GeoCodexEntry(GeoFeature.WaterGeyser)
                {
                    Requirements = new Requirements
                    {
                        // H2O gey
                    }
                },
                new GeoCodexEntry(GeoFeature.WaterIceGeyser)
                {
                    Requirements = new Requirements
                    {
                        // H2O gey
                    }
                },
                new GeoCodexEntry(GeoFeature.CarbonDioxideIceGeyser)
                {
                    Requirements = new Requirements
                    {
                        // CO2 gey
                    }
                },
                new GeoCodexEntry(GeoFeature.AmmoniaIceGeyser)
                {
                    Requirements = new Requirements
                    {
                        // NH3 gey
                    }
                },
                new GeoCodexEntry(GeoFeature.MethaneIceGeyser)
                {
                    Requirements = new Requirements
                    {
                        // CH4 gey
                    }
                },
                new GeoCodexEntry(GeoFeature.NitrogenIceGeyser)
                {
                    Requirements = new Requirements
                    {
                        // He gey ??? N2 gey    
                    }
                },
                new GeoCodexEntry(GeoFeature.SilicateMagmaLavaSpout)
                {
                    Requirements = new Requirements
                    {
                        // SiO2 mgm
                    }
                },
                new GeoCodexEntry(GeoFeature.IronMagmaLavaSpout)
                {
                    Requirements = new Requirements
                    {
                        // Fe mgm
                    }
                },
                new GeoCodexEntry(GeoFeature.SulfurDioxideGasVent)
                {
                    Requirements = new Requirements
                    {
                        // SO2 mgm
                    }
                },
                new GeoCodexEntry(GeoFeature.WaterGasVent)
                {
                    Requirements = new Requirements
                    {
                        // H2O gey
                    }
                },
                new GeoCodexEntry(GeoFeature.CarbonDioxideGasVent)
                {
                    Requirements = new Requirements
                    {
                        // CO2 gey
                    }
                },
                new GeoCodexEntry(GeoFeature.SilicateVapourGasVent)
                {
                    Requirements = new Requirements
                    {
                        // SiO2 vap gey
                    }
                },
           };
    }
}