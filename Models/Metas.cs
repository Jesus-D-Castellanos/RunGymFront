﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RunGymFront.Models
{
    public class Metas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [ForeignKey("Usuario")]
        public int IdUsuario { get; set; }

        [Display(Name = "Meta Principal")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "El {0} no puede exceder 100 caracteres")]
        public string MetaPrincipal { get; set; }

        [Display(Name = "Cuerpo Actual")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "El {0} no puede exceder 100 caracteres")]
        public string CuerpoActual { get; set; }

        [Display(Name = "Cuerpo Deseado")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [StringLength(100, ErrorMessage = "El {0} no puede exceder 100 caracteres")]
        public string CuerpoDeseado { get; set; }

        [Display(Name = "Descripción")]
        [StringLength(1000, ErrorMessage = "La {0} no puede exceder 1000 caracteres")]
        public string Descripción { get; set; }

        [Display(Name = "Fecha del Objetivo")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaObjetivo { get; set; } = DateTime.UtcNow;

        [Display(Name = "Fecha de Registro")]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}