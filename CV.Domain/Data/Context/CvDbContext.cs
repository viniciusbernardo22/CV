using CV.Domain.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace CV.Domain.Data.Context;

public class CvDbContext(DbContextOptions<CvDbContext> options) : DbContext(options)
{
    public DbSet<Project> Projects { get; set; }

    public DbSet<ContactInformation> ContactInformations { get; set; }
    
    public DbSet<Typer> Typers { get; set; }
    
    public DbSet<Experience> Experiences { get; set; }
}