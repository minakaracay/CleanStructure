using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Domain.Entities
{
    public class AppUser
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string Email { get; set; } = default!;

        public string PasswordHash { get; set; } = default!;

        public string Role { get; set; } = "User";

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
