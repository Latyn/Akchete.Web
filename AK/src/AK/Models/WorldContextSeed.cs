using AK.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ak.Models
{
    public class WorldContextSeed
    {

        private WorldContext _context;

        public WorldContextSeed( WorldContext context)
        {
            _context = context;
        }

        public void EnsureSeedData()
        {
            if (!_context.Events.Any())
            {
                //Add new Data
                var newEvent = new Event()
                {
                    Place = "Pedregal",
                    Created = DateTime.Now,
                    EventDate = DateTime.Now,
                    Details = "This is a test to get a better idea about how the site is going to work",
                    Name = "Life in  Color",
                    ImageSource = "/Default.png",
                    MusicGender = "Electronic",
                    Longitude = "9°56'09.4\"N", 
                    Latitude = "84°05'47.5\"W",
                    Groups = new List<MusicGroup>()
                    {
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" }
                    }                 

                };
                _context.Events.Add(newEvent);
                _context.Groups.AddRange(newEvent.Groups);

                var newEvent1 = new Event()
                {
                    Place = "Bulevar Relax",
                    Created = DateTime.Now,
                    EventDate = DateTime.Now,
                    Details = "This is a test to get a better idea about how the site is going to work",
                    Name = "Trova Bulevar",
                    ImageSource = "/Default.png",
                    MusicGender = "Trova",
                    Longitude = "9°56'15.8\"N",
                    Latitude = "84°07'17.0\"W",
                    Groups = new List<MusicGroup>()
                    {
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" }
                    }

                };
                _context.Events.Add(newEvent1);
                _context.Groups.AddRange(newEvent1.Groups);

                var newEvent2 = new Event()
                {
                    Place = "Rumba",
                    Created = DateTime.Now,
                    EventDate = DateTime.Now,
                    Details = "This is a test to get a better idea about how the site is going to work",
                    Name = "Rumba Dance",
                    ImageSource = "/Default.png",
                    MusicGender = "Dancing",
                    Longitude = "9°56'15.8\"N",
                    Latitude = "84°07'17.0\"W",
                    Groups = new List<MusicGroup>()
                    {
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" }
                    }

                };
                _context.Events.Add(newEvent2);
                _context.Groups.AddRange(newEvent2.Groups);

                var newEvent3 = new Event()
                {
                    Place = "Balcon de Sabina",
                    Created = DateTime.Now,
                    EventDate = DateTime.Now,
                    Details = "This is a test to get a better idea about how the site is going to work",
                    Name = "Live Music",
                    ImageSource = "/Default.png",
                    MusicGender = "Electronic",
                    Longitude = "9°56'15.8\"N",
                    Latitude = "84°07'17.0\"W",
                    Groups = new List<MusicGroup>()
                    {
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" }
                    }

                };
                _context.Events.Add(newEvent3);
                _context.Groups.AddRange(newEvent3.Groups);

                var newEvent4 = new Event()
                {
                    Place = "Akchete",
                    Created = DateTime.Now,
                    EventDate = DateTime.Now,
                    Details = "This is a test to get a better idea about how the site is going to work",
                    Name = "Life as Now",
                    ImageSource = "/Default.png",
                    MusicGender = "Electronic",
                    Longitude = "9°56'15.8\"N",
                    Latitude = "84°07'17.0\"W",
                    Groups = new List<MusicGroup>()
                    {
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" }
                    }

                };
                _context.Events.Add(newEvent4);
                _context.Groups.AddRange(newEvent4.Groups);

                var newEvent5 = new Event()
                {
                    Place = "Estadio Nacional",
                    Created = DateTime.Now,
                    EventDate = DateTime.Now,
                    Details = "This is a test to get a better idea about how the site is going to work",
                    Name = "Iron Maiden",
                    ImageSource = "/Default.png",
                    MusicGender = "Rock",
                    Longitude = "9°56'15.8\"N",
                    Latitude = "84°07'17.0\"W",
                    Groups = new List<MusicGroup>()
                    {
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" }
                    }

                };
                _context.Events.Add(newEvent5);
                _context.Groups.AddRange(newEvent5.Groups);

                var newEvent6 = new Event()
                {
                    Place = "Vertigo",
                    Created = DateTime.Now,
                    EventDate = DateTime.Now,
                    Details = "This is a test to get a better idea about how the site is going to work",
                    Name = "Cafres",
                    ImageSource = "/Default.png",
                    MusicGender = "Roots",
                    Longitude = "9°56'15.8\"N",
                    Latitude = "84°07'17.0\"W",
                    Groups = new List<MusicGroup>()
                    {
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" },
                        new MusicGroup() { Description="Best Cr Group", Name = "Luis Ga y los Ajenos", SourceImage = "/DeafultGroup.png" }
                    }

                };
                _context.Events.Add(newEvent6);
                _context.Groups.AddRange(newEvent6.Groups);

                _context.SaveChanges();
            }
        }

    }
}