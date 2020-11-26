using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Data.SqlTypes;
using System.Linq;

namespace MyNotesLibrary.DAL.Context
{
    public class MyNotesContext : DbContext
    { 
        public MyNotesContext(DbContextOptions<MyNotesContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) { 

        } 
        public DbSet<Folder> Folders { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<User> Users { get; set; } 

    }
}
