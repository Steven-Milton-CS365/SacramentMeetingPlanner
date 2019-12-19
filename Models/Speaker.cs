using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; }

        public int MeetingID { get; set; }

        [Required]
        [Display(Name = "Speaker")]
        public string SpeakerName { get; set; }

        public string Topic { get; set; }

        public Meeting Meeting { get; set; }
    }
}
