﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZBW.BPFM.DBAdv.DBAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ErpContext : DbContext
    {
        public ErpContext()
            : base("name=ErpContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<abteilung> abteilung { get; set; }
        public virtual DbSet<adresse> adresse { get; set; }
        public virtual DbSet<artikel> artikel { get; set; }
        public virtual DbSet<audit> audit { get; set; }
        public virtual DbSet<bestellposition> bestellposition { get; set; }
        public virtual DbSet<bestellung> bestellung { get; set; }
        public virtual DbSet<kunde> kunde { get; set; }
        public virtual DbSet<kundenpreis> kundenpreis { get; set; }
        public virtual DbSet<lager> lager { get; set; }
        public virtual DbSet<lagerbuchung> lagerbuchung { get; set; }
        public virtual DbSet<lagerposition> lagerposition { get; set; }
        public virtual DbSet<land> land { get; set; }
        public virtual DbSet<lieferschein> lieferschein { get; set; }
        public virtual DbSet<lohnabrechnung> lohnabrechnung { get; set; }
        public virtual DbSet<mitarbeiter> mitarbeiter { get; set; }
        public virtual DbSet<mwstsatz> mwstsatz { get; set; }
        public virtual DbSet<ort> ort { get; set; }
        public virtual DbSet<person> person { get; set; }
        public virtual DbSet<rechnung> rechnung { get; set; }
        public virtual DbSet<strasse> strasse { get; set; }
        public virtual DbSet<zahlung> zahlung { get; set; }
    }
}
