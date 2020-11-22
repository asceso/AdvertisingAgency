using System;

namespace DatabaseLibrary
{
    public class ItemType : Attribute
    {
        public string ItemTypeName { get; set; }
        public ItemType(string ItemTypeName) => this.ItemTypeName = ItemTypeName;
    }
}
