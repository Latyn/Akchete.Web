using AK.Models;
using System;
using System.Collections.Generic;

namespace Ak.Models
{
    public class Event
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime EventDate{ get; set; }
        public string Details { get; set; }
        public string ImageSource { get; set; }
        public string MusicGender { get; set; }
        public string Place { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public ICollection <MusicGroup> Groups { get; set; }


    }
}