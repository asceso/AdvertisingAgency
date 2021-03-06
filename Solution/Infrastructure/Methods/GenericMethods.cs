﻿using System.Collections.Generic;

namespace Infrastructure.Methods
{
    public static class GenericMethods<SomeType>
    {
        public static IEnumerable<SomeType> ConvertFromListToIEnumerable(List<SomeType> input)
        {
            foreach (SomeType item in input)
            {
                yield return item;
            }
        }
    }
}
