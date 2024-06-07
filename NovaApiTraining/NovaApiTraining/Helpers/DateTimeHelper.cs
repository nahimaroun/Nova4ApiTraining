namespace NovaApiTraining.Helpers
{
    public static class DateTimeHelper
    {

        public static DateTime ConvertEpochToDmyDateTime(double unixTime)
        {
            // Assuming the unixTime is in seconds (common scenario)
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var dateTime = epoch.AddSeconds(unixTime);

            // Format the date time string in dmy format (day-month-year)
            return dateTime;
        }
    }
}
