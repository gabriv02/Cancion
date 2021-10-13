using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
  
    public class Song
    {
        [Key]
        [Required(ErrorMessage = "Nombre de la cancion es requerida")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "El nombre de la cancion debe contenerentre 3 y 60 caracteres")]

        public string Cancion { get; set; }
        [Display(Name ="Nombre del autor")]
        public string Autor { get; set; }
        [Required]
        [Display(Name = "Letra de la cancion")]
        public string Letra { get; set; }
        [Display(Name ="Link de la cancion")]
        public string Enlace { get; set; }

    }
}
