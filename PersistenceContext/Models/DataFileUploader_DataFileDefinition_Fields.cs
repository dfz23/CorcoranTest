namespace Amadeus.LATAM.TOU.DataFileUploader.PersistenceContext.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DataFileUploader_DataFileDefinition_Fields
    {
        [Key]
        public int FieldId { get; set; }

        public int DataFileDefinitionId { get; set; }

        public int DataTypeId { get; set; }

        [Required]
        [StringLength(250)]
        public string UniqueName { get; set; }

        [Column(TypeName = "xml")]
        public string AdditionalData { get; set; }

        public string Value { get; set; }

        public virtual DataFileUploader_DataFileDefinitions DataFileUploader_DataFileDefinitions { get; set; }

        public virtual DataFileUploader_DataTypes DataFileUploader_DataTypes { get; set; }
    }
}
