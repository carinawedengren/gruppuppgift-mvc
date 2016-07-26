using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grupparbete_mvc.Models
{
    public class Album
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<Track> Tracks { get; set; }
        public TimeSpan Length
        {
            get
            {
                TimeSpan t = new TimeSpan(0);
                foreach (var track in Tracks)
                {
                    t += track.Length;
                }
                return t;
            }
        }
    }
}
