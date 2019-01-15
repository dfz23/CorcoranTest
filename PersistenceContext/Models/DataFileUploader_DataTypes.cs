namespace Amadeus.LATAM.TOU.DataFileUploader.PersistenceContext.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DataFileUploader_DataTypes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DataFileUploader_DataTypes()
        {
            DataFileUploader_DataFileDefinition_Fields = new HashSet<DataFileUploader_DataFileDefinition_Fields>();
        }

        [Key]
        public int DataTypeId { get; set; }

        [Required]
        [StringLength(250)]
        public string UniqueName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DataFileUploader_DataFileDefinition_Fields> DataFileUploader_DataFileDefinition_Fields { get; set; }
    }
}
