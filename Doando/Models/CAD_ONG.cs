namespace Doando.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CAD_ONG
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

        public int ID_END { get; set; }

        public virtual ENDERECO ENDERECO { get; set; }
    }
}
