using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.Classes
{
    static class BirthdayCakeCandles
    {

        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = candles[0];
            int count = 0;
            for (int a = 0; a < candles.Count; a++)
            {
                if(candles[a] >= max)
                {
                    if (candles[a] > max)
                    {
                        count = 1;
                        max = candles[a];
                    }
                    else
                        count++;
                }
            }
            return count;
        }
    }
}
