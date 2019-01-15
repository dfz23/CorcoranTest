namespace Amadeus.LATAM.TOU.DataFileUploader.PersistenceContext.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DataFileUploader_DataFile
    {
        [Key]
        public int DataFileId { get; set; }

        public Guid PortalLevelId { get; set; }

        [Required]
        [StringLength(250)]
        public string UniqueName { get; set; }

        [Column(TypeName = "xml")]
        public string XmlData { get; set; }

        [StringLength(250)]
        public string UserCreate { get; set; }

        [StringLength(250)]
        public string UserUpdate { get; set; }

        public DateTime? DateCreate { get; set; }

        public DateTime? DateUpdate { get; set; }
    }
}
