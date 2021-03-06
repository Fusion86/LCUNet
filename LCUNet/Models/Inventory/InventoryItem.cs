﻿namespace LCUNet.Models.Inventory
{
    public class InventoryItem
    {
        public InventoryType InventoryType { get; set; }
        public long ItemId { get; set; }
        public ItemOwnershipType OwnershipType { get; set; }
        public string PurchaseDate { get; set; } // Undocumented
        public string Uuid { get; set; } // Undocumented
    }

    public enum ItemOwnershipType
    {
        OWNED,
        RENTED,
        F2P
    }

    // Mostly based on guesswork
    public enum InventoryType
    {
        EMOTE,
        CHAMPION
    }
}
