using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DatabaseTask.Models
{
    public partial class IntranetContext : DbContext
    {
        public IntranetContext()
        {
        }

        public IntranetContext(DbContextOptions<IntranetContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Access> Accesses { get; set; } = null!;
        public virtual DbSet<Branch> Branches { get; set; } = null!;
        public virtual DbSet<Child> Children { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<Contract> Contracts { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Department> Departments { get; set; } = null!;
        public virtual DbSet<DepartmentEmpolyee> DepartmentEmpolyees { get; set; } = null!;
        public virtual DbSet<DepartmentHead> DepartmentHeads { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<EmployeeAccess> EmployeeAccesses { get; set; } = null!;
        public virtual DbSet<EmpolyeeTitel> EmpolyeeTitels { get; set; } = null!;
        public virtual DbSet<HealtInspection> HealtInspections { get; set; } = null!;
        public virtual DbSet<Hint> Hints { get; set; } = null!;
        public virtual DbSet<JobTitel> JobTitels { get; set; } = null!;
        public virtual DbSet<PayoutType> PayoutTypes { get; set; } = null!;
        public virtual DbSet<Person> People { get; set; } = null!;
        public virtual DbSet<Recommentation> Recommentations { get; set; } = null!;
        public virtual DbSet<Rental> Rentals { get; set; } = null!;
        public virtual DbSet<RentalItem> RentalItems { get; set; } = null!;
        public virtual DbSet<Salary> Salaries { get; set; } = null!;
        public virtual DbSet<SalaryAccounting> SalaryAccountings { get; set; } = null!;
        public virtual DbSet<SickLeave> SickLeaves { get; set; } = null!;
        public virtual DbSet<Vacation> Vacations { get; set; } = null!;
        public virtual DbSet<VacationType> VacationTypes { get; set; } = null!;
        public virtual DbSet<WorkSchedule> WorkSchedules { get; set; } = null!;
        public virtual DbSet<training> training { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Intranet;Trusted_Connection=true;MultipleActiveResultSets=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Access>(entity =>
            {
                entity.Property(e => e.AccessId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.BranchId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Child>(entity =>
            {
                entity.Property(e => e.ChildId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.CompanyId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Contract>(entity =>
            {
                entity.Property(e => e.ContractId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.CountryId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.DepartmentId).ValueGeneratedNever();
            });

            modelBuilder.Entity<DepartmentEmpolyee>(entity =>
            {
                entity.HasKey(e => e.DepartmentEmployeeId)
                    .HasName("PK__Departme__CEECBC8A99157938");

                entity.Property(e => e.DepartmentEmployeeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<DepartmentHead>(entity =>
            {
                entity.Property(e => e.DepartmentHeadId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpolyeeId)
                    .HasName("PK__Employee__09B30BC94F073072");

                entity.Property(e => e.EmpolyeeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<EmployeeAccess>(entity =>
            {
                entity.Property(e => e.EmployeeAccessId).ValueGeneratedNever();
            });

            modelBuilder.Entity<EmpolyeeTitel>(entity =>
            {
                entity.Property(e => e.EmpolyeeTitelId).ValueGeneratedNever();
            });

            modelBuilder.Entity<HealtInspection>(entity =>
            {
                entity.Property(e => e.HealtInspectionId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Hint>(entity =>
            {
                entity.Property(e => e.HintId).ValueGeneratedNever();
            });

            modelBuilder.Entity<JobTitel>(entity =>
            {
                entity.Property(e => e.JobTitelId).ValueGeneratedNever();
            });

            modelBuilder.Entity<PayoutType>(entity =>
            {
                entity.HasKey(e => e.PayoutId)
                    .HasName("PK__PayoutTy__EFE8863A6574D85A");

                entity.Property(e => e.PayoutId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.Property(e => e.PersonId).ValueGeneratedNever();

                entity.Property(e => e.Gender).IsFixedLength();
            });

            modelBuilder.Entity<Recommentation>(entity =>
            {
                entity.HasKey(e => e.RecommentatioId)
                    .HasName("PK__Recommen__8105B783595E165C");

                entity.Property(e => e.RecommentatioId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Rental>(entity =>
            {
                entity.Property(e => e.RentalId).ValueGeneratedNever();
            });

            modelBuilder.Entity<RentalItem>(entity =>
            {
                entity.Property(e => e.RentalItemId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Salary>(entity =>
            {
                entity.Property(e => e.SalaryId).ValueGeneratedNever();
            });

            modelBuilder.Entity<SalaryAccounting>(entity =>
            {
                entity.Property(e => e.SalaryAccountingId).ValueGeneratedNever();
            });

            modelBuilder.Entity<SickLeave>(entity =>
            {
                entity.Property(e => e.SickLeaveId).ValueGeneratedNever();
            });

            modelBuilder.Entity<Vacation>(entity =>
            {
                entity.Property(e => e.VacationId).ValueGeneratedNever();
            });

            modelBuilder.Entity<VacationType>(entity =>
            {
                entity.Property(e => e.VacationTypeId).ValueGeneratedNever();
            });

            modelBuilder.Entity<WorkSchedule>(entity =>
            {
                entity.Property(e => e.WorkScheduleId).ValueGeneratedNever();
            });

            modelBuilder.Entity<training>(entity =>
            {
                entity.Property(e => e.TrainingId).ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
