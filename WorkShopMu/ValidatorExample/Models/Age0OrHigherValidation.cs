using System;
using System.Collections.Generic;
using System.Text;

namespace ValidatorExample.Models
{
    class Age0OrHigherValidation : ValidationBase<Person>
    {
        public Age0OrHigherValidation(Person context)
            : base(context)
        {
        }
        public override bool IsValid
        {
            get { return this.Context.Age >= 0; }
        }

        public override string Message
        {
            get
            {
                return string.Format("The Age {1} of {0} is not 0 or higher.",
                    this.Context.Name, this.Context.Age);
            }
        }
    }
}
