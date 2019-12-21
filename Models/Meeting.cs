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

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name ="Meeting Date")]
        public DateTime MeetingDate { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Conductor { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name="Opening Hymn")]
        public string OpeningHymn { get; set; }

        [Required]
        [Display(Name = "Invocation")]
        [StringLength(60, MinimumLength = 3)]
        public string OpeningPrayer { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Intermediate Hymn")]
        public string IntermediateHymn { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Closing Hymn")]
        public string ClosingHymn { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        [Display(Name = "Benediction")]
        public string ClosingPrayer { get; set; }
        public ICollection<Speaker> Speakers { get; set; }
    }
}
