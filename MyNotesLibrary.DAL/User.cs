using System;

namespace MyNotesLibrary.DAL
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Email { get; set; }
    }
}
