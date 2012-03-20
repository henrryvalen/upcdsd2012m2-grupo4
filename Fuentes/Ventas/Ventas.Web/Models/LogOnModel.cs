using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Ventas.Web.Models
{
    public class LogOnModel
    {
        [Required(ErrorMessage="*")]
        [Display(Name = "Usuario")]
        public string User { get; set; }

        [Required(ErrorMessage = "*")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Recodarme?")]
        public bool Recordar { get; set; }
    }
}