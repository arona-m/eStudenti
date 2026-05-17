using System.ComponentModel.DataAnnotations;

namespace eStudenti.Models
{
    public class Studentet
    {
        [Key]
        public int Id {  get; set; }

        [Required(ErrorMessage ="Emri duhet te plotesohet")]
        [StringLength(10,ErrorMessage ="Emri duhet te kete max {1} karaktere!")]
        public string Emri { get; set; }

        [Required(ErrorMessage = "Mbiemri duhet te plotesohet")]
        [StringLength(10, ErrorMessage = "Mbiemri duhet te kete max {1} karaktere!")]
        public string Mbiemri { get; set; }

        [Required(ErrorMessage = "Gjinia duhet te plotesohet")]
        [StringLength(10, ErrorMessage = "Emri duhet te kete max {1} karaktere!")]
        public string Gjinia { get; set; }

        [Required(ErrorMessage = "Vendlindja duhet te plotesohet")]
        [StringLength(15, ErrorMessage = "Vendlindja duhet te kete max {1} karaktere!")]
        public string Vendlindja { get; set; }

        [Required(ErrorMessage = "Vendbanimi duhet te plotesohet")]
        [StringLength(15, ErrorMessage = "Vendbanimi duhet te kete max {1} karaktere!")]
        public string Vendbanimi { get; set; }

        [Required(ErrorMessage = "Shteti duhet te plotesohet")]
        [StringLength(15, ErrorMessage = "Shteti duhet te kete max {1} karaktere!")]
        public string Shteti { get; set; }

        [DataType(DataType.Date,ErrorMessage ="Data e lindjes nuk eshte ne formatin e duhur!")]
        [Display(Name ="Data e lindjes")]
        public DateTime DataLindjes { get; set; }

        [DataType(DataType.PhoneNumber,ErrorMessage ="Nr. tel nuk eshte ne formatiin e duhur!")]
        [Display(Name = "Numri i telefonit")]
        public string NumriTelefonit { get; set; }

        [DataType(DataType.EmailAddress, ErrorMessage ="Email adresa nuk eshte ne formatin e duhur!")]
        [Display(Name = "Email adresa")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Biografia duhet te plotesohet")]
        [StringLength(50, ErrorMessage = "Biografia duhet te kete max {1} karaktere!")]
        public string Biografia { get; set; }

    }
}
