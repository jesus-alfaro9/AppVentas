using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppVentasNet.Models
{
    public class Cliente
    {
        [Required]
        [DisplayName("N°")]
        public string IdCliente { get; set; }
        [Required]
        [DisplayName("Nombre de la Compañia")]
        public string NombreCompañia { get; set; }
        [Required]
        [DisplayName("Dirección")]
        public string Direccion { get; set; }
        [Required]
        [DisplayName("Ciudad")]
        public string Ciudad { get; set; }
        [Required]
        [DisplayName("País")]
        public string País { get; set; }
        [Required]
        [DisplayName("Telefono")]
        public string Telefono { get; set; }

    }
}