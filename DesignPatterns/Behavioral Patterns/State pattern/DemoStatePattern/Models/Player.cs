using System;
using System.Collections.Generic;
using System.Text;

namespace DemoStatePattern.Models
{
    public class Player
    {
        private State state;
        private bool isPlaying = false;
        private List<string> playList = new List<string>();
        private int currentTrack = 0;

        public Player()
        {
            this.state = new ReadyState(this);
            SetPlaying(true);
            for (int i = 0; i < 4; i++)
            {
                this.playList.Add("Track: " + i);
            }
        }

        public void SetPlaying(bool playing)
        {
            this.isPlaying = playing;
        }

        public void ChangeState(State state)
        {
            this.state = state;
        }

        public State GetState() => this.state;

        public bool IsPlaying() => this.isPlaying;

        public string StartPlayback() => "Playing " + this.playList[this.currentTrack];

        public string NextTrack()
        {
            this.currentTrack++;
            if (this.currentTrack > this.playList.Count - 1)
                this.currentTrack = 0;

            return "Playing " + this.playList[this.currentTrack];
        }

        public string PreviousTrack()
        {
            this.currentTrack--;
            if (this.currentTrack < 0)
                this.currentTrack = this.playList.Count - 1;

            return "Playing " + this.playList[this.currentTrack];
        }

        public void SetCurrentTrackAfterStop()
        {
            this.currentTrack = 0;
        }
    }
}
