namespace ApprovalsExample
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Describe a JSON parser.
    /// </summary>
    [TestClass]
    public class JsonParserTest
    {
        /// <summary>
        /// Parse this JSON into a POCO object.
        /// </summary>
        [TestMethod]
        public void ItConvertsJsonToPoco()
        {
            const string Source = @"{
            ""status"": ""upcoming"",
            ""visibility"": ""public"",
            ""maybe_rsvp_count"": 0,
            ""venue"": {
                ""id"": 11835602,
                ""zip"": ""92660"",
                ""lon"": -117.867828,
                ""repinned"": false,
                ""name"": ""TEKsystems"",
                ""state"": ""CA"",
                ""address_1"": ""100 Bayview Circle #3400"",
                ""lat"": 33.655819,
                ""city"": ""Newport Beach"",
                ""country"": ""us""
            },
            ""id"": ""124139172"",
            ""utc_offset"": -25200000,
            ""duration"": 10800000,
            ""time"": 1378947600000,
            ""waitlist_count"": 0,
            ""announced"": false,
            ""updated"": 1370985561000,
            ""yes_rsvp_count"": 7,
            ""created"": 1370985561000,
            ""event_url"": ""http://www.meetup.com/vNext-OrangeCounty/events/124139172/"",
            ""description"": ""<p><strong>Talk Info :</strong></p>\n<p>The techniques for building applications have changed dramatically in the last <br />\n\nfew years. Gone are the days of single-tier, battle-ship gray, boring user <br />\n\ninterfaces. Users demand that your applications (or portions) run on more than <br />\n\none device. This session will take you on a tour of how you should be architecting your application by breaking it up into services. You will learn how <br />\n\nto create your business rules and data layer as a service. This seminar will <br />\n\nassume you have some knowledge of .NET but have been developing <br />\n\napplications the old way and you are now looking to see how to use WCF and <br />\n\nthe Model-View-View-Model (MVVM) design pattern to create applications that <br />\n\ncan be run one more than one user interface platform. This session has many <br />\n\ndemonstrations and you will be led step-by-step through the code. You will walk <br />\n\naway with a sample set of services that run on Silverlight, Windows Forms, <br />\n\nWPF, Windows Phone and ASP.NET.</p>\n<p> </p>\n<p><strong>About The Speaker</strong></p>\n<p>Paul D. Sheriff is the President of PDSA, Inc. (www.pdsa.com), a Microsoft <br />\n\nPartner in Southern California. Paul acts as the Microsoft Regional Director for <br />\n\nSouthern California assisting the local Microsoft offices with several of their <br />\n\nevents each year and being an evangelist for them. Paul has authored literally <br />\n\nhundreds of books, webcasts, videos and articles on .NET, WPF, Silverlight, <br />\n\nWindows Phone and SQL Server. Paul can be reached via email at <br />\n\nPSheriff@pdsa.com. Check out Paul's new code generator 'Haystack' at <br />\n\n<a href=\""http://www.CodeHaystack.com\"">www.CodeHaystack.com</a>.</p>"",
            ""how_to_find_us"": ""Office is on the 3rd floor of the North Tower - Occupied by TekSystems"",
            ""name"": ""Paul D. Sheriff - Architecting Applications for Multiple User Interfaces"",
            ""headcount"": 0,
            ""group"": {
                ""id"": 2983232,
                ""group_lat"": 33.650001525878906,
                ""name"": ""vNext_OC"",
                ""group_lon"": -117.58999633789062,
                ""join_mode"": ""open"",
                ""urlname"": ""vNext-OrangeCounty"",
                ""who"": ""Members""
            }
        }";

            var o = Event.DeserializeJson(Source);
            const string Answer = @"Announced: False, Created: 1370985561000, Description: <p><strong>Talk Info :</strong></p>
<p>The techniques for building applications have changed dramatically in the last <br />

few years. Gone are the days of single-tier, battle-ship gray, boring user <br />

interfaces. Users demand that your applications (or portions) run on more than <br />

one device. This session will take you on a tour of how you should be architecting your application by breaking it up into services. You will learn how <br />

to create your business rules and data layer as a service. This seminar will <br />

assume you have some knowledge of .NET but have been developing <br />

applications the old way and you are now looking to see how to use WCF and <br />

the Model-View-View-Model (MVVM) design pattern to create applications that <br />

can be run one more than one user interface platform. This session has many <br />

demonstrations and you will be led step-by-step through the code. You will walk <br />

away with a sample set of services that run on Silverlight, Windows Forms, <br />

WPF, Windows Phone and ASP.NET.</p>
<p> </p>
<p><strong>About The Speaker</strong></p>
<p>Paul D. Sheriff is the President of PDSA, Inc. (www.pdsa.com), a Microsoft <br />

Partner in Southern California. Paul acts as the Microsoft Regional Director for <br />

Southern California assisting the local Microsoft offices with several of their <br />

events each year and being an evangelist for them. Paul has authored literally <br />

hundreds of books, webcasts, videos and articles on .NET, WPF, Silverlight, <br />

Windows Phone and SQL Server. Paul can be reached via email at <br />

PSheriff@pdsa.com. Check out Paul's new code generator 'Haystack' at <br />

<a href=""http://www.CodeHaystack.com"">www.CodeHaystack.com</a>.</p>, Duration: 10800000, EventUrl: , Group: ApprovalsExample.Group, HowToFindUs: , Headcount: 0, Id: 124139172, MaybeRsvpCount: 0, Name: Paul D. Sheriff - Architecting Applications for Multiple User Interfaces, Status: upcoming, Time: 1378947600000, Updated: 1370985561000, UtcOffset: 0, Venue: ApprovalsExample.Venue, Visibility: public, WaitlistCount: 0, YesRsvpCount: 0";
            Assert.AreEqual(Answer, o.ToString());
        }
    }
}