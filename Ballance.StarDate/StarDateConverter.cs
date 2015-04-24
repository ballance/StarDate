using System;

namespace Ballance.StarDate
{
    public static class Extensions
    {

        public static double ToStarDate(this DateTime earthDateTime)
        {
            var starDateOrigin = new DateTime(2318, 7, 5, 12, 0, 0);
            var earthToStarDateDiff =  earthDateTime - starDateOrigin;
            var millisecondConversion = earthToStarDateDiff.TotalMilliseconds / (34367056.4);
            var starDate = Math.Floor(millisecondConversion * 100) / 100;

            return Math.Round(starDate, 2, MidpointRounding.AwayFromZero);
        }
    }
}
