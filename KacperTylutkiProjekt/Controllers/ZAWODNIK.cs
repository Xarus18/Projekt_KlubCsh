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
    
    public partial class ZAWODNIK
    {
        public decimal ID_ZAWODNIKA { get; set; }
        public string IMIE { get; set; }
        public string NAZWISKO { get; set; }
        public Nullable<System.DateTime> DATA_NABYCIA { get; set; }
        public Nullable<System.DateTime> DATA_TRANSFERU { get; set; }
        public Nullable<System.DateTime> DATA_EMERYTURY { get; set; }
        public Nullable<decimal> ID_POZYCJI { get; set; }
        public Nullable<decimal> ID_DRUZYNY { get; set; }
        public Nullable<decimal> ID_ADRESU { get; set; }
    
        public virtual ADRES ADRES { get; set; }
        public virtual DRUZYNA DRUZYNA { get; set; }
        public virtual POZYCJA POZYCJA { get; set; }
    }
}
