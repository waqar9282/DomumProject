using System;
using System.Collections.Generic;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Context;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AbbMissingmng> AbbMissingmngs { get; set; }

    public virtual DbSet<AbscondingMissingType> AbscondingMissingTypes { get; set; }

    public virtual DbSet<AccidentType> AccidentTypes { get; set; }

    public virtual DbSet<Accidentmng> Accidentmngs { get; set; }

    public virtual DbSet<Correspondence> Correspondences { get; set; }

    public virtual DbSet<Doctype> Doctypes { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<HealthAppointment> HealthAppointments { get; set; }

    public virtual DbSet<Hsdocument> Hsdocuments { get; set; }

    public virtual DbSet<Incidentmng> Incidentmngs { get; set; }

    public virtual DbSet<Incidenttype> Incidenttypes { get; set; }

    public virtual DbSet<Institution> Institutions { get; set; }

    public virtual DbSet<ItemsSsd> ItemsSsds { get; set; }

    public virtual DbSet<Keyworkingsessiontype> Keyworkingsessiontypes { get; set; }

    public virtual DbSet<Lacpep> Lacpeps { get; set; }

    public virtual DbSet<LegalAppointment> LegalAppointments { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<LocationSsd> LocationSsds { get; set; }

    public virtual DbSet<LogReport> LogReports { get; set; }

    public virtual DbSet<Logtypetablesname> Logtypetablesnames { get; set; }

    public virtual DbSet<MedicalCheckup> MedicalCheckups { get; set; }

    public virtual DbSet<MedicationType> MedicationTypes { get; set; }

    public virtual DbSet<ObjRemark> ObjRemarks { get; set; }

    public virtual DbSet<PersonalHyginetype> PersonalHyginetypes { get; set; }

    public virtual DbSet<Plog> Plogs { get; set; }

    public virtual DbSet<Resident> Residents { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<SRemark> SRemarks { get; set; }

    public virtual DbSet<Selecttable> Selecttables { get; set; }

    public virtual DbSet<SessionDetail> SessionDetails { get; set; }

    public virtual DbSet<Spdietary> Spdietaries { get; set; }

    public virtual DbSet<Statehsd> Statehsds { get; set; }

    public virtual DbSet<StdReg> StdRegs { get; set; }

    public virtual DbSet<TblFile> TblFiles { get; set; }

    public virtual DbSet<UserDb> UserDbs { get; set; }

    public virtual DbSet<UserDbb> UserDbbs { get; set; }

    public virtual DbSet<UsrLog> UsrLogs { get; set; }

    public virtual DbSet<VisitsType> VisitsTypes { get; set; }

    public virtual DbSet<WishesType> WishesTypes { get; set; }

    public virtual DbSet<YmsGender> YmsGenders { get; set; }

    public virtual DbSet<Ymsaccesslevel> Ymsaccesslevels { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=constring");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AbbMissingmng>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AbscondingMissingType>(entity =>
        {
            entity.Property(e => e.Createdate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<AccidentType>(entity =>
        {
            entity.Property(e => e.Createdate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Accidentmng>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Correspondence>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Doctype>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Isactive).HasDefaultValue(true);
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Isactive).HasDefaultValue(true);
        });

        modelBuilder.Entity<Gender>(entity =>
        {
            entity.Property(e => e.Createdate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<HealthAppointment>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasDefaultValue(true);
        });

        modelBuilder.Entity<Hsdocument>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Isactive).HasDefaultValue(true);
        });

        modelBuilder.Entity<Incidentmng>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Incidenttype>(entity =>
        {
            entity.Property(e => e.Createdate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ItemsSsd>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Isactive).HasDefaultValue(true);
        });

        modelBuilder.Entity<Keyworkingsessiontype>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasDefaultValue(true);
        });

        modelBuilder.Entity<Lacpep>(entity =>
        {
            entity.Property(e => e.Date).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsActive).HasDefaultValue(true);
        });

        modelBuilder.Entity<LegalAppointment>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.Property(e => e.FCreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Fid).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LocationSsd>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Isactive).HasDefaultValue(true);
        });

        modelBuilder.Entity<LogReport>(entity =>
        {
            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.EditFlag).HasDefaultValue(0);
            entity.Property(e => e.EventDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Logtypetablesname>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MedicalCheckup>(entity =>
        {
            entity.Property(e => e.Createdate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<MedicationType>(entity =>
        {
            entity.Property(e => e.Createdate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ObjRemark>(entity =>
        {
            entity.Property(e => e.Sr).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<PersonalHyginetype>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Plog>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasDefaultValue(true);
        });

        modelBuilder.Entity<Resident>(entity =>
        {
            entity.Property(e => e.EditFlag).HasDefaultValue(false);
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.Property(e => e.Createdate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Occupied).HasDefaultValue(false);
            entity.Property(e => e.Rid).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<SRemark>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Selecttable>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Spdietary>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.Timestamp).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Statehsd>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Isactive).HasDefaultValue(true);
        });

        modelBuilder.Entity<StdReg>(entity =>
        {
            entity.Property(e => e.RecordCreatedDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.RecordCreatedate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<TblFile>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<UserDb>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<UserDbb>(entity =>
        {
            entity.HasKey(e => e.Eid).HasName("PK_User_db");

            entity.Property(e => e.CreatedDate).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<UsrLog>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<VisitsType>(entity =>
        {
            entity.Property(e => e.Createddate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WishesType>(entity =>
        {
            entity.Property(e => e.Createdate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<YmsGender>(entity =>
        {
            entity.Property(e => e.GcreateDate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Gid).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Ymsaccesslevel>(entity =>
        {
            entity.Property(e => e.Acreatedate).HasDefaultValueSql("(getdate())");
            entity.Property(e => e.Aid).ValueGeneratedOnAdd();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
