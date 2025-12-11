using System.ComponentModel.DataAnnotations;

namespace WatchlistApp.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Film / Dizi Adı")]
        public string Title { get; set; } = string.Empty;

        [StringLength(50)]
        [Display(Name = "Tür")]
        public string? Genre { get; set; }

        [Display(Name = "Yapım Yılı")]
        [Range(1900, 2100)]
        public int? ReleaseYear { get; set; }

        [Display(Name = "Puan (1-10)")]
        [Range(1, 10)]
        public int? Rating { get; set; }

        [Display(Name = "İzlendi mi?")]
        public bool IsWatched { get; set; }
    }
}
