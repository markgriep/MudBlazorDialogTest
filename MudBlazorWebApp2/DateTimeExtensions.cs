namespace MudBlazorDialogTest
{
    public static class DateTimeExtensions
    {
        public static TimeSpan? ToTimeSpan(this DateTime? dateTime)
        {
            return dateTime?.TimeOfDay;
        }

        public static DateTime? WithTime(this DateTime? dateTime, TimeSpan? time)
        {
            if (time.HasValue)
            {
                var date = dateTime?.Date ?? DateTime.Today;
                return date.Add(time.Value);
            }
            return null;
        }
    }
}
