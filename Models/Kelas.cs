using System.ComponentModel.DataAnnotations;

namespace SistemAkademik.Models;

public class Kelas
{
    [Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(50)]
    public string NamaKelas { get; set; }
}
