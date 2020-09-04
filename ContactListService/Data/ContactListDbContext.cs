using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContactListService.Models;

    public class ContactListDbContext : DbContext
    {
        public ContactListDbContext (DbContextOptions<ContactListDbContext> options)
            : base(options)
        {
        }

        public DbSet<ContactListService.Models.Contact> Contact { get; set; }
    }
