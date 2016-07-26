using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace grupparbete_mvc.Models
{
    public static class DataManager
    {
        private static Band b = new Band { Name = "Pink Floyd", Description = "A really good band." };
        private static List<Album> la = new List<Album> {
            new Album { Title="The Piper at the Gates of Dawn", Year=1967},
            new Album { Title="Ummagumma",Year=1969},
            new Album { Title="Animals",Year=1977},
            new Album { Title="The Wall",Year=1979}
        };
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
