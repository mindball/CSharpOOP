using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Froggy
{
    class Lake<T> : IEnumerable<T>
    {
        private T[] stones;

        public Lake(T[] stones)
        {
            this.stones = stones;
        }

        public int CountOfStones { get => this.stones.Length; }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.stones.Length; i++)
            {
                yield return this.stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


    }
}
