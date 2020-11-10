using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotesLibrary.DAL
{
    public class Note
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        private string Colour { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public int isPinned { get; set; }
        public string ContributerOrOwner { get; set; }
        public List<NoteUser> NoteUsers { get; set; }
        public Folder Folder { get; set; }
        public int FolderId { get; set; }

    }
}
