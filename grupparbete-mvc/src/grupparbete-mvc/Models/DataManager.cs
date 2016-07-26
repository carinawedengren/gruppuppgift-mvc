using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grupparbete_mvc.Models
{
    public static class DataManager
    {
        private static Band b;
        private static List<Album> la;

        static DataManager()
        {
            b = new Band { Name = "Pink Floyd", Description = "A really good band." };
            la = new List<Album>();
            Album a;

            a = new Album { Title = "The Piper at the Gates of Dawn", Year = 1967 };
            a.Tracks = new List<Track> {
                new Track { Name="Astronomy Domine", Length=new TimeSpan(0,4,12)},
                new Track { Name="Lucifer Sam",Length=new TimeSpan(0,3,07) }
            };
            la.Add(a);

            a = new Album { Title = "Ummagumma", Year = 1969 };
            a.Tracks = new List<Track> { };
            la.Add(a);

            a = new Album { Title = "Animals", Year = 1977 };
            a.Tracks = new List<Track> { };
            la.Add(a);

            a = new Album { Title = "The Wall", Year = 1979 };
            a.Tracks = new List<Track> { };
            la.Add(a);
        }
        public static Band GetBand()
        {
            return b;
        }
        public static List<Album> GetAlbums()
        {
            return la;
        }
    }
}
