using System.Collections.Generic;

namespace LCUNet.Models.Perks
{
    public class PerkPage : JsonSerializable
    {
        public List<int> AutoModifiedSelections { get; set; }
        public bool Current { get; set; }
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeletable { get; set; }
        public bool IsEditable { get; set; }
        public bool IsValid { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public int PrimaryStyleId { get; set; }
        public List<int> SelectedPerkIds { get; set; }
        public int SubStyleId { get; set; }
    }
}
