using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
           
            if (vals == null)
            {
                return false;
            }
            
            foreach (var val in vals)
            {
                if (val == false)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null)
            {
                return false;
            }
            
            int sum = 0;
            foreach (var number in numbers)
            {
                if (number % 2 != 0)
                {
                    sum += number;
                }
            }

            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            var isLetter = false;
            var isDigit = false;
            var isUpper = false;

            foreach (var c in password)
            {
                if (char.IsLower(c))
                {
                    isLetter = true;
                }

                if (char.IsDigit(c))
                {
                    isDigit = true;
                }

                if (char.IsUpper(c))
                {
                    isUpper = true;
                }
                
            }
            return isUpper && isLetter && isDigit;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[^1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            return divisor == 0 ? 0 : dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[^1] - nums[0];;
        }

        public int[] GetOddsBelow100()
        {
            int[] nums = new int[50];
            var odd = 0;

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    nums[odd] = i;
                    odd++;
                }
            }
            return nums;
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
