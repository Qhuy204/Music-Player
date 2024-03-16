using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer.DataAccess
{
    public class Song
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string ArtistName { get; set; }
        public int Duration { get; set; }
        public string Path { get; set; }
    }
}
