using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MyNotesLibrary.DAL.Context
{
    public class MyNotesContext : DbContext
    {
        public MyNotesContext(DbContextOptions<MyNotesContext> options) : base(options)
        {

        }
        public DbSet<Colour> Colours { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserNote> UserNotes { get; set; }

    }
}
