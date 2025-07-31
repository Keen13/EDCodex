using EDCodex.Data.Enums;
using System;

namespace EDCodex.Panel.Models
{
    /// <summary>
    /// Represents an item with a strongly-typed enum value and a human-readable description,
    /// used for UI binding in ComboBoxes or similar controls.
    /// </summary>
    /// <typeparam name="TEnum">The enum type this item wraps.</typeparam>
    public class EnumDisplayItem<TEnum> where TEnum : Enum
    {
        /// <summary>
        /// The underlying enum value.
        /// </summary>
        public TEnum Type { get; set; }

        /// <summary>
        /// The string description of the enum value, used for display.
        /// </summary>
        public string Description => Type.GetDescription();

        public override string ToString() => Description;
    }
}
