using System;

namespace Weekdays
{
    public class WeeklyEntry : IComparable<WeeklyEntry>
    {
        
        public WeeklyEntry(string weekday, string notes)
        {
            this.Weekday = (WeekDay)Enum.Parse(typeof(WeekDay), weekday);
            this.Notes = notes;
        }

        public WeekDay Weekday { get; private set; }
        public string Notes { get; set; }

        public int CompareTo(WeeklyEntry other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var weekDayComparisson = this.Weekday.CompareTo(other.Weekday);

            return string.Compare(this.Notes, other.Notes, StringComparison.Ordinal);
        }

        public override string ToString()
        {
            return $"{this.Weekday} - {this.Notes}";
        }
    }
}
