using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Baseball.ApiSharp.Data.Lahman;

namespace Baseball.ApiSharp.Dal.EfStructures
{
    public partial class LahmansDbContext : DbContext
    {
        /*
        public LahmansDbContext()
        {
        }
        */

        public LahmansDbContext(DbContextOptions<LahmansDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Allstarfull> Allstarfulls { get; set; }
        public virtual DbSet<Appearance> Appearances { get; set; }
        public virtual DbSet<Awardsmanager> Awardsmanagers { get; set; }
        public virtual DbSet<Awardsplayer> Awardsplayers { get; set; }
        public virtual DbSet<Awardssharemanager> Awardssharemanagers { get; set; }
        public virtual DbSet<Awardsshareplayer> Awardsshareplayers { get; set; }
        public virtual DbSet<Batting> Batting { get; set; }
        public virtual DbSet<Battingpost> Battingposts { get; set; }
        public virtual DbSet<Collegeplaying> Collegeplayings { get; set; }
        public virtual DbSet<Division> Divisions { get; set; }
        public virtual DbSet<Efmigrationshistory> Efmigrationshistories { get; set; }
        public virtual DbSet<Fielding> Fielding { get; set; }
        public virtual DbSet<Fieldingof> Fieldingofs { get; set; }
        public virtual DbSet<Fieldingofsplit> Fieldingofsplits { get; set; }
        public virtual DbSet<Fieldingpost> Fieldingposts { get; set; }
        public virtual DbSet<Halloffame> Halloffames { get; set; }
        public virtual DbSet<Homegame> Homegames { get; set; }
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Managershalf> Managershalves { get; set; }
        public virtual DbSet<Park> Parks { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Pitching> Pitching { get; set; }
        public virtual DbSet<Pitchingpost> Pitchingposts { get; set; }
        public virtual DbSet<Richjsontagdatum> Richjsontagdata { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Tag> Tags2 { get; set; }
        public virtual DbSet<Tagrelationship> Tagrelationships { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<Teamsfranchise> Teamsfranchises { get; set; }
        public virtual DbSet<Teamshalf> Teamshalves { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("server=localhost;database=LahmansOBH;uid=root;pwd=MiSs-8v0r$", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.27-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<Allstarfull>(entity =>
            {
                entity.ToTable("allstarfull");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => new { e.PlayerId, e.YearId, e.GameNum, e.GameId, e.LgId }, "playerID")
                    .IsUnique();

                entity.HasIndex(e => e.TeamId1, "team_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GameId)
                    .HasMaxLength(12)
                    .HasColumnName("gameID");

                entity.Property(e => e.GameNum).HasColumnName("gameNum");

                entity.Property(e => e.Gp).HasColumnName("GP");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.StartingPos).HasColumnName("startingPos");

                entity.Property(e => e.TeamId)
                    .HasMaxLength(3)
                    .HasColumnName("teamID")
                    .IsFixedLength();

                entity.Property(e => e.TeamId1).HasColumnName("team_ID");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Allstarfulls)
                    .HasForeignKey(d => d.LgId)
                    .HasConstraintName("allstarfull_ibfk_1");

                entity.HasOne(d => d.TeamId1Navigation)
                    .WithMany(p => p.Allstarfulls)
                    .HasForeignKey(d => d.TeamId1)
                    .HasConstraintName("allstarfull_ibfk_2");
            });

            modelBuilder.Entity<Appearance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("appearances");

                entity.HasIndex(e => new { e.Id, e.YearId, e.TeamId, e.PlayerId }, "comp_indx");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => e.PlayerId, "playerID");

                entity.HasIndex(e => e.TeamId1, "team_ID");

                entity.Property(e => e.G1b).HasColumnName("G_1b");

                entity.Property(e => e.G2b).HasColumnName("G_2b");

                entity.Property(e => e.G3b).HasColumnName("G_3b");

                entity.Property(e => e.GAll).HasColumnName("G_all");

                entity.Property(e => e.GBatting).HasColumnName("G_batting");

                entity.Property(e => e.GC).HasColumnName("G_c");

                entity.Property(e => e.GCf).HasColumnName("G_cf");

                entity.Property(e => e.GDefense).HasColumnName("G_defense");

                entity.Property(e => e.GDh).HasColumnName("G_dh");

                entity.Property(e => e.GLf).HasColumnName("G_lf");

                entity.Property(e => e.GOf).HasColumnName("G_of");

                entity.Property(e => e.GP).HasColumnName("G_p");

                entity.Property(e => e.GPh).HasColumnName("G_ph");

                entity.Property(e => e.GPr).HasColumnName("G_pr");

                entity.Property(e => e.GRf).HasColumnName("G_rf");

                entity.Property(e => e.GSs).HasColumnName("G_ss");

                entity.Property(e => e.Gs).HasColumnName("GS");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("teamID")
                    .IsFixedLength();

                entity.Property(e => e.TeamId1).HasColumnName("team_ID");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.Lg)
                    .WithMany()
                    .HasForeignKey(d => d.LgId)
                    .HasConstraintName("appearances_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany()
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("appearances_ibfk_3");

                entity.HasOne(d => d.TeamId1Navigation)
                    .WithMany()
                    .HasForeignKey(d => d.TeamId1)
                    .HasConstraintName("appearances_ibfk_2");
            });

            modelBuilder.Entity<Awardsmanager>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("awardsmanagers");

                entity.HasIndex(e => new { e.Id, e.PlayerId, e.AwardId, e.YearId }, "comp_indx");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => e.PlayerId, "playerID");

