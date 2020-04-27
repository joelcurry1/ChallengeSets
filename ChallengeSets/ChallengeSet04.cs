using System;
using System.Linq;
using System.Collections;
namespace ChallengeSets
{
    public class ChallengeSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int num = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    num += numbers[i];
                }
                else
                {
                    num -= numbers[i];
                }
            }
            return num;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //int one, two, three, four;
            //one = str1.Length;
            //two = str2.Length;
            //three = str3.Length;
            //four = str4.Length;
            //return str1.Split("").Min(x => x.Length);
            string test;
            test = str1 + "," + str2 + "," + str3 + "," + str4;
            return test.Split(",").Min(x => x.Length);
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int one = 0;
            int two = 0;
            if (number1 < number2)
            {
                one = number1;
            }
            else
            {
                one = number2;
            }

            if (number3 < number4)
            {
                two = number3;
            }
            else
            {
                two = number4;
            }
            if (one < two)
            {
                return one;
            }
            else
            {
                return two;
            }
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //if (a + b <= c || a + c <= b || b + c <= a)
            //{

            //}
            if ((sideLength1 + sideLength2 <= sideLength3) || (sideLength1 + sideLength3 <= sideLength2) || (sideLength2 + sideLength3 <= sideLength1))
            {
                return false;
            }
            else
            {
                return true;
            }
            //return (sideLength1 + sideLength2) >= sideLength3 && (sideLength1 + sideLength3) >= sideLength2 && (sideLength2 + sideLength3) >= sideLength1;
        }

        public bool IsStringANumber(string input)
        {
            double num;
            bool isNumeric = double.TryParse(input, out num);
            if (isNumeric == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int isnull = 0;
            int notnull = 0;
            int counter = 0;
            foreach (var item in objs)
            {
                if (item == null)
                {

                    isnull++;
                }
                else
                {
                    notnull++;
                }
                counter++;
            }
            if (isnull > notnull)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null) return 0;
            double total = 0;
            double counter = 0;
            for (int i = 0; i < numbers.Count(); i++)
            {
                if (numbers[i] %2 == 0)
                {
                    counter++;
                    total += numbers[i];
                }
                //else
                //{
                //    counter++;
                //    total += numbers[i];
                //}
            }
            if (total == 0)
            {
                return 0;
            }
            return total / counter;

        }

        public int Factorial(int number)
        {
            
            if (number == 0) return 1;
            int result = number;
            for (int i = 1; i < number; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
