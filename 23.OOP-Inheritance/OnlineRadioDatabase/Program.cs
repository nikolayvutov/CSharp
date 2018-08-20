using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int numberSongs = int.Parse(Console.ReadLine());
        List<Song> songs = new List<Song>();

        for (int i = 0; i < numberSongs; i++)
        {
            var input = Console.ReadLine().Split(';');

            try
            {
                if (input.Length < 3 )
                {
                    throw new InvalidSongException();
                }

                Song song = new Song(input[0], input[1], input[2]);
                songs.Add(song);
                Console.WriteLine("Song added.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
        var output = CalculateAllSongsLength(songs);

        Console.WriteLine($"Songs added: {songs.Count}");
        Console.WriteLine($"Playlist length: {output[0]}h {output[1]}m {output[2]}s");
        
    }

    private static int[] CalculateAllSongsLength(List<Song> songs)
    {
        int[] output = new int[3];
        int sec = 0;
        int min = 0;
        int hour = 0;

        foreach (var s in songs)
        {
            var parts = s.SongLength.Split(':');
            int minInput = int.Parse(parts[0]);
            int secInput = int.Parse(parts[1]);

            sec += secInput;
            if (sec > 59)
            {
                sec -= 60;
                min++;
            }
            min += minInput;
            if (min > 59)
            {
                min -= 60;
                hour++;
            }
        }
        output[0] = hour;
        output[1] = min;
        output[2] = sec;

        return output;
    }
}

