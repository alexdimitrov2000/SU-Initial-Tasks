using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Track_Downloader
{
    class TrackDownloader
    {
        static void Main(string[] args)
        {
            string[] blacklistBands = Console.ReadLine().Split(' ');
            List<string> finalPlaylist = new List<string>();

            string song = Console.ReadLine();

            while (song != "end")
            {
                bool blacklistSong = false;
                for (int i = 0; i < blacklistBands.Length; i++)
                {
                    if (song.Contains(blacklistBands[i]))
                    {
                        blacklistSong = true;
                    }
                }

                if (!blacklistSong)
                {
                    finalPlaylist.Add(song);
                }
                song = Console.ReadLine();
            }

            finalPlaylist.Sort();
            Console.WriteLine();
            Console.WriteLine(string.Join("\r\n", finalPlaylist));
        }
    }
}
