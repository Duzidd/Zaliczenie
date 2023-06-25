using System.ComponentModel.DataAnnotations;

namespace Zaliczenie.Models.domain
{
    public class userr
    {

        public Guid Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string Name { get; set; }
        [Required]
        [MaxLength(128)]
        public string Secondname { get; set; }
        [Required]
        [MaxLength(128)]
        public string Adres { get; set; }
        [Required]
        [MaxLength(128)]
        public string Telefon { get; set; }
        [Required]
        [MaxLength(11)]
        public string Pesel { get; set; }
        public bool Osiemnascie { get; set; }
        [Required]
        [MaxLength(256)]
        public string? Opiekun { get; set; }
        [Required]
        [MaxLength(11)]
        public string? Tel_opiekuna { get; set; }
        public DateTime Od { get; set; }
        public DateTime Do { get; set; }
        public string TypWycieczki { get; set; }
    }
}
