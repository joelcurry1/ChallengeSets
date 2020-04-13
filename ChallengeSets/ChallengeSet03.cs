using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers != null)
            {
                int sum = 0;
                foreach (var i in numbers)
                {
                    sum += i;
                }
                
                if (sum % 2 == 0)
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {

            bool upperLowernum = false;
            bool hasUp = password.Any(char.IsUpper);
            bool hasLow = password.Any(char.IsLower);
            bool hasNum = password.Any(char.IsDigit);
            if (hasUp && hasLow && hasNum)
            {
                upperLowernum = true;
            }
            return upperLowernum;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {

            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1]-nums[0];
        }
        public int[] GetOddsBelow100()
        {
            int[] odd = new int[50];
            List<String> num = new List<String>();

            for (int n = 0; n < 100; n++)
            {
                if (n! % 2 != 0)
                {
                    num.Add(n.ToString());
                }
            }

            for (int i = 0; i < num.Count; i++)
            {
                odd[i] = Convert.ToInt32(num[i]);
            }

            return odd;
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
