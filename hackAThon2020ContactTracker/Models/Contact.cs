namespace hackAThon2020ContactTracker.Models
{
    public class Contact {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Time {get; set;}
        public bool? showingSymptoms { get; set; }
        public bool? livingWith { get; set; }
        public bool? isEmployer { get; set; }

    }
}