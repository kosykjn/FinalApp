using System;

namespace KosykFinalApp.Database.Models
{
    public class Admin : IAutorizedUser
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }

        public User User { get; set; }

        public Role Role => Role.Admin;
    }
}
