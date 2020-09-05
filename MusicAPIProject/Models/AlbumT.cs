using System;
using System.Collections.Generic;

namespace MusicAPIProject.Models
{
    public partial class AlbumT
    {
        public int Pid { get; set; }
        public int Apiid { get; set; }
        public string UserId { get; set; }

        public virtual AspNetUsers User { get; set; }
    }
}
