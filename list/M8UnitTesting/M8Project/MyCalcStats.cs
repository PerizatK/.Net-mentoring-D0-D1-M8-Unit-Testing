using System;
using System.Collections.Generic;
using System.Text;

namespace M8Project
{
    public class MyCalcStats
    {
        private readonly int[] nums;

        public MyCalcStats(int[] nums)
        {
            this.nums = nums;
        }

        public int GetMininum()
        {
            int min = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                min = min < nums[i] ? min : nums[i];
            }
            return min;
        }

        public int GetMaximum()
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                max = max > nums[i] ? max : nums[i];
            }
            return max;
        }

        public int Count()
        {
            return nums.Length;
        }

        public double GetAverage()
        {
            double avg = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                avg += nums[i];
            }
            avg /= nums.Length;
            return avg;
            //return nums.Average()
        }
    }
}
