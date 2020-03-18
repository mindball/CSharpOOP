using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatePattern.Models
{
    public class LockedState : State
    {
        public LockedState(Player player) 
            : base(player)
        {
            this.player.SetPlaying(false);
        }

        public override string OnLock()
        {
            if (this.player.IsPlaying())
            {
                this.player.ChangeState(new ReadyState(player));
                return "Stop playing";
            }
            else
            {
                return "Locked...";
            }
        }

        public override string OnNext()
        {
            return "Locked...";
        }

        public override string OnPlay()
        {
            this.player.ChangeState(new ReadyState(player));
            return "Ready";
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
