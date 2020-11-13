using System;

namespace DatabaseLibrary
{
    public class DataProperty : Attribute, IComparable
    {
        public int InsertIndex { get; set; }
        public int UpdateIndex { get; set; }

        public DataProperty(int insert, int update)
        {
            InsertIndex = insert;
            UpdateIndex = update;
        }

        public int CompareTo(object obj)
        {
            if (nameof(obj).Equals(nameof(InsertIndex)))
                return InsertIndex.CompareTo(obj);
            if (nameof(obj).Equals(nameof(UpdateIndex)))
                return UpdateIndex.CompareTo(obj);
            else return 0;
        }
    }
}
