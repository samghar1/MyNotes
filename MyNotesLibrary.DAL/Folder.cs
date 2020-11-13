using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyNotesLibrary.DAL
{
    public class Folder
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public List<Note> Notes { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }

    }
}
