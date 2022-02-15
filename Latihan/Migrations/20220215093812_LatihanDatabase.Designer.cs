﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using latihan.vscode.web.Models;

namespace Latihan.Migrations
{
    [DbContext(typeof(latihanContext))]
    [Migration("20220215093812_LatihanDatabase")]
    partial class LatihanDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("latihan.vscode.web.Models.MMateri", b =>
                {
                    b.Property<int>("MateriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Materi_ID")
                        .UseIdentityColumn();

                    b.Property<string>("MateriDescription")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)")
                        .HasColumnName("Materi_Description");

                    b.Property<string>("MateriTitle")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("Materi_Title");

                    b.HasKey("MateriId");

                    b.ToTable("M_Materi");
                });

            modelBuilder.Entity("latihan.vscode.web.Models.MUser", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("userID")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("address");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("UserId");

                    b.ToTable("M_User");
                });
#pragma warning restore 612, 618
        }
    }
}
