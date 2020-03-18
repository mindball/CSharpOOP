using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatePattern.Models
{
    public abstract class State
    {
        protected Player player;
        public State(Player player)
        {
            this.player = player;
        }

        public abstract string OnLock();
        public abstract string OnPlay();
        public abstract string OnNext();
        public abstract string OnPrevious();
    }
}
