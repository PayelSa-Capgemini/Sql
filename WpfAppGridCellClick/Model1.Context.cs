﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfAppGridCellClick
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class sqlpracticeEntities : DbContext
    {
        public sqlpracticeEntities()
            : base("name=sqlpracticeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<prcEmpSearch_Result> prcEmpSearch(Nullable<int> empno)
        {
            var empnoParameter = empno.HasValue ?
                new ObjectParameter("empno", empno) :
                new ObjectParameter("empno", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prcEmpSearch_Result>("prcEmpSearch", empnoParameter);
        }
    
        public virtual ObjectResult<prcEmpShow_Result> prcEmpShow()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<prcEmpShow_Result>("prcEmpShow");
        }
    }
}
