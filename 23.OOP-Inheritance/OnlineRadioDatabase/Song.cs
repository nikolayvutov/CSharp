using System;

public class Song
{
    private const int ArtistMinLength = 3;
    private const int ArtistMaxLength = 20;
    private const int NameMinLength = 3;
    private const int NameMaxLength = 30;
    private const int MinutesMin = 0;
    private const int MinutesMax = 14;
    private const int SecondsMin = 0;
    private const int SecondsMax = 59;

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
            if (value.Length < ArtistMinLength || value.Length > ArtistMaxLength)
            {
                throw new InvalidArtistNameException(ArtistMinLength, ArtistMaxLength);
            }
            artistName = value;
        }
    }

    public string SongName
    {
        get { return songName; }
        protected set
        {
            if (value.Length < NameMinLength || value.Length > NameMaxLength)
            {
                throw new InvalidSongNameException(NameMinLength, NameMaxLength);
            }
            songName = value;
        }
    }

    public string SongLength
    {
        get { return songLength; }
        protected set 
        {
            var parts = value.Split(':',StringSplitOptions.RemoveEmptyEntries);
            int min = int.Parse(parts[0]);
            int sec = int.Parse(parts[1]);

            if ((min < MinutesMin || min > MinutesMax) && (sec < SecondsMin || sec > SecondsMax))
            {
                throw new InvalidSongLengthException();
            }
            else if (min < MinutesMin || min > MinutesMax)
            {
                throw new InvalidSongMinutesException(MinutesMin, MinutesMax);
            }
            else if (sec < SecondsMin || sec > SecondsMax)
            {
                throw new InvalidSongSecondsException(SecondsMin, SecondsMax);
            }
            songLength = value;
        }
    }
}
