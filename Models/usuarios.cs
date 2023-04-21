namespace API.REST.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usuarios
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(100)]
        public string correo_electronico { get; set; }

        [StringLength(100)]
        public string contrasena { get; set; }

        public int? rol_id { get; set; }

        public virtual roles roles { get; set; }
    }
}
