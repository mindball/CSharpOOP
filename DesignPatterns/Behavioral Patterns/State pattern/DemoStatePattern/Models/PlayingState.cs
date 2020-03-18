using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatePattern.Models
{
    public class PlayingState : State
    {
        public PlayingState(Player player) 
            : base(player)
        {
        }

        public override string OnLock()
        {
            this.player.ChangeState(new LockedState(player));
            this.player.SetCurrentTrackAfterStop();
            return "Stop playing";
        }

        public override string OnNext()
        {
            return player.NextTrack();
        }

        public override string OnPlay()
        {
            this.player.ChangeState(new ReadyState(player));
            return "Paused...";
        }

        public override string OnPrevious()
        {
            return player.PreviousTrack();
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}";
        }
    }
}
