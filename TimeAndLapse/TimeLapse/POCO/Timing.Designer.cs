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
    // Timings
    public partial class Timing
    {
        public Guid TimingId { get; set; } // TimingID (Primary key)
        public DateTime Time { get; set; } // Time
        public Guid RunId { get; set; } // RunID
        public Guid TimingTypeId { get; set; } // TimingTypeID

        // Foreign keys
        public virtual Run Run { get; set; } // FK__Timings__RunID__46E78A0C
        public virtual TimingType TimingType { get; set; } // FK__Timings__TimingT__47DBAE45
        
        public Timing()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
