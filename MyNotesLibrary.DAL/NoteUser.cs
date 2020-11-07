using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotesLibrary.DAL
{
    public class NoteUser
    {
        public User User { get; set; }
        public int UserId { get; set; }
        public Note Note { get; set; }
        public int NoteId { get; set; }

        


    }
}
