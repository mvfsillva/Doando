namespace Doando.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ENDERECO")]
    public partial class ENDERECO
    {
        public ENDERECO()
        {
            CAD_ONG = new HashSet<CAD_ONG>();
        }

        [Key]
        public int ID_END { get; set; }

        [Required]
        [StringLength(100)]
        public string RUA { get; set; }

        [Required]
        [StringLength(100)]
        public string CIDADE { get; set; }

        [Required]
        [StringLength(100)]
        public string TELEFONE_PRIMARIO { get; set; }

        [Required]
        [StringLength(100)]
        public string TELEFONE_SECUNDARIO { get; set; }

        [Required]
        [StringLength(100)]
        public string ESTADO { get; set; }

        [Required]
        [StringLength(100)]
        public string BAIRRO { get; set; }

        [Required]
        [StringLength(100)]
        public string CEP { get; set; }

        public virtual ICollection<CAD_ONG> CAD_ONG { get; set; }
    }
}
