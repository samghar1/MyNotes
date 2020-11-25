using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyNotesLibrary.DAL
{
    [Table("UserNote")]
    public class UserNote
    { 
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public User User { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public Note Note { get; set; }

        [ForeignKey("Note")]
        public int NoteId { get; set; }

    }
}
