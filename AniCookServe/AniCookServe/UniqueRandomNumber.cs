using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AniCookServe
{
    class UniqueRandomNumber
    {
        private Random random = new Random();
        private List<int> usedNumbers = new List<int>();
        private int listLength;
       
        public UniqueRandomNumber(int length)
        {
            listLength = length; 
        }

        /// <summary>
        /// Generates a unique random number
        /// </summary>
        /// <param name="minValue">The inclusive lower bound of the random number returned.</param>
        /// <param name="maxValue">The exclusive upper bound of the random number returned. Must be greater than or equal to minValue.</param>
        /// <returns>Returns a nonnegative random integer (single digit) that has not previously been returned since creation of this instance or last call to Reset().</returns>
        public int Next(int minValue, int maxValue)
        {
            //Prevent getting stuck in a loop
            if (usedNumbers.Count == listLength)
            {
                throw new Exception("All possible digits used up. Call Reset() to continue using this instance.");
            }

            bool isUnique = true;
            int val = -1;

            do
            {
                isUnique = true;
                val = random.Next(minValue, maxValue);

                for (int j = 0; j < usedNumbers.Count; j++)
                {
                    if (usedNumbers[j] == val)
                    {
                        isUnique = false;
                        break;
                    }
                }
            } while (!isUnique);

            usedNumbers.Add(val);
            return val;
        }

        /// <summary>
        /// Resets this unique random digit generator. All previously generated digits may be re-generated.
        /// </summary>
        public void Reset()
        {
            usedNumbers.Clear();
        }
    }
}

