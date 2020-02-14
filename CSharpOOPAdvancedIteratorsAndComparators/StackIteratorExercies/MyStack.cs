using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace StackIteratorExercies
{
    public class MyStack<T> : IEnumerable<T>
    {
        T[] elements;

        public MyStack(T[] elements)
        {
            this.elements = elements;
        }

        public int Capacity { get => this.elements.Length - (this.elements.Length - this.Count); }

        public int Count { get; set; }

        public void Push(T element)
        {
            if (this.Count >= this.elements.Length)
                Resize();
            this.elements[this.Count] = element;
            this.Count++;
        }

        public T Pop()
        {
            T topElementOfStack = this.elements[this.elements.Length - 1];
            this.Count--;
            if (this.Count < 0)
                this.Count = 0;
            return topElementOfStack;
        }

        private void Resize()
        {
            Array.Resize(ref this.elements, (this.elements.Length * 2));
        }

        public void PrintStack()
        {
            for (int i = this.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(this.elements[i]);
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Capacity - 1 ; i >= 0; i--)
            {
                yield return this.elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
