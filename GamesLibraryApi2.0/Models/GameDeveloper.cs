//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GamesLibraryApi2._0.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GameDeveloper
    {
        public int GameId { get; set; }
        public int DeveloperId { get; set; }
        public int StudioId { get; set; }
    
        public virtual Developer Developer { get; set; }
        public virtual Game Game { get; set; }
        public virtual Studio Studio { get; set; }
    }
}
