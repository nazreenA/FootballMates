//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FootballMates
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblManager
    {
        public int ManagerId { get; set; }
        public Nullable<int> ClubId { get; set; }
        public Nullable<int> YearJoined { get; set; }
        public string FullName { get; set; }
        public byte[] ManagerImage { get; set; }
    
        public virtual TblClub TblClub { get; set; }
    }
}