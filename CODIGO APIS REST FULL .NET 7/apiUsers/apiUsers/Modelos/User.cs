using System.ComponentModel.DataAnnotations;

namespace apiUsers.Modelos
{
    public class User
    {
        [Key]
        public int idUser { get; set; }
        [Required]
        public string identificationUser { get; set; }
        public string nameUser { get; set; }
        public string emailUser { get; set; }
        [Required]
        public string passwordUser { get; set; }
        public DateTime createUser { get; set; }
    }
}