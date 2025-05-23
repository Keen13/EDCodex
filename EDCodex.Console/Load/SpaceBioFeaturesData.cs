using System;
using System.Collections.Generic;
using EDCodex.Data.Models;
using EDCodex.Data.Enums;

namespace ED_Codex.Load
{
    public class SpaceBioFeaturesData
    {
        public static List<SpaceBioCodexEntry> GetData(GalacticRegion galacticRegion)
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
        public static List<SpaceBioCodexEntry> Data18 =>
            new List<SpaceBioCodexEntry>
            {
                new SpaceBioCodexEntry(SpaceBioFeature.SolidMineralSpheres)
                {
                    Requirements = new Requirements
                    {
                        Location = Location.Nebula,
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.LatticeMineralSpheres)
                {
                    Requirements = new Requirements
                    {
                        Location = Location.Nebula,
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.PrasinumMetallicCrystals)
                {
                    Requirements = new Requirements
                    {
                        PlanetsInSystem =
                        {
                            TerrestrialPlanetType.HMC,
                            TerrestrialPlanetType.MR
                        },
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.PurpureumMetallicCrystals)
                {
                    Requirements = new Requirements
                    {
                        PlanetsInSystem =
                        {
                            TerrestrialPlanetType.HMC,
                            TerrestrialPlanetType.MR
                        },
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.RubeumMetallicCrystals)
                {
                    Requirements = new Requirements
                    {
                        PlanetsInSystem =
                        {
                            TerrestrialPlanetType.HMC,
                            TerrestrialPlanetType.MR
                        },
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.FlavumMetallicCrystals)
                {
                    Requirements = new Requirements
                    {
                        PlanetsInSystem =
                        {
                            TerrestrialPlanetType.HMC,
                            TerrestrialPlanetType.MR
                        },
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.AlbidumCollaredPod)
                {
                    Requirements = new Requirements
                    {
                        Location = Location.NebulaRingsBeltsLagrangePoints,
                        FoundAtStars = { StarClass.F },
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.LividumCollaredPod)
                {
                    Requirements = new Requirements
                    {
                        Location = Location.NebulaRingsBeltsLagrangePoints,
                        FoundAtStars = { StarClass.F },
                        FoundOnGasGiants = { GasGiantPlanetType.G_III }
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.BlatteumCollaredPod)
                {
                    Requirements = new Requirements
                    {
                        Location = Location.NebulaRingsBeltsLagrangePoints,
                        FoundAtStars = { StarClass.A, StarClass.F, StarClass.G },
                        FoundOnPlanets = { TerrestrialPlanetType.A }
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.RubicundumCollaredPod)
                {
                    Requirements = new Requirements
                    {
                        Location = Location.NebulaRingsBeltsLagrangePoints,
                        FoundAtStars = { StarClass.F },
                        FoundOnPlanets = { TerrestrialPlanetType.HMC }
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.AlbulumGourdMollusc)
                {
                    Requirements = new Requirements
                    {
                        Location = Location.LagrangePointsRingsBelts,
                        FoundAtStars = { StarClass.T },
                        PlanetsInSystem =
                        {
                            TerrestrialPlanetType.E,
                            TerrestrialPlanetType.W
                        },
                        GasGiantsInSystem =
                        {
                            GasGiantPlanetType.GWL,
                            GasGiantPlanetType.G_II,
                            GasGiantPlanetType.WG
                        }
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.CaeruleumGourdMollusc)
                {
                    Requirements = new Requirements
                    {
                        Location = Location.Rings,
                        FoundAtStars = { StarClass.B },
                        FoundOnGasGiants = { GasGiantPlanetType.G_IV }
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.VirideGourdMollusc)
                {
                    Requirements = new Requirements
                    {
                        Location = Location.Rings,
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.PhoeniceumGourdMollusc)
                {
                    Requirements = new Requirements
                    {
                        Location = Location.LagrangePointsRingsBelts,
                        FoundOnPlanets = {TerrestrialPlanetType.E }
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.PurpureumGourdMollusc)
                {
                    Requirements = new Requirements
                    {
                        Location = Location.LagrangePoints,
                        FoundAtStars = { StarClass.A }
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.RufumGourdMollusc)
                {
                    Requirements = new Requirements
                    {
                        Location = Location.LagrangePointsIceRingsBelts,
                        FoundAtStars = { StarClass.H }
                    }
                },
                new SpaceBioCodexEntry(SpaceBioFeature.CroceumGourdMollusc)
                {
                    Requirements = new Requirements
                    {
                        Location = Location.LagrangePointsRingsBelts,
                    }
                },
         };
    }
}