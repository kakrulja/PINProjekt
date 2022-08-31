using System;
using System.Collections.Generic;

namespace PINProjekt.Entiteti
{
    public partial class UserInfo
    {
        public int Id { get; set; }
        public string? Ime { get; set; }
        public string? Prezime { get; set; }
        public string? Nadimak { get; set; }
        public DateTime? DatumKreiranja { get; set; }
    }
}
