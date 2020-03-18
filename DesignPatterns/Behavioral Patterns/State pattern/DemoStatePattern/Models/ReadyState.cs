using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatePattern.Models
{
    public class ReadyState : State
    {
        public ReadyState(Player player) 
            : base(player)
        {           
        }

        public override string OnLock()
        {
            this.player.ChangeState(new LockedState(player));
            return "Locked...";
        }

        public override string OnNext()
        {
            return "Locked...";
        }

        public override string OnPlay()
        {
            string action = this.player.StartPlayback();
            this.player.ChangeState(new PlayingState(player));
            return action;
        }

        public override string OnPrevious()
        {
            return "Locked...";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}";
        }
    }
}
