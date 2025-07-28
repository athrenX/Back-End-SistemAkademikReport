using System.ComponentModel.DataAnnotations;

namespace SistemAkademik.Models;

public class JenisNilai
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(50)]
    public string NamaJenis { get; set; }
}
