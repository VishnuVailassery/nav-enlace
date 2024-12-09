﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SEO.Optimize.Postgres.Context;

#nullable disable

namespace SEO.Optimize.Postgres.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.CrawlInfo", b =>
                {
                    b.Property<int>("CrawlId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CrawlId"));

                    b.Property<DateTime>("CrawlDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("SiteId")
                        .HasColumnType("integer");

                    b.Property<int>("TotalExternalLinks")
                        .HasColumnType("integer");

                    b.Property<int>("TotalInternalLinks")
                        .HasColumnType("integer");

                    b.Property<int>("TotalOpportunities")
                        .HasColumnType("integer");

                    b.Property<int>("TotalPages")
                        .HasColumnType("integer");

                    b.HasKey("CrawlId");

                    b.HasIndex("SiteId");

                    b.ToTable("CrawlInfos");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("CompletedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("JobProperties")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SiteId")
                        .HasColumnType("integer");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.LinkDetail", b =>
                {
                    b.Property<int>("LinkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LinkId"));

                    b.Property<string>("AnchorText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("AnchorTextContainingText")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FieldKey")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsOpportunity")
                        .HasColumnType("boolean");

                    b.Property<string>("LinkType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("LinkUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NodeXPath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PageId")
                        .HasColumnType("integer");

                    b.HasKey("LinkId");

                    b.HasIndex("PageId");

                    b.ToTable("LinkDetails");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.PageInfo", b =>
                {
                    b.Property<int>("PageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PageId"));

                    b.Property<int>("CrawlId")
                        .HasColumnType("integer");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SiteId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)");

                    b.HasKey("PageId");

                    b.HasIndex("CrawlId");

                    b.HasIndex("SiteId");

                    b.ToTable("PageInfos");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.PageStats", b =>
                {
                    b.Property<int>("StatsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StatsId"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("ExternalLinkCount")
                        .HasColumnType("integer");

                    b.Property<int>("InternalLinkCount")
                        .HasColumnType("integer");

                    b.Property<int>("LinkOpportunityCount")
                        .HasColumnType("integer");

                    b.Property<int>("PageId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("StatsId");

                    b.HasIndex("PageId")
                        .IsUnique();

                    b.ToTable("PageStats");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.Site", b =>
                {
                    b.Property<int>("SiteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SiteId"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ExternalSiteId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("LastCrawledOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("SiteName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("SiteId");

                    b.HasIndex("UserId");

                    b.ToTable("Sites");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.Token", b =>
                {
                    b.Property<int>("TokenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TokenId"));

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("SiteId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("TokenExpiresAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("TokenType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TokenValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("TokenId");

                    b.HasIndex("SiteId");

                    b.ToTable("Tokens");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("UserId"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ExternalId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProfileImageUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Provider")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.CrawlInfo", b =>
                {
                    b.HasOne("SEO.Optimize.Postgres.Model.Site", "Site")
                        .WithMany("CrawlInfos")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Site");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.LinkDetail", b =>
                {
                    b.HasOne("SEO.Optimize.Postgres.Model.PageInfo", "PageInfo")
                        .WithMany("LinkDetails")
                        .HasForeignKey("PageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PageInfo");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.PageInfo", b =>
                {
                    b.HasOne("SEO.Optimize.Postgres.Model.CrawlInfo", "CrawlInfo")
                        .WithMany("PageInfos")
                        .HasForeignKey("CrawlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SEO.Optimize.Postgres.Model.Site", "Site")
                        .WithMany("PageInfos")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CrawlInfo");

                    b.Navigation("Site");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.PageStats", b =>
                {
                    b.HasOne("SEO.Optimize.Postgres.Model.PageInfo", "PageInfo")
                        .WithOne("PageStats")
                        .HasForeignKey("SEO.Optimize.Postgres.Model.PageStats", "PageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PageInfo");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.Site", b =>
                {
                    b.HasOne("SEO.Optimize.Postgres.Model.User", "User")
                        .WithMany("Sites")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.Token", b =>
                {
                    b.HasOne("SEO.Optimize.Postgres.Model.Site", "Site")
                        .WithMany("Tokens")
                        .HasForeignKey("SiteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Site");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.CrawlInfo", b =>
                {
                    b.Navigation("PageInfos");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.PageInfo", b =>
                {
                    b.Navigation("LinkDetails");

                    b.Navigation("PageStats")
                        .IsRequired();
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.Site", b =>
                {
                    b.Navigation("CrawlInfos");

                    b.Navigation("PageInfos");

                    b.Navigation("Tokens");
                });

            modelBuilder.Entity("SEO.Optimize.Postgres.Model.User", b =>
                {
                    b.Navigation("Sites");
                });
#pragma warning restore 612, 618
        }
    }
}
