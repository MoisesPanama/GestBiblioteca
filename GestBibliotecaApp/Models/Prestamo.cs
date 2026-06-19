using System.ComponentModel.DataAnnotations;

namespace GestBibliotecaApp.Models
{
    public class Prestamo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del estudiante es obligatorio")]
        [StringLength(100, ErrorMessage = "Maximo 100 caracteres")]
        [Display(Name = "Estudiante")]
        public string? Estudiante { get; set; }

        [Required(ErrorMessage = "El titulo del libro es obligatorio")]
        [StringLength(150, ErrorMessage = "Maximo 150 caracteres")]
        [Display(Name = "Libro")]
        public string? Libro { get; set; }

        [Required(ErrorMessage = "La fecha de prestamo es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Prestamo")]
        public DateTime FechaPrestamo { get; set; }

        [Required(ErrorMessage = "La fecha de devolucion es obligatoria")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Devolucion Estimada")]
        public DateTime FechaDevolucion { get; set; }

        [Required(ErrorMessage = "El estado es obligatorio")]
        [RegularExpression("Activo|Devuelto|Vencido|Renovado",
            ErrorMessage = "Use: Activo, Devuelto, Vencido o Renovado")]
        [Display(Name = "Estado")]
        public string? Estado { get; set; }
    }
}