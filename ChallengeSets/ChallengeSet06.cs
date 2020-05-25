using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace ChallengeSets
{
    public class ChallengeSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            //var q = words.Any(w => word.Contains(w));
            //var escapedWords = words.Select(w => @"/b" + Regex.Escape(w) + @"/b");
            //var pattern = new Regex("(" + string.Join(")|(", escapedWords) + ")");
            //bool q = pattern.IsMatch(word);
            if (words == null || words.Contains (null)) return false;

            if (ignoreCase)
            {
                foreach (var item in words)
                {
                    if (item.ToLower() == word)
                    {
                        return true;
                    }
                }
                return false;
            }
            else
            {
                foreach (var item in words)
                {
                    if (words.Contains(word))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num <= 1) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(num));

            for (int i = 3; i <= boundary; i+= 2)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int counter = 0;
            int last = 0;
            if (str =="")
            {
                return -1;
            }

            int[] counts = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                foreach (var letter in str)
                {
                    if (str[i] == letter)
                    {
                        counts[i]++;
                    }
                }
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] == 1)
                {
                    last = i;
                }
                else if (counts[i] > 1)
                {
                    counter++;
                }
            }
            if (counter == str.Length)
            {
                return -1;
            }
            return last;


        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;
            int previousNumber = numbers[0];
            int firstCount = 1;
            int maxCount = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == previousNumber)
                {
                    firstCount++;
                }
                if (firstCount > maxCount)
                {
                    maxCount = firstCount;
                }
                if (numbers[i] != previousNumber)
                {
                    firstCount = 1;
                }
                previousNumber = numbers[i];
            }
            return maxCount;

        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            int x = n;
            List<double> everyNth = new List<double>();
            if (elements == null)
            {
                return everyNth.ToArray();
            }
            for (int i = 0; i < elements.Count; i++)
            {
                if (elements[i] == x)
                {
                    everyNth.Add(elements[i]);
                    x += n;
                }
            }
            return everyNth.ToArray();
        }
    }
}
