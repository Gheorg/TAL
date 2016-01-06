// <auto-generated>
// ReSharper disable RedundantUsingDirective
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable RedundantNameQualifier
// TargetFrameworkVersion = 4.51
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Data.Entity.Infrastructure;
using System.Linq.Expressions;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data;
using System.Data.Entity.Core.Objects;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Entity.ModelConfiguration;
using System.Threading;
using DatabaseGeneratedOption = System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption;

namespace TimeLapse.POCO
{
    public partial class TimeAndLapseContext : DbContext, ITimeAndLapseContext
    {
        public DbSet<Category> Categories { get; set; } // Categories
        public DbSet<Championship> Championships { get; set; } // Championships
        public DbSet<Event> Events { get; set; } // Events
        public DbSet<Manch> Manches { get; set; } // Manches
        public DbSet<Partecipant> Partecipants { get; set; } // Partecipants
        public DbSet<Player> Players { get; set; } // Players
        public DbSet<Point> Points { get; set; } // Points
        public DbSet<Race> Races { get; set; } // Races
        public DbSet<Registration> Registrations { get; set; } // Registrations
        public DbSet<Round> Rounds { get; set; } // Rounds
        public DbSet<Run> Runs { get; set; } // Runs
        public DbSet<Score> Scores { get; set; } // Scores
        public DbSet<Season> Seasons { get; set; } // Seasons
        public DbSet<Sysdiagram> Sysdiagrams { get; set; } // sysdiagrams
        public DbSet<Team> Teams { get; set; } // Teams
        public DbSet<Timing> Timings { get; set; } // Timings
        public DbSet<TimingType> TimingTypes { get; set; } // TimingTypes
        
        static TimeAndLapseContext()
        {
            System.Data.Entity.Database.SetInitializer<TimeAndLapseContext>(null);
        }

        public TimeAndLapseContext()
            : base("Name=TimeAndLapseContext")
        {
            InitializePartial();
        }

        public TimeAndLapseContext(string connectionString) : base(connectionString)
        {
            InitializePartial();
        }

        public TimeAndLapseContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model) : base(connectionString, model)
        {
            InitializePartial();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == DBNull.Value);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new CategoryConfiguration());
            modelBuilder.Configurations.Add(new ChampionshipConfiguration());
            modelBuilder.Configurations.Add(new EventConfiguration());
            modelBuilder.Configurations.Add(new ManchConfiguration());
            modelBuilder.Configurations.Add(new PartecipantConfiguration());
            modelBuilder.Configurations.Add(new PlayerConfiguration());
            modelBuilder.Configurations.Add(new PointConfiguration());
            modelBuilder.Configurations.Add(new RaceConfiguration());
            modelBuilder.Configurations.Add(new RegistrationConfiguration());
            modelBuilder.Configurations.Add(new RoundConfiguration());
            modelBuilder.Configurations.Add(new RunConfiguration());
            modelBuilder.Configurations.Add(new ScoreConfiguration());
            modelBuilder.Configurations.Add(new SeasonConfiguration());
            modelBuilder.Configurations.Add(new SysdiagramConfiguration());
            modelBuilder.Configurations.Add(new TeamConfiguration());
            modelBuilder.Configurations.Add(new TimingConfiguration());
            modelBuilder.Configurations.Add(new TimingTypeConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new CategoryConfiguration(schema));
            modelBuilder.Configurations.Add(new ChampionshipConfiguration(schema));
            modelBuilder.Configurations.Add(new EventConfiguration(schema));
            modelBuilder.Configurations.Add(new ManchConfiguration(schema));
            modelBuilder.Configurations.Add(new PartecipantConfiguration(schema));
            modelBuilder.Configurations.Add(new PlayerConfiguration(schema));
            modelBuilder.Configurations.Add(new PointConfiguration(schema));
            modelBuilder.Configurations.Add(new RaceConfiguration(schema));
            modelBuilder.Configurations.Add(new RegistrationConfiguration(schema));
            modelBuilder.Configurations.Add(new RoundConfiguration(schema));
            modelBuilder.Configurations.Add(new RunConfiguration(schema));
            modelBuilder.Configurations.Add(new ScoreConfiguration(schema));
            modelBuilder.Configurations.Add(new SeasonConfiguration(schema));
            modelBuilder.Configurations.Add(new SysdiagramConfiguration(schema));
            modelBuilder.Configurations.Add(new TeamConfiguration(schema));
            modelBuilder.Configurations.Add(new TimingConfiguration(schema));
            modelBuilder.Configurations.Add(new TimingTypeConfiguration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(DbModelBuilder modelBuilder);
        
        // Stored Procedures
    }
}
// </auto-generated>
