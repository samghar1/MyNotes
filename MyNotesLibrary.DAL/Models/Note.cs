using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyNotesLibrary.DAL
{
    [Table("Note")]
    public class Note
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required,MaxLength(50)]
        public string Title { get; set; }

        [Required]
        public string Body { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public DateTime? DeletedDate { get; set; }

        [Required]
        public bool IsDeleted { get; set; }

        [Required]
        public bool isPinned { get; set; }

        [Required]
        public bool isArchived { get; set; }

        [Required]
        public List<UserNote> UserNotes { get; set; }
        public Folder Folder { get; set; }

        [Required]
        [ForeignKey("Folder")]
        public int FolderId { get; set; }
        public Colour Colour { get; set; }

        [ForeignKey("Colour")]
        public int ColourId { get; set; } 

    }
}
