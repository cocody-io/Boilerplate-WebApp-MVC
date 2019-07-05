//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quality.DataAccess.DataFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class Anomaly
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Anomaly()
        {
            this.H = new HashSet<H>();
            this.TicketNC = new HashSet<TicketNC>();
        }
    
        public int Id { get; set; }
        public System.DateTime CreationDate { get; set; }
        public Nullable<int> PieceId { get; set; }
        public Nullable<int> ref_ProductionAreaId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<H> H { get; set; }
        public virtual Piece Piece { get; set; }
        public virtual ref_ProductionArea ref_ProductionArea { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TicketNC> TicketNC { get; set; }
    }
}
