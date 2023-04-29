using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estadio.Shared.Entities
{
    public class Boleta
    {
        public int Id { get; set; }

        public string FechaUso { get; set; } = null!;

        [Display(Name ="Fue usada")]
        [Required(ErrorMessage ="El campo {0 es obligatorio.}")]
        public string Usada { get; set; } = null!;

        [Display(Name = "Porteria")]
        [Required(ErrorMessage = "El campo {0 es obligatorio.}")]
        public string Porteria { get; set; } = null!;
    }
}
