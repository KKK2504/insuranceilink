using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PaymentAPI.Models;

public partial class PaymentDetailDbContext : DbContext
{
  

    public PaymentDetailDbContext(DbContextOptions<PaymentDetailDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PaymentDetail> PaymentDetails { get; set; }

    public virtual DbSet<User> Users { get; set; }

    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PaymentDetail>(entity =>
        {
            entity.Property(e => e.CardNumber).HasMaxLength(16);
            entity.Property(e => e.CardOwnerName).HasMaxLength(100);
            entity.Property(e => e.ExpirationDate).HasMaxLength(5);
            entity.Property(e => e.SecurityCode).HasMaxLength(3);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3213E83FC943CA8E");

            entity.ToTable("User");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CompanyId).HasColumnName("companyId");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(255)
                .HasColumnName("companyName");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .HasColumnName("customerName");
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("password");
            entity.Property(e => e.PolicyDetails).HasColumnName("policyDetails");
            entity.Property(e => e.Username)
                .HasMaxLength(255)
                .HasColumnName("username");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
