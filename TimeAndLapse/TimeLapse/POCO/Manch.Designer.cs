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
    // Manches
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Manch
    {
        public Guid MancheId { get; set; } // MancheID (Primary key)
        public int Shift { get; set; } // Shift
        public Guid PlayerId { get; set; } // PlayerID
        public Guid RoundId { get; set; } // RoundID
        public Guid TournamentId { get; set; } // TournamentID

        // Reverse navigation
        public virtual ICollection<Manch> Manches { get; set; } // Manches.FK__Manches__Tournam__4D94879B
        public virtual ICollection<Run> Runs { get; set; } // Runs.FK__Runs__MancheID__4E88ABD4

        // Foreign keys
        public virtual Manch Manch_TournamentId { get; set; } // FK__Manches__Tournam__4D94879B
        public virtual Player Player { get; set; } // FK__Manches__PlayerI__4BAC3F29
        public virtual Round Round { get; set; } // FK__Manches__RoundID__4CA06362
        
        public Manch()
        {
            Manches = new List<Manch>();
            Runs = new List<Run>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
