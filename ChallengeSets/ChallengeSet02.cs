using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChallengeSets
{
    public class ChallengeSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }
            double maxValue = 1000000.0;
            double minValue = 0;
            foreach (double duh in numbers.ToList())
            {
                if (duh < maxValue)
                {
                    maxValue = duh;
                }
                if (duh > minValue)
                {
                    minValue = duh;
                }
            }
            return minValue + maxValue;
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;
        }

        public int Sum(int[] numbers)
        {
            if (numbers != null)
            {
                int[] arr = new int[] { };
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    sum += numbers[i];
                }
                return sum;
            }
            return 0;
        }
        public int SumEvens(int[] numbers)
        {
            if (numbers != null)
            {
                int[] arr = new int[] { };
                int sumevens = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sumevens += numbers[i];
                    }
                }
                return sumevens;
            }
            return 0;
        }

        public bool IsSumOdd(List<int> numbers)
        {
            
            if(numbers != null)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Count; i++)
                {

                    sum += numbers[i];
                }
                if (sum % 2 == 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            int oddsCounter = 0;
            for (int i = 0; i < number; i++)
            {
                if(i % 2 != 0)
                {
                    oddsCounter++;
                }
            }
            return oddsCounter;
        }
    }
}