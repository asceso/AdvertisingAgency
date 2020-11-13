using System;

namespace DatabaseLibrary
{
    public class OtherProperty : Attribute
    {
        public string Description { get; set; }

        public OtherProperty(string Description)
        {
            this.Description = Description;
        }
    }
}
