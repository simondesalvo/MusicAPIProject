using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicAPIProject.Models
{


    public class MusicObject
    {
        public Music[] data { get; set; }
        public int total { get; set; }
        public string prev { get; set; }
        public string next { get; set; }
    }

    public class Music
    {
        public int id { get; set; }
        public bool readable { get; set; }
        public string title { get; set; }
        public string link { get; set; }
        public string preview { get; set; }
        public Artist artist { get; set; }
        public Album album { get; set; }
        public string type { get; set; }
    }

    public class Artist
    {
        public int id { get; set; }
        public string name { get; set; }
        public string link { get; set; }
        public string picture_small { get; set; }
        public string tracklist { get; set; }
    }

    public class Album
    {
        public int id { get; set; }
        public string title { get; set; }
        public string cover_small { get; set; }
        public string tracklist { get; set; }
    }


}
