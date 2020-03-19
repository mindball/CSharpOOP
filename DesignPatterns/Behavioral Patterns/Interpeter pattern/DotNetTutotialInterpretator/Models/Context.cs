using System;

namespace DotNetTutotialInterpretator.Models
{
    public class Context
    {
        public Context(DateTime date)
        {
            this.Date = date;
        }
        public string Expression { get; set; }
        public DateTime Date { get; set; }
    }
}
