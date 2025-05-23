using System;
using System.Collections.Generic;
using EDCodex.Data.Models;
using EDCodex.Data.Enums;

namespace ED_Codex.Load;

public class SpaceFeaturesData
{
    public static List<SpaceCodexEntry> GetData(GalacticRegion galacticRegion)
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
    public static List<SpaceCodexEntry> Data18 =>
        new List<SpaceCodexEntry>
        {
            new SpaceCodexEntry(SpaceFeature.CaeruleumLagrangeCloud)
            {
                Requirements = new Requirements
                {
                    Location = Location.NebulaLagrangePoints
                }
            },
            new SpaceCodexEntry(SpaceFeature.VirideLagrangeCloud)
            {
                Requirements = new Requirements
                {
                    Location = Location.NebulaLagrangePoints
                }
            },
            new SpaceCodexEntry(SpaceFeature.LuteolumLagrangeCloud)
            {
                Requirements = new Requirements
                {
                    Location = Location.NebulaLagrangePoints
                }
            },
            new SpaceCodexEntry(SpaceFeature.RoseumLagrangeCloud)
            {
                Requirements = new Requirements
                {
                    Location = Location.NebulaLagrangePoints
                }
            },
            new SpaceCodexEntry(SpaceFeature.CroceumLagrangeCloud)
            {
                Requirements = new Requirements
                {
                    Location = Location.NebulaLagrangePoints
                }
            },
            new SpaceCodexEntry(SpaceFeature.ProtoLagrangeCloud)
            {
                Requirements = new Requirements
                {
                    Location = Location.LagrangePoints
                }
            },
            new SpaceCodexEntry(SpaceFeature.P01)
            {
                Requirements = new Requirements
                {
                    Location = Location.Rings,
                    FoundOnGasGiants =
                    {
                        GasGiantPlanetType.GWL,
                        GasGiantPlanetType.WG
                    }
                }
            },
            new SpaceCodexEntry(SpaceFeature.Q02)
            {
                Requirements = new Requirements
                {
                    Location = Location.LagrangePointsRingsBelts,
                    FoundOnPlanets = { TerrestrialPlanetType.A }
                }
            },
            new SpaceCodexEntry(SpaceFeature.Q08)
            {
                Requirements = new Requirements
                {
                    Location = Location.LagrangePointsRingsBelts,
                    FoundOnPlanets = { TerrestrialPlanetType.A }
                }
            },
            new SpaceCodexEntry(SpaceFeature.Q09)
            {
                Requirements = new Requirements
                {
                    Location = Location.LagrangePoints,
                    PlanetsInSystem = { TerrestrialPlanetType.I },
                    FoundAtStars =
                    {
                        StarClass.O,
                        StarClass.B,
                        StarClass.A,
                        StarClass.F,
                        StarClass.G,
                        StarClass.K,
                        StarClass.M,
                        StarClass.TTS,
                        StarClass.AeBe
                    }
                }
            },
        };
}