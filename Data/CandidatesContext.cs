using Microsoft.EntityFrameworkCore;
using Headhunter.Models;

namespace Headhunter.Data;

public class CandidatesContext : DbContext
{
    public DbSet<Candidate> Candidates { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<SkillSet> SkillSets { get; set; }
    public DbSet<Position> Positions { get; set; }
    
    public CandidatesContext(DbContextOptions<CandidatesContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Candidate>().HasKey(c => c.Id);
        modelBuilder.Entity<Company>().HasKey(c => c.Id);
        modelBuilder.Entity<SkillSet>().HasKey(s => s.Id);
        modelBuilder.Entity<Position>().HasKey(p => p.Id);

        modelBuilder.Entity<Candidate>()
            .HasMany(c => c.SkillSets)
            .WithOne()
            .HasForeignKey(s => s.CandidateId);

        modelBuilder.Entity<Company>()
            .HasMany(c => c.Positions)
            .WithOne()
            .HasForeignKey(p => p.CompanyId);

    }
}