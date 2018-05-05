using issueTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace issueTracker.persistence
{
    public class IssueDbContext:DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options)
        :base(options)
        {
            
        }
        public DbSet<Category> Categories{get;set;}
        public DbSet<Creator> Creators{get;set;}
        public DbSet<Priority> Priorities{get;set;}
        public DbSet<Status> Statuses{get;set;}
        public DbSet<Issue> Issues{get;set;}
        
    }
}