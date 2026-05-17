using System.ComponentModel.DataAnnotations;

namespace eStudenti.Models
{
    public class Profesoret
    {
        [Key]
        public int ProfId { get; set; }

        [Required(ErrorMessage = "Emri duhet te plotesohet")]
        [StringLength(10, ErrorMessage = "Emri duhet te kete max {1} karaktere!")]
        public string ProfEmri { get; set; }

        [Required(ErrorMessage = "Mbiemri duhet te plotesohet")]
        [StringLength(10, ErrorMessage = "Mbiemri duhet te kete max {1} karaktere!")]
        public string ProfMbiemri { get; set; }

        [Required(ErrorMessage = "Gjinia duhet te plotesohet")]
        [StringLength(10, ErrorMessage = "Emri duhet te kete max {1} karaktere!")]
        public string ProfGjinia { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Data e lindjes nuk eshte ne formatin e duhur!")]
        [Display(Name = "Data e lindjes")]
        public DateTime ProfDataLindjes { get; set; }

        [DataType(DataType.PhoneNumber, ErrorMessage = "Nr. tel nuk eshte ne formatiin e duhur!")]
        [Display(Name = "Numri i telefonit")]
        public string ProfNumriTelefonit { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage = "Email adresa nuk eshte ne formatin e duhur!")]
        [Display(Name = "Email adresa")]
        public string ProfEmail { get; set; }

        [Required(ErrorMessage = "Titulli akademik duhet te plotesohet")]
        [Display(Name = "Titulli Akademik")]
        public string TitulliAkademik { get; set; }

    }
}
