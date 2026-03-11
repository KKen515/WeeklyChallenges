using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool containsWord = false;

            if (string.Equals(words, null) || words.Contains(null))
            {
                return false;
            }
            
            if (ignoreCase)
            {
                word = word.ToLower();
                
                List<string> lc = words.Select(x => x.ToLower()).ToList();

                containsWord = lc.Contains(word);
            }

            if (!ignoreCase)
            {
                containsWord = words.Contains(word);
            }
            
            
            return containsWord;
        }

        public bool IsPrimeNumber(int num)
        {
            
            var isPrime = false;
            if (num >= 0)
            {
                if (num % 2 != 0 && num % 3 != 0)
                {
                    isPrime = true;
                }
            }

            if ((num == 2) || (num == 3))
            {
                isPrime = true;
            }

            if (num == 1)
            {
                isPrime = false;
            }
                
            return isPrime;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int index = -1;
            bool uniqueIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uniqueIndex = true;

                for (int n = 0; n < str.Length; n++)
                {
                    if (str[i] == str[n] && i != n)
                    {
                        uniqueIndex = false;
                    }
                }

                if (uniqueIndex == true)
                {
                    index = i;
                }
                
            }
            return index;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int maxConsecutiveCount = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (var n = i + 1; n < numbers.Length; n++)
                {
                    if (numbers[i] != numbers[n])
                    {
                        break;
                    }
                    
                    currentCount++;
                }

                if (currentCount > maxConsecutiveCount)
                {
                    maxConsecutiveCount = currentCount;
                }
                
            }
            
            return maxConsecutiveCount;
            
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            List<double> nthElement = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            {
                return nthElement.ToArray();
            }

            for (var i = n - 1; i < elements.Count; i += n)
            {
                nthElement.Add(elements[i]);
            }
            
            return nthElement.ToArray();
        }
    }
}
