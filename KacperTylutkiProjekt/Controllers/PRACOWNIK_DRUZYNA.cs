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
    
    public partial class PRACOWNIK_DRUZYNA
    {
        public decimal ID_TABELAJEDEN { get; set; }
        public Nullable<decimal> ID_DRUZYNY { get; set; }
        public Nullable<decimal> ID_PRACOWNIKA { get; set; }
    
        public virtual DRUZYNA DRUZYNA { get; set; }
        public virtual PRACOWNIK PRACOWNIK { get; set; }
    }
}