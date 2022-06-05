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

            var asList = new List<int>(nums);

            for (;;)
            {
                int left = 0;
                bool goAgain = false;

                while (left < asList.Count- 1)
                {
                    var lValue = asList[left];
                    var rValue = asList[left+1];

                    if (lValue > rValue)
                    {
                        asList.RemoveAt(left+1);
                        goAgain = true;
                    }

                    left++;
                }
                
                totalSteps++;

                if (!goAgain)
                    break;
            }

            return totalSteps;
        }
    }
}
