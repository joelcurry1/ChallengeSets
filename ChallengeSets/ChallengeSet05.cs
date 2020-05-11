using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ChallengeSets
{
    public class ChallengeSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue <= 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return false; 
            int firstNumber = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < firstNumber)
                {
                    return false;
                }
                firstNumber = numbers[i];
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers != null)
            {
                int[] arr = new int[] { };
                int sumevens = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        try { sumevens += numbers[i + 1]; }
                        catch (System.IndexOutOfRangeException)
                        {

                        }
                    }
                }
                return sumevens;
            }
            return 0;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0 || words.Length == 1)
            {
                return "";
            }
            string sentence = "";
            int counter = 0;
            foreach (string str in words)
            {
                if (str == " " || str == "" )
                {
                    counter++;
                    continue;
                }
                string toAdd = str.Replace(" ", "");
                sentence += toAdd;

                if (counter < words.Length - 1 && toAdd != "") sentence += " ";
                else if (counter == words.Length - 1) sentence += ".";
                counter++;
            }
            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null) return new double[0];
            List<double> everyfourth = new List<double>();
            for (int i = 1; i <= elements.Count; i++)
            {
                if (i %4 == 0)
                {
                    everyfourth.Add(elements[i - 1]);
                }
            }
            return everyfourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums.Length == 0 || nums.Length == 1) return false;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j) continue;
                    if (nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
