using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_VET.Web.Data.Entities
{
    public class Owner : IEntity
    {
        
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nome")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Apelido")]
        public string Last { get; set; }

        [Required]
        [Display(Name = "Morada")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Contacto")]
        public int  PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

    }
}
