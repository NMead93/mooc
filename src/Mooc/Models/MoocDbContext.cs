using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Mooc.Models
{
    public class MoocDbContext : IdentityDbContext<AppUser>
    {
        public MoocDbContext(DbContextOptions options) : base(options)
        {

        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Mooc;integrated security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<AnswerChoice> AnswerChoices { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Module> Modules { get; set; }
        public DbSet<QuestionNode> QuestionNodes { get; set; }
        public DbSet<ReadingNode> ReadingNodes { get; set; }
        public DbSet<VideoNode> VideoNodes { get; set; }
        public DbSet<Subject> Subjects { get; set; }
    }
}