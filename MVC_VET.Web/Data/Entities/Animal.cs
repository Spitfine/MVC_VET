using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_VET.Web.Data.Entities
{
    public class Animal
    {
        public int Id { get; set; }


        public string Nome { get; set; }

        [Display(Name = "Foto")]
        public string ImageUrl { get; set; }


        [Display(Name = "Data de Nascimento")]
        public DateTime? DataNascimento { get; set; }

        [Display(Name = "Espécie")]
        public string Especie { get; set; }

        [Display(Name = "Raça")]
        public string Raca { get; set; }


    }
}
