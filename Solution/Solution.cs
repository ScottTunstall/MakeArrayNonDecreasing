using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeArrayNonDecreasing
{
    public class Solution
    {
        struct Pair
        {
            public int Number;
            public int Count;

            public Pair(int number, int count)
            {
                Number = number;
                Count = count;
            }

            public override string ToString()
            {
                return $"Number: {Number}   Count: {Count}";
            }
        }

        public int TotalSteps(int[] nums)
        {
            Stack<Pair> stack = new ();
            int totalSteps = 0;
            
            for (int i = nums.Length- 1; i >= 0; i--)
            {
                int cnt = 0;
                while (stack.Count > 0 && stack.Peek().Number < nums[i])
                {
                    var popped = stack.Pop();
                    if (popped.Count == 0)
                    {
                        cnt++;
                    }
                    else 
                    {
                        if (popped.Count > cnt)
                        {
                            cnt += (popped.Count - cnt);
                        }
                        else
                        {
                            cnt ++;
                        }
                    }
                }

                stack.Push(new Pair(number: nums[i], count: cnt));
                totalSteps = Math.Max(cnt, totalSteps);
            }

            return totalSteps;
        }
    }
}
