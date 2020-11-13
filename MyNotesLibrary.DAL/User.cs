﻿using System;
using System.Collections.Generic;

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
        public string Email { get; set; }
        public List<Note> Notes { get; set; }
        public List<Folder> Folders { get; set; } 
        public DateTime CreatedDate { get; set; }
    }
}
