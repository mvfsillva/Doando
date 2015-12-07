namespace Doando.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ong")]
    public partial class Ong
    {
        [Key]
        public int ID_ONG { get; set; }

        [Required]
        [StringLength(14)]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(100)]
        public string NOME { get; set; }

        [Required]
        [StringLength(100)]
        public string SITE { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL { get; set; }

        [Required]
        [StringLength(150)]
        public string ENDERECO { get; set; }
    }
}
