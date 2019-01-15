namespace Amadeus.LATAM.TOU.DataFileUploader.PersistenceContext.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DataFileUploader_DataFileDefinitions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataFileUploader_DataFileDefinitions()
        {
            DataFileUploader_DataFileDefinition_Fields = new HashSet<DataFileUploader_DataFileDefinition_Fields>();
        }

        [Key]
        public int DataFileDefinitionId { get; set; }

        public Guid PortalLevelId { get; set; }

        public int FileTypeId { get; set; }

        [Required]
        [StringLength(250)]
        public string UniqueName { get; set; }

        public bool? UseDataFileDefinitionName { get; set; }

        [StringLength(250)]
        public string UserCreate { get; set; }

        [StringLength(250)]
        public string UserUpdate { get; set; }

        public DateTime? DateCreate { get; set; }

        public DateTime? DateUpdate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataFileUploader_DataFileDefinition_Fields> DataFileUploader_DataFileDefinition_Fields { get; set; }

        public virtual DataFileUploader_FileTypes DataFileUploader_FileTypes { get; set; }
    }
}
