using System;
using System.Collections.Generic;
using System.Text;

namespace ValidatorExample.Models
{
    class OnlyAdultsCanConsumeAlcoholValidation : ValidationBase<Person>
    {
        private const int minimumAge = 18;

        public OnlyAdultsCanConsumeAlcoholValidation(Person context)
            : base(context)
        {           
        }

        public override bool IsValid
        {
            get { return !this.Context.ConsumesAlcohol || this.Context.Age >= 18; }
        }

        public override string Message
        {
            get
            {
                return string.Format(
                    "{0} is not allowed to consume alcohol because his or her age ({1}) not is {2} or higher.",
                    Context.Name, Context.Age, minimumAge);
            }
        }
    }
}
