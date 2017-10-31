using StoredProcedure2.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StoredProcedure2.Models
{
    public class StoredProcedure2Context : DbContext
    {
        public StoredProcedure2Context() : base("name=StoredProcedure2Context")
        {
        }


        //public DbSet<City> Cities { get; set; }
        //public DbSet<State> States { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<Address> Address { get; set; }

        public DbSet<CustomerViewModel> CustomerViewModels { get; set; }


        //TODO: Mapping Stored Pocedure
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // modelBuilder.Entity<Customer>().MapToStoredProcedures();

            //modelBuilder.Entity<CustomerViewModel>().MapToStoredProcedures();
            modelBuilder.Entity<CustomerViewModel>()
                .Map(e =>
                {
                    e.ToTable("Address");
                    e.Properties(p => new { p.StateId, p.CityId, p.PermanentAddress });

                })
                .Map(e =>
                {
                    e.ToTable("Customers");
                    e.Properties(p => new { p.Name, p.Email });

                })

                .MapToStoredProcedures();

            base.OnModelCreating(modelBuilder);

            //#region <== City ==>

            //#region <== Table City ==>
            //modelBuilder.Entity<City>()
            //    .ToTable("Cities")
            //    .HasKey(t => t.Id);
            //#endregion

            //#region City Id
            //modelBuilder.Entity<City>()
            //    .Property(t => t.Id)
            //    .HasColumnName("Id")
            //    .HasColumnOrder(1)
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //#endregion

            //#region State Id
            //modelBuilder.Entity<City>()
            //    .Property(t => t.StateId)
            //    .HasColumnName("StateId")
            //    .HasColumnOrder(2);

            //#endregion

            //#region City Name
            //modelBuilder.Entity<City>()
            //    .Property(t => t.Name)
            //    .HasColumnName("Name")
            //    .HasMaxLength(100);
            //#endregion

            //#endregion



            //#region <== State ==>

            //#region <== Table State ==>
            //modelBuilder.Entity<State>()
            //    .ToTable("States")
            //    .HasKey(t => t.Id)
            //    .HasMany(t => t.City)
            //    .WithRequired(t => t.State)
            //    .HasForeignKey(t => t.StateId);
            //#endregion

            //#region State Id
            //modelBuilder.Entity<State>()
            //    .Property(t => t.Id)
            //    .HasColumnName("Id")
            //    .IsRequired()
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            //#endregion

            //#region State Name
            //modelBuilder.Entity<State>()
            //    .Property(t => t.Name)
            //    .HasColumnName("Name")
            //    .IsRequired()
            //    .HasMaxLength(100);
            //#endregion

            //#endregion



            //#region <== Address ==>


            //#region <== Table Address ==>
            //modelBuilder.Entity<Address>()
            //    .ToTable("Address")
            //    .HasEntitySetName("Address")
            //    .HasKey(t => t.Id);
            //#endregion


            //#region Id
            //modelBuilder.Entity<Address>()
            //    .Property(t => t.Id)
            //    .HasColumnName("Id")
            //    .IsRequired()
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            //#endregion

            //#region CustomerId
            //modelBuilder.Entity<Address>()
            //    .Property(t => t.CustomerId)
            //    .HasColumnName("CustomerId")
            //    .IsRequired();
            //#endregion

            //#region State Id
            //modelBuilder.Entity<Address>()
            //    .Property(t => t.StateId)
            //    .HasColumnName("StateId")
            //    .IsRequired();
            //#endregion

            //#region City Id
            //modelBuilder.Entity<Address>()
            //    .Property(t => t.CityId)
            //    .HasColumnName("CityId")
            //    .IsRequired();
            //#endregion


            //#endregion


            //#region <==Customer==>

            //#region <== Table Customer ==>
            //modelBuilder.Entity<Customer>()
            //    .ToTable("Customers")
            //    .HasKey(t => t.Id)
            //    .HasMany(t => t.Address)
            //    .WithRequired(t => t.Customer)//Foreign Key relation
            //    .HasForeignKey(f => f.CustomerId);//Foreign Key relation

            //#endregion

            //#region Id
            //modelBuilder.Entity<Customer>()
            //    .Property(t => t.Id)
            //    .HasColumnName("CustomerId")
            //    .IsRequired()
            //    .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            //#endregion

            //#region Name
            //modelBuilder.Entity<Customer>()
            //    .Property(t => t.Name)
            //    .HasColumnName("Name")
            //    .IsRequired()
            //    .HasMaxLength(50);

            //#endregion

            //#region Email
            //modelBuilder.Entity<Customer>()
            //    .Property(t => t.Email)
            //    .HasColumnName("Email")
            //    .IsRequired()
            //    .HasMaxLength(100);
            //#endregion


            //#endregion


        }



    }
}