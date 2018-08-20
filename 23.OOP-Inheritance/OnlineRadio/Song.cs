using System;

public class Song
{
    private string artistName;
    private string songName;
    private string songLength;

    public Song(string artistName, string songName, string songLength)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.SongLength = songLength;
    }

    public string ArtistName
    {
        get { return artistName; }
        protected set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }
            artistName = value;
        }
    }

    public string SongName
    {
        get { return songName; }
        protected set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }
            songName = value;
        }
    }

    public string SongLength
    {
        get { return songLength; }
        protected set
        {
            var parts = value.Split(':', StringSplitOptions.RemoveEmptyEntries);

            int min;
            int sec;
            bool succesMin = int.TryParse(parts[0], out min);
            bool succesSec = int.TryParse(parts[1], out sec);

            if (!succesMin && !succesSec)
            {
                throw new ArgumentException("Invalid song length.");
            }
            else if (min < 0 || min > 14)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }
            else if (sec < 0 || sec > 59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
            }
            songLength = value;
        }
    }

    public bool IsInvalidSong()
    {
        bool invalidLength = false;
        bool invalidSongName = false;
        bool invalidArtistName= false;

        var parts = this.songLength.Split(':', StringSplitOptions.RemoveEmptyEntries);
        int min = int.Parse(parts[0]);
        int sec = int.Parse(parts[1]);

        if ((min < 0 || min > 14) && (sec < 0 || sec > 59))
        {
            invalidLength = true;
        }

        if (this.songName.Length < 3 || this.songName.Length > 30)
        {
            invalidSongName = true;
        }

        if (this.artistName.Length < 3 || this.artistName.Length > 20)
        {
            invalidArtistName = true;
        }

        return invalidLength && invalidSongName && invalidArtistName;
    }
}
