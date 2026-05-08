using LoginNexus.Models;

namespace LoginNexus.Services
{
    public class AuthService
    {
        private readonly List<User> _users = new()
    {
        new User { Email = "daniel@nexus.edu", Password = "123", Role = "Professor", Name = "Dr. Paiva" },
        new User { Email = "maycon@nexus.edu", Password = "123", Role = "Student", Name = "maycon" }
    };

        public User? Authenticate(string email, string password)
        {
            return _users.FirstOrDefault(u => u.Email == email && u.Password == password);
        }
    }
}