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
    
    public partial class DRUZYNA
    {
        public DRUZYNA()
        {
            this.PRACOWNIK_DRUZYNA = new HashSet<PRACOWNIK_DRUZYNA>();
            this.ZAWODNIK = new HashSet<ZAWODNIK>();
        }
    
        public decimal ID_DRUZYNY { get; set; }
        public string NAZWA { get; set; }
        public decimal WIEK_MINIMALNY { get; set; }
        public Nullable<decimal> WIEK_MAKSYMALNY { get; set; }
    
        public virtual ICollection<PRACOWNIK_DRUZYNA> PRACOWNIK_DRUZYNA { get; set; }
        public virtual ICollection<ZAWODNIK> ZAWODNIK { get; set; }
    }
}
