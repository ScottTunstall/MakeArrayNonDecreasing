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


            bool goAgain;

            do
            {
                goAgain = false;

                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == int.MaxValue)
                        continue;

                    var l = nums[i];

                    for (int j = i+1; j < nums.Length; j++)
                    {
                        if (nums[j] == int.MaxValue)
                            continue;

                        var r = nums[j];

                        if (l > r)
                        {
                            l = nums[j];
                            nums[j] = int.MaxValue;
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
    }
}
