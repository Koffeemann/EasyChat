using EasyChat.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChat
{
    public class AppDBContext : IdentityDbContext
    {
      

        public AppDBContext(DbContextOptions<AppDBContext> options)
              : base(options)
        {
        }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
