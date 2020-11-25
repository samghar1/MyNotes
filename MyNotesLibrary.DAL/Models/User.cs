using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNotesLibrary.DAL
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,MaxLength(40)]
        public string FirstName { get; set; }

        [Required, MaxLength(40)]
        public string LastName { get; set; }

        [Required, MaxLength(14)]
        private string Username { get; set; }

        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        [Required, MaxLength(30)]
        private string Password { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required, MaxLength(30)]
        public string Email { get; set; }
        public List<UserNote> UserNotes { get; set; }
        public List<Folder> Folders { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; } 
        }
         

    }

