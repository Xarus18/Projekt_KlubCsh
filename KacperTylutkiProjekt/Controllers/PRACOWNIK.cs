//------------------------------------------------------------------------------
// <auto-generated>
//    Ten kod źródłowy został wygenerowany na podstawie szablonu.
//
//    Ręczne modyfikacje tego pliku mogą spowodować nieoczekiwane zachowanie aplikacji.
//    Ręczne modyfikacje tego pliku zostaną zastąpione w przypadku ponownego wygenerowania kodu.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KacperTylutkiProjekt.Controllers
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRACOWNIK
    {
        public PRACOWNIK()
        {
            this.PRACOWNIK_DRUZYNA = new HashSet<PRACOWNIK_DRUZYNA>();
            this.PRACOWNIK_OBIEKT = new HashSet<PRACOWNIK_OBIEKT>();
        }
    
        public decimal ID_PRACOWNIKA { get; set; }
        public string IMIE { get; set; }
        public string NAZWISKO { get; set; }
        public Nullable<System.DateTime> DATA_ZATRUDNIENIA { get; set; }
        public Nullable<System.DateTime> DATA_ZWOLNIENIA { get; set; }
        public Nullable<decimal> ID_STANOWISKA { get; set; }
        public Nullable<decimal> ID_ADRESU { get; set; }
    
        public virtual ADRES ADRES { get; set; }
        public virtual ICollection<PRACOWNIK_DRUZYNA> PRACOWNIK_DRUZYNA { get; set; }
        public virtual ICollection<PRACOWNIK_OBIEKT> PRACOWNIK_OBIEKT { get; set; }
        public virtual STANOWISKO STANOWISKO { get; set; }
    }
}
