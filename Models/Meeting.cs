using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SacramentMeetingPlanner.Models
{
    public class Meeting
    {
        public int ID { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Column("Meeting Date")]
        public DateTime MeetingDate { get; set; }
        public int Conductor { get; set; }
        [Column("Opening Hymn")]
        public int OpeningHymn { get; set; }
        [Column("Sacrament Hymn")]
        public int OpeningPrayer { get; set; }
        public int SacramentHymn { get; set; }
        [Column("Intermediate Hymn")]
        [StringLengthAttribute(75)]
        public string IntermediateHymn { get; set; }
        [Column("Closing Hymn")]
        public int ClosingHymn { get; set; }
        [Column("Closing Prayer")]
        
        public int ClosingPrayer { get; set; }
        public ICollection<Speaker> Speakers { get; set; }
    }
}
