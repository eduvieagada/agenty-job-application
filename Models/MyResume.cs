using LiteDB;

namespace AgentyApplication.Models
{
    public class MyResume
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Location { get; set; }
        public string[] Skills { get; set; }
        public int Experience { get; set; }
    }
}