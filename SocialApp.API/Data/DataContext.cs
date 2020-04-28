
using Microsoft.EntityFrameworkCore;
using SocialApp.API.Models;

namespace SocialApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) { }
        public DbSet<Value> Values {get; set;} 
        public DbSet<User> Users {get;set;}
    // this (Values) represent the table name gonna be in the Database
    // and Value represent the class defined in the Models folder
    }
} 