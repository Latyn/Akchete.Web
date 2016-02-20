using AK.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ak.ViewModels
{
    public class EventViewModel
    {
        [Required]
        [StringLength(255, MinimumLength = 5)]
        public string Name { get; set; }

        //[Required]
        //[EmailAddress]
        //public string Email { get; set; }

        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(1024, MinimumLength = 5)]
        public string Details { get; set; }
        
        public DateTime Created { get; set; }

        [Required]
        public DateTime EventDate { get; set; }
        
        public string ImageSource { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string MusicGender { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Place { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Longitude { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Latitude { get; set; }

        public ICollection<MusicGroup> Groups { get; set; }

    }
}