using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Classes
{
    public static class Mini_Max_Sum
    {
        
        public static string MainFunc()
        {
            int[] list = new int[]{ 1, 3, 5, 7, 9};
            int res = 0;
            int min = 0;
            int max = 0;
            for (int a = 0; a < list.Length; a++)
            {
                for (int b = 0; b < list.Length; b++)
                {
                    if (a == b)
                        continue;
                    
                    res += list[b];   
                }
                if (min == 0)
                    min = res;
                if (res > max)
                    max = res;
                if (res < min)
                    min = res;
                res = 0;
            }
            return min.ToString()+" "+max.ToString();
        }
    }
}
