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
    // Registrations
    [GeneratedCodeAttribute("EF.Reverse.POCO.Generator", "2.17.1.0")]
    public partial class Registration
    {
        public Guid RegistrationId { get; set; } // RegistrationID (Primary key)
        public byte Payd { get; set; } // Payd
        public int RaceNumber { get; set; } // RaceNumber
        public string Note { get; set; } // Note
        public Guid PartecipantId { get; set; } // PartecipantID
        public Guid RaceId { get; set; } // RaceID

        // Reverse navigation
        public virtual ICollection<Player> Players { get; set; } // Players.FK__Players__Registr__403A8C7D

        // Foreign keys
        public virtual Partecipant Partecipant { get; set; } // FK__Registrat__Parte__3E52440B
        public virtual Race Race { get; set; } // FK__Registrat__RaceI__3F466844
        
        public Registration()
        {
            Players = new List<Player>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>