                entity.Property(e => e.AwardId)
                    .IsRequired()
                    .HasMaxLength(75)
                    .HasColumnName("awardID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LgId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .HasColumnName("notes");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("playerID");

                entity.Property(e => e.Tie)
                    .HasMaxLength(1)
                    .HasColumnName("tie");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.Lg)
                    .WithMany()
                    .HasForeignKey(d => d.LgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("awardsmanagers_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany()
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("awardsmanagers_ibfk_2");
            });

            modelBuilder.Entity<Awardsplayer>(entity =>
            {
                entity.ToTable("awardsplayers");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => new { e.PlayerId, e.AwardId, e.YearId, e.LgId }, "playerID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AwardId)
                    .IsRequired()
                    .HasColumnName("awardID");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.Notes)
                    .HasMaxLength(100)
                    .HasColumnName("notes");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.Tie)
                    .HasMaxLength(1)
                    .HasColumnName("tie");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Awardsplayers)
                    .HasForeignKey(d => d.LgId)
                    .HasConstraintName("awardsplayers_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Awardsplayers)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("awardsplayers_ibfk_2");
            });

            modelBuilder.Entity<Awardssharemanager>(entity =>
            {
                entity.ToTable("awardssharemanagers");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => new { e.PlayerId, e.AwardId, e.YearId, e.LgId }, "playerID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AwardId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("awardID");

                entity.Property(e => e.LgId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("playerID");

                entity.Property(e => e.PointsMax).HasColumnName("pointsMax");

                entity.Property(e => e.PointsWon).HasColumnName("pointsWon");

                entity.Property(e => e.VotesFirst).HasColumnName("votesFirst");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Awardssharemanagers)
                    .HasForeignKey(d => d.LgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("awardssharemanagers_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Awardssharemanagers)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("awardssharemanagers_ibfk_2");
            });

            modelBuilder.Entity<Awardsshareplayer>(entity =>
            {
                entity.ToTable("awardsshareplayers");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => new { e.PlayerId, e.AwardId, e.YearId, e.LgId }, "playerID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AwardId)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("awardID");

                entity.Property(e => e.LgId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.PointsMax).HasColumnName("pointsMax");

                entity.Property(e => e.PointsWon).HasColumnName("pointsWon");

                entity.Property(e => e.VotesFirst).HasColumnName("votesFirst");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Awardsshareplayers)
                    .HasForeignKey(d => d.LgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("awardsshareplayers_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Awardsshareplayers)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("awardsshareplayers_ibfk_2");
            });

            modelBuilder.Entity<Batting>(entity =>
            {
                entity.ToTable("batting");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Stint }, "playerID")
                    .IsUnique();

                entity.HasIndex(e => e.TeamId1, "team_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ab).HasColumnName("AB");

                entity.Property(e => e.Bb).HasColumnName("BB");

                entity.Property(e => e.Cs).HasColumnName("CS");

                entity.Property(e => e.GBatting).HasColumnName("G_batting");

                entity.Property(e => e.Gidp).HasColumnName("GIDP");

                entity.Property(e => e.Hbp).HasColumnName("HBP");

                entity.Property(e => e.Hr).HasColumnName("HR");

                entity.Property(e => e.Ibb).HasColumnName("IBB");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.Rbi).HasColumnName("RBI");

                entity.Property(e => e.Sb).HasColumnName("SB");

                entity.Property(e => e.Sf).HasColumnName("SF");

                entity.Property(e => e.Sh).HasColumnName("SH");

                entity.Property(e => e.So).HasColumnName("SO");

                entity.Property(e => e.Stint).HasColumnName("stint");

                entity.Property(e => e.TeamId)
                    .HasMaxLength(3)
                    .HasColumnName("teamID")
                    .IsFixedLength();

                entity.Property(e => e.TeamId1).HasColumnName("team_ID");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.Property(e => e._2b).HasColumnName("2B");

                entity.Property(e => e._3b).HasColumnName("3B");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Battings)
                    .HasForeignKey(d => d.LgId)
                    .HasConstraintName("batting_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Battings)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("batting_ibfk_3");

                entity.HasOne(d => d.TeamId1Navigation)
                    .WithMany(p => p.Battings)
                    .HasForeignKey(d => d.TeamId1)
                    .HasConstraintName("batting_ibfk_2");
            });

            modelBuilder.Entity<Battingpost>(entity =>
            {
                entity.ToTable("battingpost");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => e.PlayerId, "playerID");

                entity.HasIndex(e => e.TeamId1, "team_ID");

                entity.HasIndex(e => new { e.YearId, e.Round, e.PlayerId }, "yearID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ab).HasColumnName("AB");

                entity.Property(e => e.Bb).HasColumnName("BB");

                entity.Property(e => e.Cs).HasColumnName("CS");

                entity.Property(e => e.Gidp).HasColumnName("GIDP");

                entity.Property(e => e.Hbp).HasColumnName("HBP");

                entity.Property(e => e.Hr).HasColumnName("HR");

                entity.Property(e => e.Ibb).HasColumnName("IBB");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.Rbi).HasColumnName("RBI");

                entity.Property(e => e.Round)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("round");

                entity.Property(e => e.Sb).HasColumnName("SB");

                entity.Property(e => e.Sf).HasColumnName("SF");

                entity.Property(e => e.Sh).HasColumnName("SH");

                entity.Property(e => e.So).HasColumnName("SO");

                entity.Property(e => e.TeamId)
                    .HasMaxLength(3)
                    .HasColumnName("teamID")
                    .IsFixedLength();

                entity.Property(e => e.TeamId1).HasColumnName("team_ID");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.Property(e => e._2b).HasColumnName("2B");

                entity.Property(e => e._3b).HasColumnName("3B");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Battingposts)
                    .HasForeignKey(d => d.LgId)
                    .HasConstraintName("battingpost_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Battingposts)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("battingpost_ibfk_3");

                entity.HasOne(d => d.TeamId1Navigation)
                    .WithMany(p => p.Battingposts)
                    .HasForeignKey(d => d.TeamId1)
                    .HasConstraintName("battingpost_ibfk_2");
            });

            modelBuilder.Entity<Collegeplaying>(entity =>
            {
                entity.ToTable("collegeplaying");

                entity.HasIndex(e => e.PlayerId, "playerID");

                entity.HasIndex(e => e.SchoolId, "schoolID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.SchoolId)
                    .HasMaxLength(15)
                    .HasColumnName("schoolID");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Collegeplayings)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("collegeplaying_ibfk_2");

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Collegeplayings)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("collegeplaying_ibfk_1");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.ToTable("divisions");

                entity.HasIndex(e => new { e.DivId, e.LgId }, "divID")
                    .IsUnique();

                entity.HasIndex(e => e.LgId, "lgID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("active")
                    .IsFixedLength();

                entity.Property(e => e.DivId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("divID")
                    .IsFixedLength();

                entity.Property(e => e.Division1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("division");

                entity.Property(e => e.LgId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Divisions)
                    .HasForeignKey(d => d.LgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("divisions_ibfk_1");
            });

            modelBuilder.Entity<Efmigrationshistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__efmigrationshistory");

                entity.Property(e => e.MigrationId).HasMaxLength(95);

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Fielding>(entity =>
            {
                entity.ToTable("fielding");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Stint, e.Pos }, "playerID")
                    .IsUnique();

                entity.HasIndex(e => e.TeamId1, "team_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cs).HasColumnName("CS");

                entity.Property(e => e.Dp).HasColumnName("DP");

                entity.Property(e => e.Gs).HasColumnName("GS");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.Pb).HasColumnName("PB");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.Po).HasColumnName("PO");

                entity.Property(e => e.Pos)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("POS");

                entity.Property(e => e.Sb).HasColumnName("SB");

                entity.Property(e => e.Stint).HasColumnName("stint");

                entity.Property(e => e.TeamId)
                    .HasMaxLength(3)
                    .HasColumnName("teamID")
                    .IsFixedLength();

                entity.Property(e => e.TeamId1).HasColumnName("team_ID");

                entity.Property(e => e.Wp).HasColumnName("WP");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.Property(e => e.Zr).HasColumnName("ZR");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Fieldings)
                    .HasForeignKey(d => d.LgId)
                    .HasConstraintName("fielding_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Fieldings)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fielding_ibfk_3");

                entity.HasOne(d => d.TeamId1Navigation)
                    .WithMany(p => p.Fieldings)
                    .HasForeignKey(d => d.TeamId1)
                    .HasConstraintName("fielding_ibfk_2");
            });

            modelBuilder.Entity<Fieldingof>(entity =>
            {
                entity.ToTable("fieldingof");

                entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Stint }, "playerID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.Stint).HasColumnName("stint");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Fieldingofs)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fieldingof_ibfk_1");
            });

            modelBuilder.Entity<Fieldingofsplit>(entity =>
            {
                entity.ToTable("fieldingofsplit");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Stint, e.Pos }, "playerID")
                    .IsUnique();

                entity.HasIndex(e => e.TeamId1, "team_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cs).HasColumnName("CS");

                entity.Property(e => e.Dp).HasColumnName("DP");

                entity.Property(e => e.Gs).HasColumnName("GS");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.Pb).HasColumnName("PB");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.Po).HasColumnName("PO");

                entity.Property(e => e.Pos)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("POS");

                entity.Property(e => e.Sb).HasColumnName("SB");

                entity.Property(e => e.Stint).HasColumnName("stint");

                entity.Property(e => e.TeamId)
                    .HasMaxLength(3)
                    .HasColumnName("teamID")
                    .IsFixedLength();

                entity.Property(e => e.TeamId1).HasColumnName("team_ID");

                entity.Property(e => e.Wp).HasColumnName("WP");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.Property(e => e.Zr).HasColumnName("ZR");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Fieldingofsplits)
                    .HasForeignKey(d => d.LgId)
                    .HasConstraintName("fieldingofsplit_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Fieldingofsplits)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fieldingofsplit_ibfk_3");

                entity.HasOne(d => d.TeamId1Navigation)
                    .WithMany(p => p.Fieldingofsplits)
                    .HasForeignKey(d => d.TeamId1)
                    .HasConstraintName("fieldingofsplit_ibfk_2");
            });

            modelBuilder.Entity<Fieldingpost>(entity =>
            {
                entity.ToTable("fieldingpost");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Round, e.Pos }, "playerID")
                    .IsUnique();

                entity.HasIndex(e => e.TeamId1, "team_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cs).HasColumnName("CS");

                entity.Property(e => e.Dp).HasColumnName("DP");

                entity.Property(e => e.Gs).HasColumnName("GS");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.Pb).HasColumnName("PB");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.Po).HasColumnName("PO");

                entity.Property(e => e.Pos)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("POS");

                entity.Property(e => e.Round)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("round");

                entity.Property(e => e.Sb).HasColumnName("SB");

                entity.Property(e => e.TeamId)
                    .HasMaxLength(3)
                    .HasColumnName("teamID")
                    .IsFixedLength();

                entity.Property(e => e.TeamId1).HasColumnName("team_ID");

                entity.Property(e => e.Tp).HasColumnName("TP");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Fieldingposts)
                    .HasForeignKey(d => d.LgId)
                    .HasConstraintName("fieldingpost_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Fieldingposts)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fieldingpost_ibfk_3");

                entity.HasOne(d => d.TeamId1Navigation)
                    .WithMany(p => p.Fieldingposts)
                    .HasForeignKey(d => d.TeamId1)
                    .HasConstraintName("fieldingpost_ibfk_2");
            });

            modelBuilder.Entity<Halloffame>(entity =>
            {
                entity.ToTable("halloffame");

                entity.HasIndex(e => new { e.PlayerId, e.Yearid, e.VotedBy }, "playerID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ballots).HasColumnName("ballots");

                entity.Property(e => e.Category)
                    .HasMaxLength(20)
                    .HasColumnName("category");

                entity.Property(e => e.Inducted)
                    .HasMaxLength(1)
                    .HasColumnName("inducted");

                entity.Property(e => e.Needed).HasColumnName("needed");

                entity.Property(e => e.NeededNote)
                    .HasMaxLength(25)
                    .HasColumnName("needed_note");

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("playerID");

                entity.Property(e => e.VotedBy)
                    .IsRequired()
                    .HasMaxLength(64)
                    .HasColumnName("votedBy");

                entity.Property(e => e.Votes).HasColumnName("votes");

                entity.Property(e => e.Yearid).HasColumnName("yearid");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Halloffames)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("halloffame_ibfk_1");
            });

            modelBuilder.Entity<Homegame>(entity =>
            {
                entity.ToTable("homegames");

                entity.HasIndex(e => e.Leaguekey, "leaguekey");

                entity.HasIndex(e => e.ParkId, "park_ID");

                entity.HasIndex(e => e.TeamId, "team_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Attendance).HasColumnName("attendance");

                entity.Property(e => e.Games).HasColumnName("games");

                entity.Property(e => e.Leaguekey)
                    .HasMaxLength(2)
                    .HasColumnName("leaguekey")
                    .IsFixedLength();

                entity.Property(e => e.Openings).HasColumnName("openings");

                entity.Property(e => e.ParkId).HasColumnName("park_ID");

                entity.Property(e => e.Parkkey)
                    .HasMaxLength(255)
                    .HasColumnName("parkkey");

                entity.Property(e => e.Spanfirst)
                    .HasMaxLength(255)
                    .HasColumnName("spanfirst");

                entity.Property(e => e.SpanfirstDate).HasColumnName("spanfirst_date");

                entity.Property(e => e.Spanlast)
                    .HasMaxLength(255)
                    .HasColumnName("spanlast");

                entity.Property(e => e.SpanlastDate).HasColumnName("spanlast_date");

                entity.Property(e => e.TeamId).HasColumnName("team_ID");

                entity.Property(e => e.Teamkey)
                    .HasMaxLength(3)
                    .HasColumnName("teamkey")
                    .IsFixedLength();

                entity.Property(e => e.Yearkey).HasColumnName("yearkey");

                entity.HasOne(d => d.LeaguekeyNavigation)
                    .WithMany(p => p.Homegames)
                    .HasForeignKey(d => d.Leaguekey)
                    .HasConstraintName("homegames_ibfk_1");

                entity.HasOne(d => d.Park)
                    .WithMany(p => p.Homegames)
                    .HasForeignKey(d => d.ParkId)
                    .HasConstraintName("homegames_ibfk_3");

                entity.HasOne(d => d.Team)
                    .WithMany(p => p.Homegames)
                    .HasForeignKey(d => d.TeamId)
                    .HasConstraintName("homegames_ibfk_2");
            });

            modelBuilder.Entity<League>(entity =>
            {
                entity.HasKey(e => e.LgId)
                    .HasName("PRIMARY");

                entity.ToTable("leagues");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasMaxLength(1)
                    .HasColumnName("active")
                    .IsFixedLength();

                entity.Property(e => e.League1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("league");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("managers");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => e.PlayerId, "playerID");

                entity.HasIndex(e => e.TeamId1, "team_ID");

                entity.HasIndex(e => new { e.YearId, e.TeamId, e.Inseason }, "yearID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Inseason).HasColumnName("inseason");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.PlayerId)
                    .HasMaxLength(10)
                    .HasColumnName("playerID");

                entity.Property(e => e.PlyrMgr)
                    .HasMaxLength(1)
                    .HasColumnName("plyrMgr");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("teamID")
                    .IsFixedLength();

                entity.Property(e => e.TeamId1).HasColumnName("team_ID");

                entity.Property(e => e.TeamRank).HasColumnName("teamRank");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Managers)
                    .HasForeignKey(d => d.LgId)
                    .HasConstraintName("managers_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Managers)
                    .HasForeignKey(d => d.PlayerId)
                    .HasConstraintName("managers_ibfk_3");

                entity.HasOne(d => d.TeamId1Navigation)
                    .WithMany(p => p.Managers)
                    .HasForeignKey(d => d.TeamId1)
                    .HasConstraintName("managers_ibfk_2");
            });

            modelBuilder.Entity<Managershalf>(entity =>
            {
                entity.ToTable("managershalf");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => new { e.PlayerId, e.YearId, e.TeamId, e.Half }, "playerID")
                    .IsUnique();

                entity.HasIndex(e => e.TeamId1, "team_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Half).HasColumnName("half");

                entity.Property(e => e.Inseason).HasColumnName("inseason");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("playerID");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("teamID")
                    .IsFixedLength();

                entity.Property(e => e.TeamId1).HasColumnName("team_ID");

                entity.Property(e => e.TeamRank).HasColumnName("teamRank");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Managershalves)
                    .HasForeignKey(d => d.LgId)
                    .HasConstraintName("managershalf_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Managershalves)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("managershalf_ibfk_3");

                entity.HasOne(d => d.TeamId1Navigation)
                    .WithMany(p => p.Managershalves)
                    .HasForeignKey(d => d.TeamId1)
                    .HasConstraintName("managershalf_ibfk_2");
            });

            modelBuilder.Entity<Park>(entity =>
            {
                entity.ToTable("parks");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City)
                    .HasMaxLength(255)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(255)
                    .HasColumnName("country");

                entity.Property(e => e.Parkalias)
                    .HasMaxLength(255)
                    .HasColumnName("parkalias");

                entity.Property(e => e.Parkkey)
                    .HasMaxLength(255)
                    .HasColumnName("parkkey");

                entity.Property(e => e.Parkname)
                    .HasMaxLength(255)
                    .HasColumnName("parkname");

                entity.Property(e => e.State)
                    .HasMaxLength(255)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.PlayerId)
                    .HasName("PRIMARY");

                entity.ToTable("people");

                entity.Property(e => e.PlayerId)
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.Bats)
                    .HasMaxLength(255)
                    .HasColumnName("bats");

                entity.Property(e => e.BbrefId)
                    .HasMaxLength(255)
                    .HasColumnName("bbrefID");

                entity.Property(e => e.BirthCity)
                    .HasMaxLength(255)
                    .HasColumnName("birthCity");

                entity.Property(e => e.BirthCountry)
                    .HasMaxLength(255)
                    .HasColumnName("birthCountry");

                entity.Property(e => e.BirthDate).HasColumnName("birth_date");

                entity.Property(e => e.BirthDay).HasColumnName("birthDay");

                entity.Property(e => e.BirthMonth).HasColumnName("birthMonth");

                entity.Property(e => e.BirthState)
                    .HasMaxLength(255)
                    .HasColumnName("birthState");

                entity.Property(e => e.BirthYear).HasColumnName("birthYear");

                entity.Property(e => e.DeathCity)
                    .HasMaxLength(255)
                    .HasColumnName("deathCity");

                entity.Property(e => e.DeathCountry)
                    .HasMaxLength(255)
                    .HasColumnName("deathCountry");

                entity.Property(e => e.DeathDate).HasColumnName("death_date");

                entity.Property(e => e.DeathDay).HasColumnName("deathDay");

                entity.Property(e => e.DeathMonth).HasColumnName("deathMonth");

                entity.Property(e => e.DeathState)
                    .HasMaxLength(255)
                    .HasColumnName("deathState");

                entity.Property(e => e.DeathYear).HasColumnName("deathYear");

                entity.Property(e => e.Debut)
                    .HasMaxLength(255)
                    .HasColumnName("debut");

                entity.Property(e => e.DebutDate).HasColumnName("debut_date");

                entity.Property(e => e.FinalGame)
                    .HasMaxLength(255)
                    .HasColumnName("finalGame");

                entity.Property(e => e.FinalgameDate).HasColumnName("finalgame_date");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.NameFirst)
                    .HasMaxLength(255)
                    .HasColumnName("nameFirst");

                entity.Property(e => e.NameGiven)
                    .HasMaxLength(255)
                    .HasColumnName("nameGiven");

                entity.Property(e => e.NameLast)
                    .HasMaxLength(255)
                    .HasColumnName("nameLast");

                entity.Property(e => e.RetroId)
                    .HasMaxLength(255)
                    .HasColumnName("retroID");

                entity.Property(e => e.Throws)
                    .HasMaxLength(255)
                    .HasColumnName("throws");

                entity.Property(e => e.Weight).HasColumnName("weight");
            });

            modelBuilder.Entity<Pitching>(entity =>
            {
                entity.ToTable("pitching");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Stint }, "playerID")
                    .IsUnique();

                entity.HasIndex(e => e.TeamId1, "team_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Baopp).HasColumnName("BAOpp");

                entity.Property(e => e.Bb).HasColumnName("BB");

                entity.Property(e => e.Bfp).HasColumnName("BFP");

                entity.Property(e => e.Bk).HasColumnName("BK");

                entity.Property(e => e.Cg).HasColumnName("CG");

                entity.Property(e => e.Er).HasColumnName("ER");

                entity.Property(e => e.Era).HasColumnName("ERA");

                entity.Property(e => e.Gf).HasColumnName("GF");

                entity.Property(e => e.Gidp).HasColumnName("GIDP");

                entity.Property(e => e.Gs).HasColumnName("GS");

                entity.Property(e => e.Hbp).HasColumnName("HBP");

                entity.Property(e => e.Hr).HasColumnName("HR");

                entity.Property(e => e.Ibb).HasColumnName("IBB");

                entity.Property(e => e.Ipouts).HasColumnName("IPouts");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.Sf).HasColumnName("SF");

                entity.Property(e => e.Sh).HasColumnName("SH");

                entity.Property(e => e.Sho).HasColumnName("SHO");

                entity.Property(e => e.So).HasColumnName("SO");

                entity.Property(e => e.Stint).HasColumnName("stint");

                entity.Property(e => e.Sv).HasColumnName("SV");

                entity.Property(e => e.TeamId)
                    .HasMaxLength(3)
                    .HasColumnName("teamID")
                    .IsFixedLength();

                entity.Property(e => e.TeamId1).HasColumnName("team_ID");

                entity.Property(e => e.Wp).HasColumnName("WP");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Pitchings)
                    .HasForeignKey(d => d.LgId)
                    .HasConstraintName("pitching_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Pitchings)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pitching_ibfk_3");

                entity.HasOne(d => d.TeamId1Navigation)
                    .WithMany(p => p.Pitchings)
                    .HasForeignKey(d => d.TeamId1)
                    .HasConstraintName("pitching_ibfk_2");
            });

            modelBuilder.Entity<Pitchingpost>(entity =>
            {
                entity.ToTable("pitchingpost");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => new { e.PlayerId, e.YearId, e.Round }, "playerID")
                    .IsUnique();

                entity.HasIndex(e => e.TeamId1, "team_ID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Baopp).HasColumnName("BAOpp");

                entity.Property(e => e.Bb).HasColumnName("BB");

                entity.Property(e => e.Bfp).HasColumnName("BFP");

                entity.Property(e => e.Bk).HasColumnName("BK");

                entity.Property(e => e.Cg).HasColumnName("CG");

                entity.Property(e => e.Er).HasColumnName("ER");

                entity.Property(e => e.Era).HasColumnName("ERA");

                entity.Property(e => e.Gf).HasColumnName("GF");

                entity.Property(e => e.Gidp).HasColumnName("GIDP");

                entity.Property(e => e.Gs).HasColumnName("GS");

                entity.Property(e => e.Hbp).HasColumnName("HBP");

                entity.Property(e => e.Hr).HasColumnName("HR");

                entity.Property(e => e.Ibb).HasColumnName("IBB");

                entity.Property(e => e.Ipouts).HasColumnName("IPouts");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.PlayerId)
                    .IsRequired()
                    .HasMaxLength(9)
                    .HasColumnName("playerID");

                entity.Property(e => e.Round)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("round");

                entity.Property(e => e.Sf).HasColumnName("SF");

                entity.Property(e => e.Sh).HasColumnName("SH");

                entity.Property(e => e.Sho).HasColumnName("SHO");

                entity.Property(e => e.So).HasColumnName("SO");

                entity.Property(e => e.Sv).HasColumnName("SV");

                entity.Property(e => e.TeamId)
                    .HasMaxLength(3)
                    .HasColumnName("teamID")
                    .IsFixedLength();

                entity.Property(e => e.TeamId1).HasColumnName("team_ID");

                entity.Property(e => e.Wp).HasColumnName("WP");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Pitchingposts)
                    .HasForeignKey(d => d.LgId)
                    .HasConstraintName("pitchingpost_ibfk_1");

                entity.HasOne(d => d.Player)
                    .WithMany(p => p.Pitchingposts)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("pitchingpost_ibfk_3");

                entity.HasOne(d => d.TeamId1Navigation)
                    .WithMany(p => p.Pitchingposts)
                    .HasForeignKey(d => d.TeamId1)
                    .HasConstraintName("pitchingpost_ibfk_2");
            });

            modelBuilder.Entity<Richjsontagdatum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("richjsontagdata");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("created_at");

                entity.Property(e => e.TagId).HasColumnName("tag_id");

                entity.Property(e => e.TagRichDetail)
                    .HasColumnType("json")
                    .HasColumnName("tag_rich_detail");
            });

            modelBuilder.Entity<School>(entity =>
            {
                entity.ToTable("schools");

                entity.Property(e => e.SchoolId)
                    .HasMaxLength(15)
                    .HasColumnName("schoolID");

                entity.Property(e => e.City)
                    .HasMaxLength(55)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(55)
                    .HasColumnName("country");

                entity.Property(e => e.NameFull)
                    .HasMaxLength(255)
                    .HasColumnName("name_full");

                entity.Property(e => e.State)
                    .HasMaxLength(55)
                    .HasColumnName("state");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.ToTable("tags");

                entity.Property(e => e.TagId)
                    .HasMaxLength(64)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DataFieldReferencesAsJson)
                    .HasMaxLength(1024)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TagValue)
                    .HasMaxLength(512)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Tagrelationship>(entity =>
            {
                entity.ToTable("tagrelationships");

                entity.Property(e => e.TagRelationshipId)
                    .HasMaxLength(64)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.DataEntityId)
                    .HasMaxLength(64)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");

                entity.Property(e => e.TagId)
                    .HasMaxLength(64)
                    .UseCollation("utf8_general_ci")
                    .HasCharSet("utf8");
            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("teams");

                entity.HasIndex(e => e.DivId1, "div_ID");

                entity.HasIndex(e => e.FranchId, "franchID");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => new { e.YearId, e.LgId, e.TeamId }, "yearID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ab).HasColumnName("AB");

                entity.Property(e => e.Attendance).HasColumnName("attendance");

                entity.Property(e => e.Bb).HasColumnName("BB");

                entity.Property(e => e.Bba).HasColumnName("BBA");

                entity.Property(e => e.Bpf).HasColumnName("BPF");

                entity.Property(e => e.Cg).HasColumnName("CG");

                entity.Property(e => e.Cs).HasColumnName("CS");

                entity.Property(e => e.DivId)
                    .HasMaxLength(1)
                    .HasColumnName("divID")
                    .IsFixedLength();

                entity.Property(e => e.DivId1).HasColumnName("div_ID");

                entity.Property(e => e.DivWin).HasMaxLength(1);

                entity.Property(e => e.Dp).HasColumnName("DP");

                entity.Property(e => e.Er).HasColumnName("ER");

                entity.Property(e => e.Era).HasColumnName("ERA");

                entity.Property(e => e.Fp).HasColumnName("FP");

                entity.Property(e => e.FranchId)
                    .HasMaxLength(3)
                    .HasColumnName("franchID");

                entity.Property(e => e.Ha).HasColumnName("HA");

                entity.Property(e => e.Hbp).HasColumnName("HBP");

                entity.Property(e => e.Hr).HasColumnName("HR");

                entity.Property(e => e.Hra).HasColumnName("HRA");

                entity.Property(e => e.Ipouts).HasColumnName("IPouts");

                entity.Property(e => e.LgId)
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.LgWin).HasMaxLength(1);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name");

                entity.Property(e => e.Park)
                    .HasMaxLength(255)
                    .HasColumnName("park");

                entity.Property(e => e.Ppf).HasColumnName("PPF");

                entity.Property(e => e.Ra).HasColumnName("RA");

                entity.Property(e => e.Sb).HasColumnName("SB");

                entity.Property(e => e.Sf).HasColumnName("SF");

                entity.Property(e => e.Sho).HasColumnName("SHO");

                entity.Property(e => e.So).HasColumnName("SO");

                entity.Property(e => e.Soa).HasColumnName("SOA");

                entity.Property(e => e.Sv).HasColumnName("SV");

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("teamID")
                    .IsFixedLength();

                entity.Property(e => e.TeamIdbr)
                    .HasMaxLength(3)
                    .HasColumnName("teamIDBR");

                entity.Property(e => e.TeamIdlahman45)
                    .HasMaxLength(3)
                    .HasColumnName("teamIDlahman45");

                entity.Property(e => e.TeamIdretro)
                    .HasMaxLength(3)
                    .HasColumnName("teamIDretro");

                entity.Property(e => e.TeamRank).HasColumnName("teamRank");

                entity.Property(e => e.Wcwin)
                    .HasMaxLength(1)
                    .HasColumnName("WCWin");

                entity.Property(e => e.Wswin)
                    .HasMaxLength(1)
                    .HasColumnName("WSWin");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.Property(e => e._2b).HasColumnName("2B");

                entity.Property(e => e._3b).HasColumnName("3B");

                entity.HasOne(d => d.DivId1Navigation)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.DivId1)
                    .HasConstraintName("teams_ibfk_2");

                entity.HasOne(d => d.Franch)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.FranchId)
                    .HasConstraintName("teams_ibfk_3");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Teams)
                    .HasForeignKey(d => d.LgId)
                    .HasConstraintName("teams_ibfk_1");
            });

            modelBuilder.Entity<Teamsfranchise>(entity =>
            {
                entity.HasKey(e => e.FranchId)
                    .HasName("PRIMARY");

                entity.ToTable("teamsfranchises");

                entity.Property(e => e.FranchId)
                    .HasMaxLength(3)
                    .HasColumnName("franchID");

                entity.Property(e => e.Active)
                    .HasMaxLength(1)
                    .HasColumnName("active")
                    .IsFixedLength();

                entity.Property(e => e.FranchName)
                    .HasMaxLength(50)
                    .HasColumnName("franchName");

                entity.Property(e => e.Naassoc)
                    .HasMaxLength(3)
                    .HasColumnName("NAassoc");
            });

            modelBuilder.Entity<Teamshalf>(entity =>
            {
                entity.ToTable("teamshalf");

                entity.HasIndex(e => e.DivId1, "div_ID");

                entity.HasIndex(e => e.LgId, "lgID");

                entity.HasIndex(e => e.TeamId1, "team_ID");

                entity.HasIndex(e => new { e.YearId, e.LgId, e.TeamId, e.Half }, "yearID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DivId)
                    .HasMaxLength(1)
                    .HasColumnName("divID");

                entity.Property(e => e.DivId1).HasColumnName("div_ID");

                entity.Property(e => e.DivWin).HasMaxLength(1);

                entity.Property(e => e.Half)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.LgId)
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnName("lgID")
                    .IsFixedLength();

                entity.Property(e => e.TeamId)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasColumnName("teamID")
                    .IsFixedLength();

                entity.Property(e => e.TeamId1).HasColumnName("team_ID");

                entity.Property(e => e.TeamRank).HasColumnName("teamRank");

                entity.Property(e => e.YearId).HasColumnName("yearID");

                entity.HasOne(d => d.DivId1Navigation)
                    .WithMany(p => p.Teamshalves)
                    .HasForeignKey(d => d.DivId1)
                    .HasConstraintName("teamshalf_ibfk_2");

                entity.HasOne(d => d.Lg)
                    .WithMany(p => p.Teamshalves)
                    .HasForeignKey(d => d.LgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("teamshalf_ibfk_1");

                entity.HasOne(d => d.TeamId1Navigation)
                    .WithMany(p => p.Teamshalves)
                    .HasForeignKey(d => d.TeamId1)
                    .HasConstraintName("teamshalf_ibfk_3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
