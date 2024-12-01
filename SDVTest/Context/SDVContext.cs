using Microsoft.EntityFrameworkCore;
using SDVTest.Models;

namespace SDVTest.Context
{
    public class SDVContext : DbContext
    {
        public SDVContext(DbContextOptions<SDVContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<People>()
            .HasOne(x => x.Weapons)
            .WithMany(x => x.People)
            .HasForeignKey( x => x.IdWeaponEquiped)
            .OnDelete(DeleteBehavior.Restrict)
            .IsRequired();

            modelBuilder.Entity<People>()
          .HasOne(x => x.Professions)
          .WithMany(x => x.People)
          .HasForeignKey(x => x.IdProfession)
          .IsRequired();

            modelBuilder.Entity<Weapons>()
           .HasOne(x => x.Professions)
           .WithMany(x => x.Weapons)
           .HasForeignKey(x => x.IdProfession)
           .IsRequired();

            modelBuilder.Entity<People_Materia>()
            .HasOne(x => x.People)
            .WithMany(x => x.People_materia)
            .HasForeignKey(x => x.IdPeople);

            modelBuilder.Entity<People_Materia>()
           .HasOne(x => x.Materia)
           .WithMany(x => x.People_materia)
           .HasForeignKey(x => x.IdMateria);



            modelBuilder.Entity<Professions>().HasData(new Professions
            {
                Id = 1,
                Name = "SwordMaster"
            });

            modelBuilder.Entity<Professions>().HasData(new Professions
            {
                Id = 2,
                Name = "Pugilist"
            });
            modelBuilder.Entity<Vehicles>().HasData(new Vehicles
            {
                Id = 1,
                Name = "Car",
            });


            modelBuilder.Entity<Materia>().HasData(new Materia
            {
                Id = 1,
                Name = "Fire",
                lvl = 1,
                Description = "Throw Fire"
            });

            modelBuilder.Entity<Materia>().HasData(new Materia
            {
                Id = 2,
                Name = "Ice",
                lvl = 1,
                Description = "Throw Ice"
            });

            modelBuilder.Entity<Materia>().HasData(new Materia
            {
                Id = 3,
                Name = "Thunder",
                lvl = 1,
                Description = "Throw Thunder"
            });

            modelBuilder.Entity<Weapons>().HasData(new Weapons
            {
                Id = 1,
                Name = "Buster Sword",
                IdProfession = 1
            });

            modelBuilder.Entity<People>().HasData(new People
            {
                Id = 1,
                Name = "Cloud",
                Age = 31,
                IdWeaponEquiped = 1,
                IdProfession = 1
            });

            modelBuilder.Entity<People_Materia>().HasData(new People_Materia
            {
                Id = 1,
                IdMateria = 1,
                IdPeople = 1,
            });

            modelBuilder.Entity<People_Materia>().HasData(new People_Materia
            {
                Id = 2,
                IdMateria = 2,
                IdPeople = 1,
            });

            modelBuilder.Entity<People_Materia>().HasData(new People_Materia
            {
                Id = 3,
                IdMateria = 3,
                IdPeople = 1,
            });
        }

        public DbSet<People> Peoples { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Professions> Professions { get; set; }
        public DbSet<Weapons> Weapons { get; set; }
        public DbSet<Vehicles> Vehicles { get; set; }
        public DbSet<Enemies> Enemies { get; set; }

         public DbSet<People_Materia> peopleMateria { get; set; }


    }
}
