using EDCodex.Panel.Enums;
using System.Collections.Generic;

namespace EDCodex.Panel
{
    public static class CubeService
    {
        /// <summary>
        /// Gets a list of cube codes for the specified <see cref="MassIndex"/>.
        /// </summary>
        /// <param name="massIndex">The mass index to retrieve cube codes for.</param>
        /// <returns>
        /// A list of cube code strings corresponding to the given mass index.
        /// Returns an empty list if the mass index is not supported.
        /// </returns>
        public static List<string> GetForMassIndex(MassIndex massIndex)
        {
            switch (massIndex)
            {
                case MassIndex.G:
                    return new List<string>
                    {
                        "AA-A", "BA-A", "YE-A", "ZE-A", "EG-Y", "FG-Y", "CL-Y", "DL-Y"
                    };
                case MassIndex.H:
                    return new List<string>
                    {
                        "AA-A"
                    };
                default:
                    return new List<string>();
            }
        }
    }
}
