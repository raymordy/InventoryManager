﻿// <auto-generated />
using System;
using Inventory.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Inventory.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Inventory.Data.Models.Address", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Country");

                    b.Property<string>("Line1")
                        .IsRequired();

                    b.Property<string>("Line2")
                        .IsRequired();

                    b.Property<string>("Line3");

                    b.Property<string>("Line4");

                    b.Property<string>("PostCode")
                        .IsRequired();

                    b.Property<Guid?>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Inventory.Data.Models.Asset", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssetTypeId");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<DateTime?>("PurchaseDate");

                    b.Property<Guid?>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("AssetTypeId");

                    b.HasIndex("VendorId");

                    b.ToTable("Assets");
                });

            modelBuilder.Entity("Inventory.Data.Models.LookupGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GroupDescription");

                    b.HasKey("Id");

                    b.ToTable("LookupGroups");
                });

            modelBuilder.Entity("Inventory.Data.Models.LookupType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<int?>("TypeLookupId");

                    b.HasKey("Id");

                    b.HasIndex("TypeLookupId");

                    b.ToTable("LookupTypes");
                });

            modelBuilder.Entity("Inventory.Data.Models.Renewal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("Invoice");

                    b.Property<decimal>("Net");

                    b.Property<DateTime>("PurchaseDate");

                    b.Property<string>("PurchaseOrder");

                    b.Property<int?>("RenewalTypeId");

                    b.Property<Guid?>("SoftwareLicenseId");

                    b.Property<DateTime?>("StartDate");

                    b.Property<Guid?>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("RenewalTypeId");

                    b.HasIndex("SoftwareLicenseId");

                    b.HasIndex("VendorId");

                    b.ToTable("Renewals");
                });

            modelBuilder.Entity("Inventory.Data.Models.SoftwareLicense", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<decimal>("Net");

                    b.Property<DateTime?>("PurchaseDate");

                    b.Property<int?>("TypeId");

                    b.Property<Guid?>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.HasIndex("VendorId");

                    b.ToTable("SoftwareLicenses");
                });

            modelBuilder.Entity("Inventory.Data.Models.Vendor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AccountManager");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("Inventory.Data.Models.Warranty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("AssetId");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("Expiration");

                    b.Property<decimal>("Net");

                    b.Property<DateTime?>("StartDate");

                    b.Property<Guid?>("VendorId");

                    b.HasKey("Id");

                    b.HasIndex("AssetId");

                    b.HasIndex("VendorId");

                    b.ToTable("Warranties");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Inventory.Data.Models.Address", b =>
                {
                    b.HasOne("Inventory.Data.Models.Vendor")
                        .WithMany("Locations")
                        .HasForeignKey("VendorId");
                });

            modelBuilder.Entity("Inventory.Data.Models.Asset", b =>
                {
                    b.HasOne("Inventory.Data.Models.LookupType", "AssetType")
                        .WithMany()
                        .HasForeignKey("AssetTypeId");

                    b.HasOne("Inventory.Data.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId");
                });

            modelBuilder.Entity("Inventory.Data.Models.LookupType", b =>
                {
                    b.HasOne("Inventory.Data.Models.LookupGroup", "TypeLookup")
                        .WithMany()
                        .HasForeignKey("TypeLookupId");
                });

            modelBuilder.Entity("Inventory.Data.Models.Renewal", b =>
                {
                    b.HasOne("Inventory.Data.Models.LookupType", "RenewalType")
                        .WithMany()
                        .HasForeignKey("RenewalTypeId");

                    b.HasOne("Inventory.Data.Models.SoftwareLicense")
                        .WithMany("Renewals")
                        .HasForeignKey("SoftwareLicenseId");

                    b.HasOne("Inventory.Data.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId");
                });

            modelBuilder.Entity("Inventory.Data.Models.SoftwareLicense", b =>
                {
                    b.HasOne("Inventory.Data.Models.LookupType", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.HasOne("Inventory.Data.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId");
                });

            modelBuilder.Entity("Inventory.Data.Models.Warranty", b =>
                {
                    b.HasOne("Inventory.Data.Models.Asset")
                        .WithMany("Warranties")
                        .HasForeignKey("AssetId");

                    b.HasOne("Inventory.Data.Models.Vendor", "Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
