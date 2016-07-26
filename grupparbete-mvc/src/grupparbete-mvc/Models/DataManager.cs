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
                new Track { Name="Lucifer Sam",Length=new TimeSpan(0,3,07) },
                new Track {Name="Matilda Mother",Length= new TimeSpan(0,3,8) },
                new Track {Name="Flaming",Length= new TimeSpan(0,2,46) },
                new Track {Name="Pow R. Toc h.",Length= new TimeSpan(0,4,26) },
                new Track {Name="Take Up Thy Stethoscope and Walk",Length= new TimeSpan(0,3,5) },
                new Track {Name="Interstellar Overdrive",Length= new TimeSpan(0,9,41) },
                new Track {Name="The Gnome",Length= new TimeSpan(0,2,13) },
                new Track {Name="Chapter 24",Length= new TimeSpan(0,3,42) },
                new Track {Name="The Scarecrow",Length= new TimeSpan(0,2,11) },
                new Track {Name="Bike",Length= new TimeSpan(0,3,21) }
            };
            la.Add(a);

            a = new Album { Title = "Ummagumma", Year = 1969 };
            a.Tracks = new List<Track> {
                new Track { Name="Astronomy Domine", Length=new TimeSpan(0,8,29)},
                new Track { Name="Careful with That Axe, Eugene", Length=new TimeSpan(0,8,50)},
                new Track { Name="Set the Controls for the Heart of the Sun", Length=new TimeSpan(0,9,26)},
                new Track { Name="A Saucerful of Secrets", Length=new TimeSpan(0,12,48)},
                new Track { Name="Sysyphus (Part 1)", Length=new TimeSpan(0,1,8)},
                new Track { Name="Sysyphus (Part 2)", Length=new TimeSpan(0,3,30)},
                new Track { Name="Sysyphus (Part 3)", Length=new TimeSpan(0,1,49)},
                new Track { Name="Sysyphus (Part 4)", Length=new TimeSpan(0,6,59)},
                new Track { Name="Grantchester Meadows", Length=new TimeSpan(0,7,19)},
                new Track { Name="Several Species of Small Furry Animals Gathered Together in a Cave and Grooving with a Pict", Length=new TimeSpan(0,5,1)},
                new Track { Name="The Narrow Way (Part 1)", Length=new TimeSpan(0,3,25)},
                new Track { Name="The Narrow Way (Part 2)", Length=new TimeSpan(0,2,54)},
                new Track { Name="The Narrow Way (Part 3)", Length=new TimeSpan(0,5,51)},
                new Track { Name="The Grand Vizier's Garden Party (Part 1:Entrance)", Length=new TimeSpan(0,1,0)},
                new Track { Name="The Grand Vizier's Garden Party (Part 2 Entertainment)", Length=new TimeSpan(0,7,6)},
                new Track { Name="The Grand Vizier's Garden Party (Part 3:Exit)", Length=new TimeSpan(0,0,38)},

            };
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
