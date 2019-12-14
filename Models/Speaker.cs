using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class Speaker
    {
        public int SpeakerID { get; set; } 
        public int MeetingID { get; set; }
        public int MemberID { get; set; }
        public string Topic { get; set; }

        public Meeting Meeting { get; set; }
        public Member Member { get; set; }
    }
}
