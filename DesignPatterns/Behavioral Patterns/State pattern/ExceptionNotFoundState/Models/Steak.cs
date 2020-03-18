using System;

namespace ExceptionNotFoundState.Models
{
    public class Steak
    {
        private Doneness state;
        private string beefCut;

        public Steak(string beefCut)
        {
            this.beefCut = beefCut;
            this.State = new Rare(0.0, this);
        }

        public double CurrentTemp => this.state.CurrentTemp;

        public Doneness State { get => this.state; set => this.state = value; }

        public void AddTemp(double amount)
        {
            this.State.AddTemp(amount);
            Console.WriteLine("Increased temperature by {0} degrees.", amount);
            Console.WriteLine(" Current temp is {0}", this.CurrentTemp);
            Console.WriteLine(" Status is {0}", this.State.GetType().Name);
            Console.WriteLine("");
        }

        public void RemoveTemp(double amount)
        {
            this.State.RemoveTemp(amount);
            Console.WriteLine("Decreased temperature by {0} degrees.", amount);
            Console.WriteLine(" Current temp is {0}", this.CurrentTemp);
            Console.WriteLine(" Status is {0}", this.State.GetType().Name);
            Console.WriteLine("");
        }
    }
}
