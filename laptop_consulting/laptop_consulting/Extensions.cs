using System;
using System.Collections.Generic;

namespace laptop_consulting
{
    static class SubstringExtensions
    {
        public static string Between(this string value, string a, string b)
        {
            int posA = value.IndexOf(a);
            //string tmp = value.Substring(posA + a.Length-1);
            //int posB = a.Length-1 + posA+ tmp.IndexOf(b);
            //int posB = value.LastIndexOf(b);
            List<int> posBs = value.AllIndexesOf(b);
            int posB = value.LastIndexOf(b);
            if (posBs.Count >= 1)
            {
                posB = posBs[0];
                if (posBs.Count > 1)
                    posB = posBs[1];
            }

            if (posA == -1) return null;
            if (posB == -1) return null;

            int adjustedPosA = posA + a.Length;
            if (adjustedPosA >= posB) return null;

            return value.Substring(adjustedPosA, posB - adjustedPosA);
        }

        public static List<int> AllIndexesOf(this string str, string value)
        {
            if (String.IsNullOrEmpty(value))
                throw new ArgumentException("the string to find may not be empty", "value");
            List<int> indexes = new List<int>();
            for (int index = 0;; index += value.Length)
            {
                index = str.IndexOf(value, index);
                if (index == -1)
                    return indexes;
                indexes.Add(index);
            }
        }
    }
}