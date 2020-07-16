using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FAQUIApp.Models
{
    public class FAQ
    {
        [Required(ErrorMessage ="Este campo no puede estar vacio.")]
        public string Id { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Question { get; set; }
        [Required(ErrorMessage = "Este campo no puede estar vacio.")]
        public string Answer { get; set; }


        public FAQ()
        {
            Id = string.Empty;
            Question = string.Empty;
            Answer = string.Empty;
        }
    }
}
