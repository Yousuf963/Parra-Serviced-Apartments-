﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PSA_AB_YM_JS.Data;

#nullable disable

namespace PSA_AB_YM_JS.Migrations
{
    [DbContext(typeof(PSA_AB_YM_JSContext))]
    partial class PSA_AB_YM_JSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("PSA_AB_YM_JS.Model.Traveller", b =>
                {
                    b.Property<string>("email")
                        .HasColumnType("TEXT");

                    b.Property<string>("GivenName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Surname")
                        .HasColumnType("TEXT");

                    b.Property<string>("TheBookings")
                        .HasColumnType("TEXT");

                    b.Property<string>("postcode")
                        .HasColumnType("TEXT");

                    b.HasKey("email");

                    b.ToTable("Traveller");
                });
#pragma warning restore 612, 618
        }
    }
}
