using CV.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CV.Api.Data;

public class CvDbContext : DbContext
{
    public CvDbContext(DbContextOptions<CvDbContext> options ) : base(options)
    {
        
    }
    
    public DbSet<Project> Projects { get; set; }

    public DbSet<ContactInformation> ContactInformations { get; set; }
    
}