using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeArrayNonDecreasing
{
    public class Solution
    {
        public int TotalSteps(int[] nums)
        {
            int totalSteps = 0;

            var skipTo = new int[nums.Length];

            bool goAgain;

            do
            {
                goAgain = false;

                for (int i = 0; i < nums.Length; i++)
                {
                    i = FindNextIndexToSkipTo(ref skipTo, i);
                    if (i == -1)
                        break;

                    var l = nums[i];

                    for (int j = i+1; j < nums.Length; j++)
                    {
                        j = FindNextIndexToSkipTo(ref skipTo, j);
                        if (j == -1)
                            break;

                        var r = nums[j];

                        if (l > r)
                        {
                            l = nums[j];
                            skipTo[j] = j+1;
                            goAgain = true;
                        }
                        else
                        {
                            i = j-1;
                            break;
                        }
                    }
                }

                if (goAgain)
                    totalSteps++;

            } while (goAgain);


            return totalSteps;
        }

        private int FindNextIndexToSkipTo(ref int[] skipTo, int index)
        {
            
            while (index < skipTo.Length && skipTo[index] != 0)
            {
                index = skipTo[index];
            }

            if (index >= skipTo.Length)
                return -1;

            return index;
        }
    }
}
