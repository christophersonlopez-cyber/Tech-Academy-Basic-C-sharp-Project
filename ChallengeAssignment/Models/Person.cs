namespace ChallengeAssignment.Models
{
    public class Person
    {   public DateTime currenttime { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string message { get; set; }
        public string fullname() {
            string full= Firstname + " " + Middlename + " " + Lastname;
            return (full);
        }
    }
}
