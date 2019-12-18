using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SacramentMeetingPlanner.Models;

namespace SacramentMeetingPlanner.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MeetingContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Meetings.Any())
            {
                return;   // DB has been seeded
            }

            var Meetings = new Meeting[]
            {
                new Meeting
                {
                    MeetingDate = Convert.ToDateTime("2019-12-01"), Conductor = "Max Alonso", OpeningHymn = "2 - The Spirit of God", SacramentHymn = "193 - I Stand All Amazed",
                    ClosingHymn = "5 - High on the Mountain Top", OpeningPrayer = "Li Yan", ClosingPrayer = "Laura Norman"
                },
                new Meeting
                {
                    MeetingDate = Convert.ToDateTime("2019-12-08"), Conductor = "Max Alonso", OpeningHymn = "27 - Praise to the Man", SacramentHymn = "184 - Upon the Cross of Calvary",
                    ClosingHymn = "3 - Now Let Us Rejoice", OpeningPrayer = "Nino Olivetto", ClosingPrayer = "Peggy Justice"
                }
            };

            foreach (Meeting m in Meetings)
            {
                context.Meetings.Add(m);
            }
            context.SaveChanges();

            var Speakers = new Speaker[]
            {
            new Speaker{SpeakerName= "Joseph Smith",MeetingID=1,Topic="Atonement"},
            new Speaker{SpeakerName = "Russell Nelson",MeetingID=1,Topic="Repentance"},
            new Speaker{SpeakerName = "David Bednar",MeetingID=2,Topic="Faith"},
            new Speaker{SpeakerName = "Jeffrey Holland",MeetingID=2,Topic="Baptism"},
            };
            foreach (Speaker s in Speakers)
            {
                context.Speakers.Add(s);
            }
            context.SaveChanges();
        }
    }
}
