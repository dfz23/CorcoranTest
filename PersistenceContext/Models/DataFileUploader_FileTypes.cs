namespace Amadeus.LATAM.TOU.DataFileUploader.PersistenceContext.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DataFileUploader_FileTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataFileUploader_FileTypes()
        {
            DataFileUploader_DataFileDefinitions = new HashSet<DataFileUploader_DataFileDefinitions>();
        }

        [Key]
        public int FileTypeId { get; set; }

        [Required]
        [StringLength(250)]
        public string UniqueName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataFileUploader_DataFileDefinitions> DataFileUploader_DataFileDefinitions { get; set; }
    }
}
