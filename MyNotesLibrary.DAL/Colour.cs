using System;
using System.Collections.Generic;
using System.Text;

namespace MyNotesLibrary.DAL
{
    public class Colour
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Hex { get; set; }
        public List<Note> Notes { get; set; }

    }
}
