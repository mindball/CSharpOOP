using RadioDatabase.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace RadioDatabase
{
    public class Song
    {
        ///TODO: throw new InvalidSongLengthException();
        private string songName;
        private string  artistName;
        private int minutes;
        private int seconds;

        public Song(string songName, string artistname, 
            int minutes, int seconds)
        {
            this.SongName = songName;
            this.ArtistName = artistname;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public int Seconds
        {
            get
            {
                return seconds;
            }
            set
            {
                if (value < 0 || value > 59)
                    throw new InvalidSongSecondsException();
                seconds = value;
            }
        }

        public int Minutes
        {
            get
            {
                return minutes;
            }
            set
            {
                if (value < 0 || value > 14)
                    throw new InvalidSongMinutesException();
                minutes = value;
            }
        }

        public string  ArtistName
        {
            get
            {
                return artistName;
            }
            set
            {
                if(value.Length < 3 || value.Length > 20)
                {
                    throw new InvalidArtistNameException();
                }
                artistName = value;
            }
        }

        public string SongName
        {
            get
            {
                return songName;
            }
            set
            {
                if (value.Length < 3 || value.Length > 30)
                    throw new InvalidSongNameException();
                songName = value;
            }
        }

    }
}
