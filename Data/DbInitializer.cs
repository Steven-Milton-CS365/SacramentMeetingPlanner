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

            var Members = new Member[]
            {
            new Member{FirstName="Carson",LastName="Alexander"},
            new Member{FirstName="Meredith",LastName="Alonso"},
            new Member{FirstName="Arturo",LastName="Anand"},
            new Member{FirstName="Gytis",LastName="Barzdukas"},
            new Member{FirstName="Yan",LastName="Li"},
            new Member{FirstName="Peggy",LastName="Justice"},
            new Member{FirstName="Laura",LastName="Norman"},
            new Member{FirstName="Nino",LastName="Olivetto"}
            };
            foreach (Member m in Members)
            {
                context.Members.Add(m);
            }
            context.SaveChanges();

            var Hymns = new Hymn[]
            {
            new Hymn{HymnNo=1,Title="The Morning Breaks"},
            new Hymn{HymnNo=2,Title="The Spirit of God"},
            new Hymn{HymnNo=3,Title="Now Let Us Rejoice"},
            new Hymn{HymnNo=5,Title="High on the Mountain Top"},
            new Hymn{HymnNo=27,Title="Praise to the Man"},
            new Hymn{HymnNo=184,Title="Upon the Cross of Calvary"},
            new Hymn{HymnNo=193,Title="I Stand All Amazed"}
            };
            foreach (Hymn h in Hymns)
            {
                context.Hymns.Add(h);
            }
            context.SaveChanges();

            var Meetings = new Meeting[]
            {
                new Meeting
                {
                    MeetingDate = Convert.ToDateTime("2019-12-01"), Conductor = 1, OpeningHymn = 2, SacramentHymn = 6,
                    ClosingHymn = 3, OpeningPrayer = 4, ClosingPrayer = 6
                },
                new Meeting
                {
                    MeetingDate = Convert.ToDateTime("2019-12-08"), Conductor = 1, OpeningHymn = 4, SacramentHymn = 7,
                    ClosingHymn = 1, OpeningPrayer = 6, ClosingPrayer = 7
                }
            };

            foreach (Meeting m in Meetings)
            {
                context.Meetings.Add(m);
            }
            context.SaveChanges();

            var Speakers = new Speaker[]
            {
            new Speaker{MemberID=1,MeetingID=1,Topic="Atonement"},
            new Speaker{MemberID=2,MeetingID=1,Topic="Repentance"},
            new Speaker{MemberID=3,MeetingID=2,Topic="Faith"},
            new Speaker{MemberID=4,MeetingID=2,Topic="Baptism"},
            };
            foreach (Speaker s in Speakers)
            {
                context.Speakers.Add(s);
            }
            context.SaveChanges();
        }
    }
}
