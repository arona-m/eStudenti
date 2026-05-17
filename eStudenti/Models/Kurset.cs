using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace eStudenti.Models
{
    public class Kurset
    {
        [Key]
        public int KursiId { get; set; }

        [Required(ErrorMessage ="Emri i kursit duhet te plotesohet!")]
        [StringLength(20,ErrorMessage ="Emri i kursit duhet te kete max 20 karaktere!")]
        [Display(Name ="Emri i kursit")]
        public string EmriKursit {  get; set; }

        [Required(ErrorMessage = "Ligjeruesi i kursit duhet te plotesohet!")]
        [StringLength(20, ErrorMessage = "Ligjeruesi i kursit duhet te kete max 20 karaktere!")]
        public string Ligjerusi { get; set; }

        [Precision(3,6)]
        [Required(ErrorMessage ="Kredit e kursit duhet te shenohen!")]
        public int Kredit { get; set; }

        [Required(ErrorMessage ="Statusi i kursit duhet te caktohet!")]
        public bool Statusi { get; set; }

    }
}
