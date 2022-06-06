using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using complaint_tr.Areas.Identity.Data;
using complaint_tr.Models;
namespace complaint_tr.Data;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public DbSet<Complaint> Complaints { get; set; }
    public DbSet<Notification> Notifications { get; set; }
    public DbSet<Petition> Petitions { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}