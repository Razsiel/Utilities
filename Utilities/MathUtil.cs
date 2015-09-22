using System;

namespace Utilities
{
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
                for (int i = biasArray.Length - 1; i >= 0; i--)
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
}
