﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurveyApp.Infrastructure.Data;

#nullable disable

namespace SurveyApp.Infrastructure.Migrations
{
    [DbContext(typeof(SurveyDbContext))]
    partial class SurveyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PollVote", b =>
                {
                    b.Property<int>("PollsId")
                        .HasColumnType("int");

                    b.Property<int>("VotesId")
                        .HasColumnType("int");

                    b.HasKey("PollsId", "VotesId");

                    b.HasIndex("VotesId");

                    b.ToTable("PollVote");
                });

            modelBuilder.Entity("SurveyApp.Entities.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PollId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionId")
                        .HasColumnType("int");

                    b.Property<int?>("VoteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("VoteId");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("SurveyApp.Entities.Poll", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Polls");
                });

            modelBuilder.Entity("SurveyApp.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PollId")
                        .HasColumnType("int");

                    b.Property<int?>("QuestionTypes")
                        .HasColumnType("int");

                    b.Property<int?>("VoteId")
                        .HasColumnType("int");

                    b.Property<int?>("VoteTypes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PollId");

                    b.HasIndex("VoteId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("SurveyApp.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SurveyApp.Entities.Vote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsSelected")
                        .HasColumnType("bit");

                    b.Property<int?>("QuestionTypes")
                        .HasColumnType("int");

                    b.Property<int?>("VoteTypes")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("PollVote", b =>
                {
                    b.HasOne("SurveyApp.Entities.Poll", null)
                        .WithMany()
                        .HasForeignKey("PollsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurveyApp.Entities.Vote", null)
                        .WithMany()
                        .HasForeignKey("VotesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SurveyApp.Entities.Option", b =>
                {
                    b.HasOne("SurveyApp.Entities.Poll", "Poll")
                        .WithMany()
                        .HasForeignKey("PollId");

                    b.HasOne("SurveyApp.Entities.Question", "Question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionId");

                    b.HasOne("SurveyApp.Entities.Vote", "Vote")
                        .WithMany()
                        .HasForeignKey("VoteId");

                    b.Navigation("Poll");

                    b.Navigation("Question");

                    b.Navigation("Vote");
                });

            modelBuilder.Entity("SurveyApp.Entities.Poll", b =>
                {
                    b.HasOne("SurveyApp.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("SurveyApp.Entities.Question", b =>
                {
                    b.HasOne("SurveyApp.Entities.Poll", "Poll")
                        .WithMany("Questions")
                        .HasForeignKey("PollId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SurveyApp.Entities.Vote", "Vote")
                        .WithMany("Questions")
                        .HasForeignKey("VoteId");

                    b.Navigation("Poll");

                    b.Navigation("Vote");
                });

            modelBuilder.Entity("SurveyApp.Entities.Poll", b =>
                {
                    b.Navigation("Questions");
                });

            modelBuilder.Entity("SurveyApp.Entities.Question", b =>
                {
                    b.Navigation("Options");
                });

            modelBuilder.Entity("SurveyApp.Entities.Vote", b =>
                {
                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
