using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BitAnalytics.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo Patente es obligatorio.")]

        public string Plate { get; set; }
        [Required(ErrorMessage = "El campo Marca es obligatorio.")]
        public string Make { get; set; }
        [Required(ErrorMessage = "El campo Modelo es obligatorio.")]

        public string Model { get; set; }
        [Required(ErrorMessage = "El campo Color es obligatorio.")]

        public string Color { get; set; }
        [Required(ErrorMessage = "El campo Año es obligatorio.")]

        public int Year { get; set; }
        [Required(ErrorMessage = "El campo Cilindrada es obligatorio.")]

        public int Displacement { get; set; }
    }
}
