using Microsoft.VisualBasic;

namespace login.Models
{
    public class UserData
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public DateTime Joining { get; set; }
       
        public string Manager { get; set; }
    }
}
