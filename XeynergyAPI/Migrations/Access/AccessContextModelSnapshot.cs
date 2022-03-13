﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using XeynergyAPI.Contexts;

#nullable disable

namespace XeynergyAPI.Migrations.Access
{
    [DbContext(typeof(AccessContext))]
    partial class AccessContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("XeynergyAPI.Models.AccessRule", b =>
                {
                    b.Property<int>("AccessRuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AccessRuleId"), 1L, 1);

                    b.Property<bool>("Permission")
                        .HasColumnType("bit");

                    b.Property<string>("RuleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AccessRuleId");

                    b.ToTable("AccessRule");
                });

            modelBuilder.Entity("XeynergyAPI.Models.UserGroup", b =>
                {
                    b.Property<int>("UserGroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserGroupId"), 1L, 1);

                    b.Property<int>("AccessRuleRefId")
                        .HasColumnType("int");

                    b.Property<string>("GroupName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserGroupId");

                    b.HasIndex("AccessRuleRefId");

                    b.ToTable("UserGroup");
                });

            modelBuilder.Entity("XeynergyAPI.Models.UserGroup", b =>
                {
                    b.HasOne("XeynergyAPI.Models.AccessRule", "AccessRule")
                        .WithMany()
                        .HasForeignKey("AccessRuleRefId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AccessRule");
                });
#pragma warning restore 612, 618
        }
    }
}
