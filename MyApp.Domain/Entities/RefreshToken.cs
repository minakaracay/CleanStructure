using MyApp.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyApp.Domain.Entities
{
    public class RefreshToken : BaseEntity
    {
        public string Token { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public DateTime ExpireAt { get; set; }
        public bool IsRevoked { get; set; }
    }
}
