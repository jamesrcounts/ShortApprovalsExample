namespace ApprovalsExample
{
    using System;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;

    public class Event
    {
        public bool Announced { get; set; }

        public long Created { get; set; }

        public string Description { get; set; }

        public int Duration { get; set; }

        public string EventUrl { get; set; }

        public Group Group { get; set; }

        public int Headcount { get; set; }

        public string HowToFindUs { get; set; }

        public string Id { get; set; }

        public int MaybeRsvpCount { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public long Time { get; set; }

        public long Updated { get; set; }

        public int UtcOffset { get; set; }

        public Venue Venue { get; set; }

        public string Visibility { get; set; }

        public int WaitlistCount { get; set; }

        public int YesRsvpCount { get; set; }

        public static Event DeserializeJson(string source)
        {
            var text = Regex.Replace(source, @"\r?\n", Environment.NewLine);
            var o = JsonConvert.DeserializeObject<Event>(text);
            return o;
        }

        public override string ToString()
        {
            return string.Format("Announced: {0}, Created: {1}, Description: {2}, Duration: {3}, EventUrl: {4}, Group: {5}, HowToFindUs: {6}, Headcount: {7}, Id: {8}, MaybeRsvpCount: {9}, Name: {10}, Status: {11}, Time: {12}, Updated: {13}, UtcOffset: {14}, Venue: {15}, Visibility: {16}, WaitlistCount: {17}, YesRsvpCount: {18}", this.Announced, this.Created, this.Description, this.Duration, this.EventUrl, this.Group, this.HowToFindUs, this.Headcount, this.Id, this.MaybeRsvpCount, this.Name, this.Status, this.Time, this.Updated, this.UtcOffset, this.Venue, this.Visibility, this.WaitlistCount, this.YesRsvpCount);
        }
    }
}