using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Utilities
{
    static public class ConsoleUtil
    {
        static public void ColoredWrite(string s, ConsoleColor color)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.Write(s);
            Console.ForegroundColor = prevColor;
        }
        static public void ColoredWriteLine(string s, ConsoleColor color)
        {
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = color;
            Console.WriteLine(s);
            Console.ForegroundColor = prevColor;
        }
    }
    static public class StringUtil
    {
        static public string UpperCaseFirstCharacter(this string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;
            return Regex.Replace(text, "^[a-z]", m => m.Value.ToUpper());
        }
    }
    static public class MathUtil
    {
        static public bool Bool(this Random r)
        {
            int rnd = new Random().Next(0, 1);
            if (rnd == 1)
                return true;
            return false;
        }
        static public int GetBiasedRandom(int[] biasArray)
        {
            //Get combined bias value
            int max = 0;
            foreach (int value in biasArray)
                max += value;

            //Generate random value between 0 -> max
            int rand = new Random().Next(0, max);
            
            while (max > 0)
            {
                for (int i = biasArray.Length-1; i >= 0; i--)
                {
                    max -= biasArray[i];
                    if (rand > max)
                        return i;
                }
            }
            return -1;
        }
        static public int GetNormalizedBiasedRandom(int[] biasArray)
        {
            //Get combined bias value, used for normalization
            int max = 0;
            foreach (int value in biasArray)
            {
                max += value;
            }

            //Normalize values to fit within the 0-100 scale
            for (int i = 0; i < biasArray.Length; i++)
            {
                biasArray[i] = (int)(((float)biasArray[i] / max) * 100);
            }

            //Generate random value between 0-100
            int rand = new Random().Next(0, 101);

            while (max > 0)
            {
                for (int i = biasArray.Length - 1; i >= 0; i--)
                {
                    max -= biasArray[i];
                    if (rand > max)
                        return i;
                }
            }
            return -1;
        }
    }
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
