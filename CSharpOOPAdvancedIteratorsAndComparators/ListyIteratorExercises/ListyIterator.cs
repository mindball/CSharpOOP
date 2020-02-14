using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ListyIteratorExercises
{
    class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> collection;
        private int index = 0;

        public ListyIterator(params T[] ts)
        {
            this.collection = new List<T>(ts);
        }

        public bool Move()
        {
            if (this.index < this.collection.Count)
            {
                this.index++;
                return true;
            }

            return false;
        }

        public bool HasNext()
        {
            if (this.index == this.collection.Count - 1
                || this.index > this.collection.Count)
                return false;

            return true;
        }

        public T Print()
        {
            if (this.collection is null || this.collection.Count == 0)
                throw new InvalidOperationException("Invalid Operation!");

            return collection[this.index];
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T item in collection)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
