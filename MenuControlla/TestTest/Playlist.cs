using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTest
{
    public static class Playlist
    {
        private static HashSet<Song> songs = new HashSet<Song>();

        public static void AddSong(Song song)
        {
            songs.Add(song);
        }

        public static Song BestSong()
        {
            var maxResult = songs
                .Max(x => x.Rating);

            Song song = null;

            foreach (Song s in songs) 
            {
                if(s.Rating == maxResult)
                {
                    song = s; 
                    break; 
                }
            }

            return song;
        }

        public static List<Song> FindSongsBySinger(string singer) 
        {
            List<Song> foundSongs = new List<Song>();

            foreach (Song s in songs) 
            {
                if(s.Singer == singer)
                {
                    foundSongs.Add(s);
                }
            }

            return foundSongs;
        }

        public static Song FindSongByName(string name) 
        {
            Song song = null;

            foreach (Song s in songs) 
            {
                if(s.Name == name)
                {
                    song = s;break;
                }
            }

            return song;
        }


    }
}
