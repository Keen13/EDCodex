namespace ED_Codex.Load
{
    public class Location
    {
        public static readonly string Nebula = "Any Nebula";
        
        public static readonly string LagrangePoints = "Lagrange Points";

        public static readonly string NebulaLagrangePoints = $"{Nebula} + {LagrangePoints}";

        public static readonly string Rings = "Rings";

        public static readonly string Belts = "Belts";
        
        public static readonly string IceRings = "Ice Rings";

        public static readonly string IceBelts = "Ice Belts";

        public static readonly string LagrangePointsRingsBelts = $"{LagrangePoints}; {Rings}; {Belts};";

        public static readonly string LagrangePointsIceRingsBelts = $"{LagrangePoints}; {IceRings}; {IceBelts};";

        public static readonly string NebulaRingsBeltsLagrangePoints = $"{Nebula} + {LagrangePointsRingsBelts}";
    }
}