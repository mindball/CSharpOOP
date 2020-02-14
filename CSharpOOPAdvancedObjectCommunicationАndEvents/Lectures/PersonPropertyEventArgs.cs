
namespace Lectures
{
    using System;
    class PersonPropertyEventArgs : EventArgs
    {
        //Това е по стандарта на C# - държавния
        //Също така може да подаде EventArgs.Emptuy -> ако не искаме никакви аргументи
        public string Property { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
    }
}
