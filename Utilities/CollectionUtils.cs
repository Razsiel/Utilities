using System;
using System.Collections.Generic;
using System.Linq;

namespace Utilities
{
    static public class CollectionUtils
    {
        //Returns a new dictionary where every ICollection (Array, List, Dictionary) value is grouped their value and then counted
        //Original values are the dict keys, value per key is duplicate count
        static public Dictionary<T, int> GetDuplicateData<T>(ICollection<T> coll)
        {
            return coll.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        }
        
        //Returns a formatted string for any list collection. (string eg. "elem1, elem2, elem3...")
        static public string ToFormattedString<T>(this List<T> coll)
        {
            //Initialize with NAMESPACE.TYPE(
            string s = typeof(T).FullName + "(";

            //Iterate through every element in collection
            int index = 0;
            foreach (T element in coll)
            {
                s += element.ToString();
                index++;
                //Check whether we're not at the last element to add ", " for the next element
                if (index != coll.Capacity)
                    s += ", ";
                
            }
            //Finishes collection string
            s += ")";
            return s;
        }
    }
}
