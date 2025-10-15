using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.JavaScript;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < alphabet.Length; i++)
            {
                if (alphabet[i] == c)
                {
                    return true;
                }


            } return false;
        }


        //return char.IsLetter(c);
        

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
           return false;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {

          /*  if (numbers == null || numbers.Count() <= 0)
            {
                return 0;
            }
            
            double  min = 0;
            double   max = 0;
            double currentMin = 0;
            double currentMax = 0;
            
            var list= numbers.ToList();

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] > list[i + 1])
                {
                    max = list[i];
                }
            }

            for (int i = 0; i < list.Count - 1; i++)
            {
                if (list[i] < list[i + 1])
                {
                    min = list[i];

                }
                
            }
            

            return min + max;
            
            
            */
            return numbers == null || numbers.Count() == 0 ? 0 : numbers.Min() + numbers.Max();



        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str2.Length < str1.Length)
            {
                return str2.Length;
            }
            
            return str1.Length;

        }

        public int Sum(int[] numbers)
        {
            
            if (numbers == null || numbers.Count() <= 0)
            {
                return 0;
            }
            
            int sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            int sum = 0;
            
            if (numbers == null || numbers.Count() <= 0)
            {
                return 0;
            }
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }

            return sum;
        }

        public bool IsSumOdd(List<int> numbers)
        {

            if (numbers == null)
            {
                return false;
            }

            return numbers.Sum() % 2 != 0;
        }


        public long CountOfPositiveOddsBelowNumber(long number)
        {
            var count = 0;

            if (number == 1 || number <= 0)
            {
                return 0;
            }

            for (long i = number; i > 0; i--)
            {
                if (i % 2 == 0)
                {
                    count++;
                }
            } return count;
            
        }
        
    }
}
