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

        [Required]
        [StringLength(14)]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(100)]
        public string NOME { get; set; }

        [Required]
        [StringLength(100)]
        public string SITE { get; set; }

        public string EMAIL { get { return Email; } set { Email = value; } }

        public int ID_END { get; set; }

        public virtual Endereco Endereco { get; set; }

        public virtual ICollection<Necessidade> Necessidades { get; set; }
    }
}
