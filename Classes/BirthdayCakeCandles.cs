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
                for(int b = 0; b < candles.Count; b++)
                {
                    if (a == b)
                        continue;
                    if(candles[b] > candles[a])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
