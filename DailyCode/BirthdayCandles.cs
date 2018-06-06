namespace DailyCode
{
    internal class BirthdayCandles
    {
        // You are in-charge of the cake for your niece's birthday and have decided the cake will have one candle for each year of her total age.
        // When she blows out the candles, she’ll only be able to blow out the tallest ones. Your task is to find out how many candles she can successfully blow out.

        public int candlesBlown(int candles, int[] candleHeights)
        {
            int tallest = 0;
            int blown = 0;

            foreach (int n in candleHeights)
            {
                if (n > tallest)
                {
                    tallest = n;
                    blown = 1;
                }
                else if (n == tallest)
                {
                    blown++;
                }
            }
            return blown;
        }
    }
}