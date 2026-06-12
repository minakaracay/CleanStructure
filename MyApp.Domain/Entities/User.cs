using MyApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Domain.Entities
{
    public class User:BaseEntity
    {

        public string FirstName { get; set; } = default!;

        public string LastName { get; set; } = default!;

        public string Email { get; set; } = default!;

        public string PasswordHash { get; set; } = default!;

        public ICollection<UserRole> UserRoles { get; set; } = new List<UserRole>();

    }
}
