using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utilities
{
    static public class CollectionUtils
    {
        //Returns a new dictionary where every array value is grouped their value and then counted
        //Original values are the dict keys, value per key is duplicate count
        static public Dictionary<T, int> GetDuplicateData<T>(T[] array)
        {
            return array.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        }

        static public Dictionary<T, int> GetDuplicateData<T>(List<T> list)
        {
            return list.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());
        }

        //Returns a for
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
