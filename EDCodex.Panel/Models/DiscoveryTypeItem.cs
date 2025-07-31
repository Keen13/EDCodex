using EDCodex.Data.Enums;

namespace EDCodex.Panel.Models
{
    public class DiscoveryTypeItem
    {
        public CodexEntryType Type { get; set; }

        public string Description { get; set; }

        public override string ToString() => Description;
    }
}
