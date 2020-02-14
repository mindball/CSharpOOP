using System;
using ValidatorExample.Contracts;
using ValidatorExample.Exception;

namespace ValidatorExample.Models
{
    //Example: https://www.siepman.nl/blog/post/2014/01/05/SOLID-validation-class-with-easy-logical-implication.aspx

    public abstract class ValidationBase<T> : IValidation
        where T : class
    {
        protected ValidationBase(T context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }

            this.Context = context;
        }
        protected T Context { get; private set; }
        public abstract bool IsValid { get; }
        public abstract string Message { get; }

        public void Validate()
        {
            if(!this.IsValid)
            {
                throw new ValidationException(this.Message);
            }
        }
    }
}
