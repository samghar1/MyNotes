using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace MyNotesLibrary.DAL
{
    [Table("Colour")]
    
    public class Colour
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(20)] 
        public string Name { get; set; }

        [Required, MaxLength(20)]
        public string Hex { get; set; }
        public List<Note> Notes { get; set; }

    }
}
