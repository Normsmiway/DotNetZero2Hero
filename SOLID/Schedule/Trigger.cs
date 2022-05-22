namespace SOLID.Schedule
{
    public interface ITrigger
    {
        public bool IsDue(DateTime date);
    }
    public class DefaultScheduleTrigger
    {
        public bool IsDue(DateTime date) => DateTime.UtcNow.Date.Equals(date.Date);
    }


    public class DailyTrigger : ITrigger
    {
        public bool IsDue(DateTime date) => default;
    }

    public class WeeklyTreigger : ITrigger
    {
        public readonly DayOfWeek dayOfWeek;
        public WeeklyTreigger(DayOfWeek dayOfWeek)
        {
            this.dayOfWeek = dayOfWeek;
        }
        public bool IsDue(DateTime date) => default;
    }

    public class MonthlyTrigger : ITrigger
    {
        public bool IsDue(DateTime date) => default;
    }

    public class YearlyTrigger : ITrigger
    {
        public bool IsDue(DateTime date) => default;
    }

    public class EndOfWeekTrigger : WeeklyTreigger
    {
        public EndOfWeekTrigger() : base(DayOfWeek.Sunday) { }
    }



    public static class Scheduler
    {
        public static void Run(ITrigger trigger, DateTime date)
        {
            Console.WriteLine($"Running {trigger.GetType().Name}", trigger.IsDue(date));
        }
    }

}
